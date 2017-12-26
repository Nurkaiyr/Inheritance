using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage[] devices = new Storage[1];
            devices[0] = new Flash();


            Menu menu = new Menu(devices);
            menu.Handler();
        }
    }
}
