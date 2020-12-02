using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeViewer.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int EMPLOYEE_NO { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string FULL_NAME { get; set; }
        public int DEPARTMENT_CODE { get; set; }
        public string POSTAL_CODE { get; set; }
        public string ADDRESS { get; set; }
        public string TEL { get; set; }
        public string BIRTHDAY { get; set; }
        public string SEX { get; set; }
        public string REMARKS { get; set; }
        public string REGIST_DATE { get; set; }
        public string UPDATE_DATE { get; set; }
        public string DELETE_DATE { get; set; }
    }
}
