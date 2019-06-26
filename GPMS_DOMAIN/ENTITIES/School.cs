using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPMS_DOMAIN.ENTITIES
{
   public class School
    {
        public int IdSchool { get; set; }
        public string LabelShcool { get; set; }

        public Country Country;
        public Site Site;

    }
}
