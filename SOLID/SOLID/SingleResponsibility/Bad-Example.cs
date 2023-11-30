namespace SOLID.SingleResponsibility
{
    //Notice:
    //One reason to change. if there is more than one reason to change, Refactor it.

    //SCENARIO 1 -> Bad 
    public class Dealer
    {
        public string DealerName { get; set; }
        public string DealerPassword { get; set; }

        void Login()
        {
            //Operation 1  : codes for checking user on db 
            using (SqlConnection con = new SqlConnection(""))
            {
                //and other codes here.
            }
            //Operation 2  : logging codes something about operation 1
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine("");
            }
        }
    }
}
