using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class SqlConnectionInsertDemoGlobalConnection
    {

        public void InsertDataUsinfGlobalConnection()
        {
            //string CS = "ConfigurationManager.ConnectionStrings["SqlLocalDatabseConnection"].ConnectionString);

            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlLocalDatabseConnection"].ConnectionString);

                SqlCommand cmd = new SqlCommand("insert into item values(3, 'Coolent', 1, 'GM Collent')", con);

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
            catch (Exception ex)
            {
                Console.WriteLine("Error message is {0}", ex.Message);
            }


        }

        public static void Main(string[] args)
        {
            SqlConnectionInsertDemoGlobalConnection myobj = new SqlConnectionInsertDemoGlobalConnection();
            myobj.InsertDataUsinfGlobalConnection();
            Console.ReadKey();
        }
    }
}
