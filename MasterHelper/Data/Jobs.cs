using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterHelper.Data
{
    class Jobs
    {
        private static Jobs __instant;

        public static Jobs getInstant()
        {
            if (__instant == null)
                __instant = new Jobs();
            return __instant;
        }

        private DataTable jobs = new DataTable();
        public Jobs()
        {
            jobs.Columns.Add("id", typeof(string));
            jobs.Columns.Add("type", typeof(int));
            jobs.Columns.Add("address", typeof(string));
            jobs.Columns.Add("date", typeof(string));
            jobs.Columns.Add("time", typeof(string));
            jobs.Columns.Add("employeeName", typeof(string));
            jobs.Columns.Add("employeeGender", typeof(string));
            jobs.Columns.Add("price", typeof(int));
            jobs.Columns.Add("name", typeof(string));
        }

        public DataRow getJobsById(int id)
        {
            return jobs.Rows[id];
        }

        public void add(int type, string address, string date, string time, string employeeName, string employeeGender, int price, string name)
        {
            string id = jobs.Rows.Count.ToString();
            jobs.Rows.Add(new object[] { id, type, address, date, time, employeeName, employeeGender, price, name});
            jobs.AsDataView().Sort = "type ASC";
            jobs.AcceptChanges();
        }

        public DataTable getJobs()
        {
            return jobs;
        }

        public void Pay(string id)
        {
            DataRow row = jobs.Select("[id] = '" + id + "'")[0];
            jobs.Rows.Remove(row);
            jobs.AcceptChanges();
        }
    }
}
