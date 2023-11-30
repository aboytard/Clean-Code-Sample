using System;

namespace Clean_Code_Sample.Helper.Test_Helper
{
    internal class AsyncTest
    {
        private readonly Random random = new();

        protected async Task Pause()
        {
            await Task.Delay(random.Next(200, 400));
        }

        protected bool WaitFor(Func<bool> f, int maxMsToWait)
        {
            for (int i = 0; i < maxMsToWait; i += 100)
            {
                Task.Delay(100).Wait();
                Thread.Sleep(100);
                if (f())
                {
                    return true;
                }
            }
            return false;
        }

        protected bool WaitForResults(Task taskToWait)
        {
            return WaitFor(() =>
            {
                return taskToWait.IsCompleted;
            }, 1000);
        }
    }
}
