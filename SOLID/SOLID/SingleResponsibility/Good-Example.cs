namespace SOLID.SingleResponsibility
{
    //SCENARIO 2 -> Good -> we are seperating the operations

    //A.
    public class Distributor
    {
        public string DistributorName { get; set; }
        public string DistributorPassword { get; set; }
    }

    //B.
    public class DistributorManager
    {
        public void Login(Distributor client)
        {
            using (SqlConnection con = new SqlConnection(""))
            {
                //login codes here
            }
        }
    }

    //C. 
    public class LogManager
    {
        public void LogOperation(string loggingText)
        {
            //write to anywhere
        }
    }
}
