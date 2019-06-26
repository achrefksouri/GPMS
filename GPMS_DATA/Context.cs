using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPMS_DATA
{
    public class Context : DbContext
    {
        public Context() : base("name=DBPFE")
        {

        }
    }
}
