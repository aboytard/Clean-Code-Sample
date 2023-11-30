using System.Buffers;

namespace Clean_Code_Sample.Helper
{
    internal class Base64ImageHelper
    {
        private static object _lock = new object();
        public string ContentType { get; set; }

        public byte[] FileContents { get; set; }

        public Base64ImageHelper() { }

        // this mecanism is triggering a deadlock
        public async static Task<string> GetFileBase64Content(string filename)
        {
            var fileBytes = await File.ReadAllBytesAsync(filename);
            return Convert.ToBase64String(fileBytes);
        }

        // using a lock and using --> we do not have the deadlock-issue
        public static string ConvertFileToBase64Async(string filePath)
        {
            lock (_lock)
            {
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None,
                 bufferSize: 4096, useAsync: true))
                {
                    var length = (int)fs.Length;
                    var buffer = ArrayPool<byte>.Shared.Rent(length);

                    try
                    {
                        fs.Read(buffer, 0, length);

                        var base64String = Convert.ToBase64String(buffer, 0, length);
                        return base64String;
                    }
                    finally
                    {
                        ArrayPool<byte>.Shared.Return(buffer);
                    }
                }
            }
        }

        public static Base64ImageHelper Parse(string base64Content)
        {
            if (string.IsNullOrEmpty(base64Content))
                throw new ArgumentNullException(nameof(base64Content));

            int indexOfSemiColon = base64Content.IndexOf(";", StringComparison.OrdinalIgnoreCase);

            string dataLabel = base64Content.Substring(0, indexOfSemiColon);

            string contentType = dataLabel.Split(':').Last();

            var startIndex = base64Content.IndexOf("base64,", StringComparison.OrdinalIgnoreCase) + 7;

            var fileContents = base64Content.Substring(startIndex);

            var bytes = Convert.FromBase64String(fileContents);

            return new Base64ImageHelper
            {
                ContentType = contentType,
                FileContents = bytes
            };
        }

        public static string Base64ToString(byte[] FileContent, string ContentType)
        {
            return $"data:{ContentType.Replace(".", "")};base64,{Convert.ToBase64String(FileContent)}";
        }
    }
}
