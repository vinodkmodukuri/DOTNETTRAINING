using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class SqlConnectionReadDemo
    {

        public void ReadData()
        {
            //string CS = "data source=DESKTOP-TIKDAE2;  initial catalog=automobilestore; integrated security=true";

            try
            {

                SqlConnection con = new SqlConnection("data source=DESKTOP-TIKDAE2;  initial catalog=automobilestore; integrated security=true");
                //SqlCommand cmd = new SqlCommand("insert into item values(1, 'Engine Oil', 2, '5w 30 Engine oil for GM')", con);

               SqlCommand cmd = new SqlCommand("select * from item", con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("Item ID \t Item Name \t \t Item Quantity \t\t Item Description");

                while (reader.Read())
                {
                    Console.WriteLine("{0}\t\t{1}\t\t\t {2}\t\t {3}", reader[0], reader[1], reader[2], reader[3]);

                }

                //Step 5: Close the Connection Object
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message is {0}", ex.Message);
            }
        }
        public static void Main(string[] args)
        {

            SqlConnectionReadDemo sqlConnectionReadDemo = new SqlConnectionReadDemo();
            sqlConnectionReadDemo.ReadData();
            Console.ReadKey();


        }
    }
}
