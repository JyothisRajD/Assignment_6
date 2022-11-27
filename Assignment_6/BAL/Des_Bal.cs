using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Challenge6.BAL
{
    public class Des_Bal
    {
        DAL.Des_Dal desDAL = new DAL.Des_Dal();
        private int _designationId;
        private string _designationName;
        private int _departmentId;

        public int DesId
        {
            get { return _designationId; ; }
            set { _designationId = value; }
        }
        public string DesName
        {
            get
            {
                return _designationName;
            }
            set
            {
                _designationName = value;
            }
        }
        public int DepId
        {
            get { return _departmentId; }
            set { _departmentId = value; }
        }

        public int InsertDesignation()
        {
            return desDAL.designationInsert(this);
        }

        public DataTable ViewDes()
        {
            return desDAL.viewDesignation();
        }

        public int UpdateDes()
        {
            return desDAL.updateDesignation(this);
        }

        public int DeleteDes()
        {
            return desDAL.deleteDesignation(this);
        }

    }
}