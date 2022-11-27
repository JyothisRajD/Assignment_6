using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Challenge6.DAL
{
    public class Dep_Dal
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public Dep_Dal()
        {
            string conn = ConfigurationManager.ConnectionStrings["bro"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int DepartmentInsert(BAL.Dep_Bal Dep)
        {
            string qry = "insert into Department values('" + Dep.DepName + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable ViewDepartment()
        {
            string qry = "select * from Department ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;

        }

        public int UpdateDepartment(BAL.Dep_Bal Dep)
        {
            string s = "update Department set DepartmentName = '" + Dep.DepName + "' where DepartmentId = '" + Dep.DepId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int DeleteDepartment(BAL.Dep_Bal Dep)
        {
            string s = "Delete from Department where DepartmentId = '" + Dep.DepId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }


    }
}