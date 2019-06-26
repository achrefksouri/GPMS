using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPMS_DOMAIN.ENTITIES
{
   public class AcademicYear
    {
        public int IdAcademicYear { get; set; }
        public  int Session { get; set; }
        //propriétes de navigation
        public List<Student> StudentList;


    }
}
