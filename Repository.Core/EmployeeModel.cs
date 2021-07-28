using Repository.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Repository.Core
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string Salary { get; set; }
        public string Image { get; set; }
        public DateTime? DOB { get; set; }
        public string MoNumber { get; set; }
        public enumDepartment DeptName { get; set; }
        public bool IsActive { get; set; }
        public int AId { get; set; }
        public Hobby Hobby { get; set; }

        httppostedfilebase ImageFile { get; set; }
    }
}
