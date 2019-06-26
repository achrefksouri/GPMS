using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPMS_DOMAIN.ENTITIES
{
   public class Site
    {
        public   int IdSite{ get; set; }
        public  string Label { get; set; }

        public List<Departement> DepartementList;
    }

}
