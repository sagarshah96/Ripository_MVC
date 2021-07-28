using Repository.Core;
using Repository.Core.Data;
using Repository.Service.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service.Services
{
    public class TestService : ITestService
    {
        public List<EmployeeModel> EmpList()
        {
            try
            {


                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CountryModel> GetCountry()
        {
            try
            {
                using (TestMasterEntities obj = new TestMasterEntities())
                {
                    return obj.Countries.Select(x => new CountryModel
                    {
                        CountryId = x.CountryId,
                        Name = x.Name
                    }).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<StateModel> GetStates(int CountryId)
        {
            try
            {
                using (TestMasterEntities obj = new TestMasterEntities())
                {
                    return obj.States.Where(x => x.CountryId == CountryId).Select(x => new StateModel
                    {
                        StateId = x.StateId,
                        Name = x.Name
                    }).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CityModel> GetCity(int StateId)
        {
            try
            {
                using (TestMasterEntities obj = new TestMasterEntities())
                {
                    return obj.Cities.Where(x => x.StateId == StateId).Select(x => new CityModel
                    {
                        CityId = x.CityId,
                        Name = x.Name
                    }).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
