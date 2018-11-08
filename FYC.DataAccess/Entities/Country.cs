using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYC.DataAccess.Entities
{
    public class Country
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string TwoCharCountryCode { get; set; }
        public string ThreeCharCountryCode { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }

    }
}
