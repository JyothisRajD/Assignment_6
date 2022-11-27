using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Challenge6.BAL
{
    public class Dep_Bal
    {
        DAL.Dep_Dal depDAL = new DAL.Dep_Dal();
        private string _departmentname;
        private string _departmentid;
        public string DepName
        {
            get
            {
                return _departmentname;
            }
            set
            {
                _departmentname = value;
            }
        }
        public string DepId
        {
            get { return _departmentid; }
            set { _departmentid = value; }
        }

        public int InsertDepartment()
        {
            return depDAL.DepartmentInsert(this);
        }

        public DataTable ViewDep()
        {
            return depDAL.ViewDepartment();
        }

        public int UpdateDep()
        {
            return depDAL.UpdateDepartment(this);
        }

        public int DeleteUpd()
        {
            return depDAL.DeleteDepartment(this);
        }
    }
}