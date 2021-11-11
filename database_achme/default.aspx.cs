using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace database_achme
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            customersEntities db = new customersEntities();
            var customers = db.customers;

            db.SaveChanges();
            string result = "";
            foreach (var customer in customers)
            {
                result += "<p>" + customer.Name + "</p>";

            }

            customer_gridview.DataSource = customers.ToList();
            customer_gridview.DataBind();
           // resultLable.Text = result;

        }

        public static void Addcustomer(customer newCustomer)
        {
            var customer = new customer();
            customer.Id = newCustomer.Id;
            customer.Name = newCustomer.Name;
            customer.Address = newCustomer.Address;
            customer.City = newCustomer.City;
            customer.PostCode = newCustomer.PostCode;
            customer.Notes = newCustomer.Notes;

            customersEntities db = new customersEntities();
            var dbcustomers = db.customers;
            dbcustomers.Add(customer);
            db.SaveChanges();


        }

        protected void buttonSave_Click(object sender, EventArgs e)
        {

            var newcustomer = new customer();

           // Random random = new Random();


            //newcustomer.Id = random.Next(0, 2000);
            newcustomer.Name = tb_name.Text;
            newcustomer.Address = tb_addr.Text;
            newcustomer.City = tb_city.Text;
            newcustomer.PostCode = tb_pcode.Text;
            newcustomer.Notes = tb_notes.Text;

            Addcustomer(newcustomer);
            customer_gridview.DataBind();

        }
        /*private void displaycustomers()
        {
            customersEntities db = new customersEntities();
            var dbcustomers = db.customers;
            customer_gridview.DataSource = dbcustomers.ToList();
            customer_gridview.DataBind();
        }
        */
    }
}