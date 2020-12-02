using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeViewer.Models
{
    public class DepartmentInfo
    {
        [Key]
        public int DEPARTMENT_CODE { get; set; }
        public string NAME { get; set; }
    }
}
