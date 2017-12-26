using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Menu
    {
        private Storage[] _devices;

        public Menu(Storage[] devices)
        {
            _devices = devices;
        }

        public void DrawMainMenu()
        {
            Console.WriteLine
                (
                    "1 - Доступные устройства\n" +
                    "2 - Перенести данные\n" +
                    "0 - Выход\n"
                );
        }

        public void Handler()
        {
             for (int i = 0; i < _devices.Length; i++)
             {
                Console.WriteLine("[" + i + "]\n" + _devices[i].GetDeviceInfo());   
             }
            Console.ReadLine();
                   
        }
    }
}