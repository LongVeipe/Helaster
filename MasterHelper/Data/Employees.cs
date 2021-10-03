using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterHelper.Data
{
    class Employees
    {
        private static Employees __instant;

        public static Employees getInstant()
        {
            if (__instant == null)
                __instant = new Employees();
            return __instant;
        }

        private DataTable employees = new DataTable();
        public Employees()
        {
            employees.Columns.Add("name", typeof(string));
            employees.Columns.Add("gender", typeof(string));

            add("Nhân viên 1", "nam");
            add("Nhân viên 2", "nữ");
            add("Nhân viên 3", "nam");
        }

        public DataRow getEmployeeById(int id)
        {
            return employees.Rows[id];
        }

        public void add(string name, string gender)
        {
            employees.Rows.Add(new object[] { name, gender });
            employees.AsDataView().Sort = "name ASC";
            employees.AcceptChanges();
        }

    }
}
