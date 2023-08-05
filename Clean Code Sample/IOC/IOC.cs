namespace Clean_Code_Sample.IOC
{
    // Inversion of Control
    public class IOC
    {
        public static void Main(String[] args)
        {
            IOC container = new IOC();

            // bad
            Bad_User user = new Bad_User();
            user.add("this is some data");

            // good
            // still loosely coupled
            Good_User good_User = new Good_User(new Good_MySqlDatabase());
            good_User.add("dasdas");

            // better 
            Better_User better_User = new Better_User(new Good_OracleDatabase());
            better_User.add("asdas");
        }
    }
}
