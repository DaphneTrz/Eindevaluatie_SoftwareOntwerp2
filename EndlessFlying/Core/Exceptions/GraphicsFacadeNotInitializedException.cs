using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Core.Exceptions
{
    public class GraphicsFacadeNotInitializedException : Exception
    {

        public GraphicsFacadeNotInitializedException()
            : base("Fout: De graphics kunnen niet geladen worden.")
        {
        }

    }
}
