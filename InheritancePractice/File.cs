using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class File
    {
        private double size;

        public double Size
        {
            get { return size; }
            set { size = value; }
        }

        public File()
        {
            Size = 780;
        }

        public File(double size)
        {
            Size = size;
        }

    }
}
