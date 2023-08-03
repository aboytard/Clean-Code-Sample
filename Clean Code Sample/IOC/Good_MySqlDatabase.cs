namespace Clean_Code_Sample.IOC
{
    public class Good_MySqlDatabase: IDatabase
    {
        public void persist(string data)
        {
            Console.Write(data);
        }
    }

    public class Good_OracleDatabase: IDatabase
    {
        public void persist(string data)
        {
            Console.Write(data);
        }
    }

    public interface IDatabase
    {
        void persist(string data);
    }
}
