using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterConsole.ServiceLayer;

namespace masterConsole
{
    class Program
    {
        static int Main(string[] args)
        {

            ServiceLayer.Grade grade = new ServiceLayer.Grade();

            grade.Add(3);

            Console.ReadKey();
            return 1;
        }
    }
}
