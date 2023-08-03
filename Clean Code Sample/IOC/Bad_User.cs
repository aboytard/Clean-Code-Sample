namespace Clean_Code_Sample.IOC
{
    public class Bad_User
    {
        Bad_MySqlDatabase database;
        public Bad_User()
        {
            database = new Bad_MySqlDatabase();
        }
        public void add(string data)
        {
            database.persist(data);
        }
    }
}
