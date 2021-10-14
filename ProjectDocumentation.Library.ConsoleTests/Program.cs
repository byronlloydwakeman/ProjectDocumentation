using ProjectDocumentation.Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDocumentation.Library.ConsoleTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = ElectronicComponentsData.GetListOfComponentsByName("Zener Diode");
        }
    }
}
