
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class AdoDemoAutoMobileStore
    {
        public void SupplierInsert()
        {

            try
            {

                //Step 1: Create a Connection Object
                SqlConnection conn = new SqlConnection("data source =DESKTOP-TIKDAE2; database = automobilestore; integrated security= true");

                //Step 2: Create a Command Object 

                //SqlCommand cmd = new SqlCommand("insert into supplier values(1, 'Engine Oil', 'Harry Patrick')", conn);
                //SqlCommand cmd1 = new SqlCommand("insert into supplier values(2, 'Battery', 'Mary Wong')", conn);
                SqlCommand cmd2 = new SqlCommand("insert into supplier values(3, 'Air Filter', 'Taylor John')", conn);

                //Step 3: Open the Connection Object
                conn.Open();

                //Step 4: Execute SQL Statements in the Command Object
/*                int result = cmd.ExecuteNonQuery();
                int result1 = cmd1.ExecuteNonQuery();*/
                int result2 = cmd2.ExecuteNonQuery();

                if (result2 > 0)
                {
                    Console.WriteLine("Records inserted successfully");
                }
                else
                {
                    Console.WriteLine("Records not not inserted");
                }

                //Step 5: Close the Connection Object
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SupplierUpdate()
        {

            try
            {

                SqlConnection conn = new SqlConnection("data source =DESKTOP-TIKDAE2; database = automobilestore; integrated security= true");

                SqlCommand cmd1 = new SqlCommand(("update supplier set supplier_contact = 'Kevin Morrow' where supplier_ID=1"), conn);
                SqlCommand cmd2 = new SqlCommand(("update supplier set supplier_contact = 'John Rooney' where supplier_ID=2"), conn);


                //Step 3: Open the Connection Object
                conn.Open();

                //Step 4: Execute SQL Statements in the Command Object
                /*                int result = cmd.ExecuteNonQuery();
                                int result1 = cmd1.ExecuteNonQuery();*/
                int result2 = cmd1.ExecuteNonQuery();
                int result3 = cmd2.ExecuteNonQuery();


                if (result2 > 0 && result3 >0)
                {
                    Console.WriteLine("Record updated successfully");
                }
                else
                {
                   Console.WriteLine("Record not updated");
                }

                //Step 5: Close the Connection Object
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SupplierDelete()
        {
            try
            {
                SqlConnection conn = new SqlConnection("data source =DESKTOP-TIKDAE2; database = automobilestore; integrated security= true");

                SqlCommand cmd1 = new SqlCommand(("delete supplier where supplier_ID = 3"), conn);

                //Step 3: Open the Connection Object
                conn.Open();

                //Step 4: Execute SQL Statements in the Command Object
                /*                int result = cmd.ExecuteNonQuery();
                                int result1 = cmd1.ExecuteNonQuery();*/
                int result2 = cmd1.ExecuteNonQuery();

                if (result2 > 0)
                {
                    Console.WriteLine("Record Deleted successfully");
                }
                else
                {
                    Console.WriteLine("Record is not deleted");
                }

                //Step 5: Close the Connection Object
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public void SupplierDisplay()
        {
            try
            {
                SqlConnection conn = new SqlConnection("data source =DESKTOP-TIKDAE2; database = automobilestore; integrated security= true");

                SqlCommand cmd1 = new SqlCommand(("select * from supplier "), conn);

                conn.Open();

                SqlDataReader reader = cmd1.ExecuteReader();

                Console.WriteLine("SupplierID \t Supplier Name \t \t Supplier Contact ");

                while (reader.Read())
                {
                   Console.WriteLine("{0}\t\t {1}\t\t {2}\t\t", reader[0],reader[1], reader[2]);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main(string[] args)
        {
            AdoDemoAutoMobileStore adoDemoAutoMobileStore = new AdoDemoAutoMobileStore();
            //adoDemoAutoMobileStore.SupplierInsert();
            //adoDemoAutoMobileStore.SupplierUpdate();
            //adoDemoAutoMobileStore.SupplierDelete();
            adoDemoAutoMobileStore.SupplierDisplay();


            Console.ReadKey();
        }
    }
}
