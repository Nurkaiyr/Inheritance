using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Flash:Storage
    {
        private double speedUsb30;
        private double storageValue;
        private double freeSpace;

        public Flash()
        {
            SpeedUsb30 = 625;      
            StorageValue = 4000;   
            FreeSpace = StorageValue;
            Name = "Flash ";
            Model = String.Format("{0}GB USB3.0", StorageValue / 1000);
        }

        public double SpeedUsb30
        {
            get { return speedUsb30; }
            set { speedUsb30 = value; }
        }
        public double StorageValue
        {
            get { return storageValue; }
            set { storageValue = value; }
        }
        public double FreeSpace
        {
            get { return freeSpace; }
            set { freeSpace = value; }
        }

        public override void CopyDataToDevice(File[] files, out double timeSpend, out File[] remainingFiles)
        {
            double filesSize = 0;

            int i = 0;
            while (filesSize < StorageValue)
                filesSize += files[i++].Size;

            timeSpend = filesSize / SpeedUsb30;
            FreeSpace = StorageValue - filesSize;

            remainingFiles = new File[files.Length - i];
            int j = 0;
            while (i < files.Length)
                remainingFiles[j++] = files[i];
        }

        public override string GetDeviceInfo()
        {
            return String.Format("{0}{1}\nСкорость - {2}\nОбъем памяти - {3}\nСвободное место - {4}\n", Name, Model, SpeedUsb30, StorageValue, FreeSpace);
        }

        public override double GetFreeSpaceValue()
        {
            throw new NotImplementedException();
        }

        public override double GetStorageValue()
        {
            return StorageValue;
        }

    }

}

