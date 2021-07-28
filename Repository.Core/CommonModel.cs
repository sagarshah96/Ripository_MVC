using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Core
{
    public class CommonModel
    {
        public EmployeeModel EmployeeModel { get; set; }
        public AddressModel AddressModel { get; set; }
    }

    public enum enumDepartment
    {
        HR = 1,
        Account = 2,
        Manager = 3,
        CEO = 4
    }

    public enum Hobby
    {
        Cricket,
        Reading,
        Dancing,
        Movies,
        Travelling
    }
}
