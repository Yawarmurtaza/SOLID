using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    using System.Security.Cryptography.X509Certificates;
    using LSP;

    class Program
    {
        static void Main(string[] args)
        {
            IList<int> nullList = null;
            Test(nullList);
            


            //CarClient client = new CarClient();
            //client.Run();
        }

        public static void Test(IList<int> list)
        {
            foreach (var i in list ?? Enumerable.Empty<int>())
            {
            }
        }
    }
}
