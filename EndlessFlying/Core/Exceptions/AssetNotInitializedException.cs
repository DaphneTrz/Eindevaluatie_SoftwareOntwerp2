using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessFlyer.Core.Exceptions
{
    public class AssetNotInitializedException : Exception
    {

        public AssetNotInitializedException(string name, Exception innerException)
            : base("Fout: Asset kan niet gevonden worden", innerException)
        {
        }

    }
}
