using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Challenge6.DAL
{
    public class Des_Dal
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public Des_Dal()
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

        public int designationInsert(BAL.Des_Bal obj)
        {
            string qry = "insert into Designation values('" + obj.DesName + "','"+obj.DepId+"')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable viewDesignation()
        {
            string qry = "select des.*,dep.* from Designation des join Department dep  on des.DepartmentId=dep.DepartmentId";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;

        }

        public int updateDesignation(BAL.Des_Bal des)
        {
            string s = "update Designation set DesignationName = '" + des.DesName + "',DepartmentId='"+des.DepId+"' where DesignationId = '" + des.DesId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int deleteDesignation(BAL.Des_Bal des)
        {
            string s = "Delete from Designation where DesignationId = '" + des.DesId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }


    }
}