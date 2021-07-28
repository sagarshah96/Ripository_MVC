using Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service.Providers
{
    public interface ITestService
    {
        List<EmployeeModel> EmpList();

        List<CountryModel> GetCountry();
        List<StateModel> GetStates(int CountryId);
        List<CityModel> GetCity(int StateId);
    }
}
