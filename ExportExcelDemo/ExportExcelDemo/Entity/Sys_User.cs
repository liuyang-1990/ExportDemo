using System;

namespace ExportExcelDemo.Entity
{
    public class Sys_User
    {
        public int ID { get; set; }

        public string EmployeeCode { get; set; }

        public string EmployeeName { get; set; }

        public DateTime VCRTTIME { get; set; }

        public string VCRTUSER { get; set; }
    }
}