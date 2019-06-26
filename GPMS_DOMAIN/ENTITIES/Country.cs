using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPMS_DOMAIN.ENTITIES
{
   public class Country
    {
        public int IdCountry { get; set; }
        public string LabelCountry { get; set; }
        //propriétes de navigation
        public List<School> ShcoolList;

    }
}
