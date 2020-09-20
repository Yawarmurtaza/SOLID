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
            CarClient client = new CarClient();
            client.Run();
        }
    }
}
