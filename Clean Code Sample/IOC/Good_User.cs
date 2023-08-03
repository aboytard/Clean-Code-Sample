namespace Clean_Code_Sample.IOC
{
    public class Good_User
    {
        Good_MySqlDatabase Good_MySqlDatabase;

        public Good_User(Good_MySqlDatabase good_MySqlDatabase)
        {
            this.Good_MySqlDatabase = good_MySqlDatabase;
        }
        public void add(string data)
        {
            Good_MySqlDatabase.persist(data);
        }
    }
    // can now use the persistance of data to unit test
}
