using System;
using System.Collections.Generic;

namespace IEnumerableInterface
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (var cust in GetAllCustomer())
            {
                Console.WriteLine("Name: " + cust.Name + "<br> " + "City: " + cust.City + " <br> "
                          + "Mobile " + cust.Mobile + "<br> " + "Amount :" + cust.Amount.ToString("c") + "<br>" + "-----" + "<br>");
            }
        }
        public class Player
        {
            private String _Name;
            private int _runs;


            public String Name
            {
                get { return _Name; }
                set { _Name = value; }
            }


            public int runs
            {
                get { return _runs; }
                set { _runs = value; }
            }

        }
        Player[] Team = new Player[]
        {

            new Player {Name="Dhoni",runs=299 },
            new Player { Name = "virat",runs=199 },
            new Player { Name = "Anil", runs=399 }
        };

        public IEnumerable<Customer> GetAllCustomer()
        {
            return Customer;
        }
    }
}