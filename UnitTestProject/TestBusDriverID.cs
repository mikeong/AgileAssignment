﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    class TestBusDriverID
    {
        String connStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Chun\\Documents\\GitHub\\AgileAssignment\\Assignment1.Web\\App_Data\\BusTicketing.mdf;Integrated Security = True";
        String str;
        SqlCommand cmd;

        public bool ValidBusDriverID(string busID)
        {
            bool result = false;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select * from Customer where CusContact='" + PhoneNo + "'";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                result = true;
            }
            return result;
        }
    }
}
