
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamData.Infrastructures;

namespace GPMS_DATA.Infrastructures
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Context dataContext;
        public Context DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new Context();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
