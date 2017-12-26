using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public abstract class Storage
    {
        private string name;
        private string model;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public abstract double GetStorageValue();
        public abstract void CopyDataToDevice(File[] files, out double timeSpend, out File[] remainingFiles);
        public abstract double GetFreeSpaceValue();
        public abstract string GetDeviceInfo();
    }
}
