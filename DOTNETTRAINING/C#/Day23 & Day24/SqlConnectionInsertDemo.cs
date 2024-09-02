using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class SqlConnectionInsertDemo
    {


        public void InsertData()
        {
            //string CS = "data source=DESKTOP-TIKDAE2;  initial catalog=automobilestore; integrated security=true";

            try
            {

                SqlConnection con = new SqlConnection("data source=DESKTOP-TIKDAE2;  initial catalog=automobilestore; integrated security=true;");

                //SqlCommand cmd = new SqlCommand("insert into item values(1, 'Engine Oil', 2, '5w 30 Engine oil for GM')", con);

                SqlCommand cmd = new SqlCommand("insert into item values(2, 'Break Oil', 2, 'GM Break oil')", con);

                con.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Record Inserted successfully");
                }
                else
                {
                    Console.WriteLine("Record is not deleted");
                }

                //Step 5: Close the Connection Object
                con.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error message is {0}",ex.Message);
                    }
        }


        public static void Main(string[] args)
        {

            SqlConnectionInsertDemo sqlConnectionInsertDemo = new SqlConnectionInsertDemo();
            sqlConnectionInsertDemo.InsertData();
            Console.ReadKey();


        }
    }
}
