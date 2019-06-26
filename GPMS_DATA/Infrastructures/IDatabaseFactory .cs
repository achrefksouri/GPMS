
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPMS_DATA.Infrastructures
{
    public interface IDatabaseFactory : IDisposable
    {
        Context DataContext { get; }
    }

}
