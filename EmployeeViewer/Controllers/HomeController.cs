using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeViewer.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeViewer.Controllers
{
    public class HomeController : Controller
    {

        public Data.MySQLDbContext DbContext { get; }

        public HomeController(Data.MySQLDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmployeeInfos()
        {
            try
            {
                var joinEmps = from employee in DbContext.MST_EMPLOYEEINFO
                               join department in DbContext.MST_DEPARTMENT
                               on employee.DEPARTMENT_CODE equals department.DEPARTMENT_CODE into joinemp
                               from subdep in joinemp.DefaultIfEmpty()
                               select new
                               {
                                   employee_no = employee.EMPLOYEE_NO
                                   ,
                                   first_name = employee.FIRST_NAME
                                   ,
                                   last_name = employee.LAST_NAME
                                   ,
                                   full_name = employee.FULL_NAME
                                   ,
                                   department_code = subdep.NAME
                                   ,
                                   postal_code = employee.POSTAL_CODE
                                   ,
                                   address = employee.ADDRESS
                                   ,
                                   tel = employee.TEL
                                   ,
                                   birthday = employee.BIRTHDAY
                                   ,
                                   sex = employee.SEX
                                   ,
                                   remarks = employee.REMARKS
                                   ,
                                   regist_date = employee.REGIST_DATE
                                   ,
                                   update_date = employee.UPDATE_DATE
                               };

                var sel = joinEmps.ToList();

                //Returning Json Data    
                string draw = null;
                var jsonResult = Json(
                new
                {
                    draw = draw,
                    recordsFiltered = sel.Count,
                    recordsTotal = sel.Count,
                    data = sel
                });

                return jsonResult;
            }
            catch (Exception ex)
            {
                var jsonResult = Json(
                        new
                        {
                            draw = string.Empty,
                            recordsFiltered = 0,
                            recordsTotal = 0,
                            data = Json(new {})
                        });

                return jsonResult;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
