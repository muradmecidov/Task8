using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal abstract class Vehicle
    {
        public string _factoryName;
        public string _model;
        public string _color;
        public int _driveTime;
        public int _drivePath;
        private string ProductionDate;
        public abstract void DefineNatureHarmness();

        public string FactoryName
        {
            get { return _factoryName; }
            set { _factoryName = value; }

        }

        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }


        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int DriveTime
        {
            get { return _driveTime; }
            set { if (value > 0) _driveTime = value; }

        }
        public int DrivePath
        {
            get { return _drivePath; }
            set { if (value > 0) _drivePath = value; }
        }
        public override string ToString()
        {
            return $"Factory name: {FactoryName}  Model: {Model}";
        }

        /*public Vehicle()
        {
            Console.WriteLine("Vehile created");
        }*/
        public void GetInfo()
        {
            Console.WriteLine($"{_factoryName} {_model} {_color} {_driveTime} {_drivePath} {_drivePath}");
        }
    }
}
