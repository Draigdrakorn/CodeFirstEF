using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CodeFirstEntityFramework.Code;

namespace CodeFirstEntityFramework
{
    public partial class CodeFirstControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeContext empContext = new EmployeeContext();
            Department dept1 = new Department() { DepartmentName= "Department1"} ;
            Employee empDraig = new Employee() { EmployeeName = "Draig" };
            Employee empResha = new Employee() { EmployeeName = "Resha" };

            dept1.Employees.Add(empDraig);
            dept1.Employees.Add(empResha);
            empContext.Departments.Add(dept1);
            empContext.SaveChanges();
        }
    }
}