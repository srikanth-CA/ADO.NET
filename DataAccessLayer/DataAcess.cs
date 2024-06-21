using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAcess
    {
        string ConnString = "Server=DESKTOP-O58FFG0;Database=Northwnd;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

        public DataSet Getdata()
        
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter adapter = null;
            DataSet ds = null;

                 conn = new SqlConnection(ConnString);
                 cmd = new SqlCommand("select *from employees", conn);
                 cmd.CommandType = CommandType.Text;
                 ds = new DataSet();
                 adapter = new SqlDataAdapter(cmd);
                 adapter.Fill(ds);


            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{


            //     int i =(int) dr[0];

            //}


            //SqlConnection conn1 = new SqlConnection(ConnString);
            //SqlCommand cmd1 = new SqlCommand("select *from customers", conn1);
            //cmd1.CommandType = CommandType.Text;
            //SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            //adapter1.Fill(ds);

            return ds;
         
          /*  //string str = "";
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{

               
            // // int i = dr[0];
              
            //}
         

            //in the dataset u updated 10 of 90 rows
            // adapter.Update(ds);

            //SqlConnection conn1 = new SqlConnection(ConnString);
            //SqlCommand cmd1 = new SqlCommand("select *from customers", conn1);
            //cmd1.CommandType = CommandType.Text;
            //SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            //adapter1.Fill(dt);



            return ds;
            //string str = "";
            //conn1.Open();
            //SqlDataReader dr = cmd1.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {
            //        str += ",  " + dr[0].ToString()+ ",  " + dr[1].ToString();
            //    }

            //}
            //conn1.Close();*/








        }


    }
}
