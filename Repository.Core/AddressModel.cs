using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Core
{
   public class AddressModel
    {
        public int AId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
    }
}
