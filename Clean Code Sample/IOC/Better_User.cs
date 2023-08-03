namespace Clean_Code_Sample.IOC
{
    public class Better_User
    {
        IDatabase Good_MySqlDatabase;

        public Better_User(IDatabase good_MySqlDatabase)
        {
            this.Good_MySqlDatabase = good_MySqlDatabase;
        }
        public void add(string data)
        {
            Good_MySqlDatabase.persist(data);
    }
        }
}
