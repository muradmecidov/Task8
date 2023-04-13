using ConsoleApp4.Models;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car {FactoryName="BMW",Model="F30",Color="Black",DrivePath=400,DriveTime=200,IsElctricCar=false,DoorCount=4, },
                new Bicycle { FactoryName="BMX" , Model="COAST" , Color="Blue" , DrivePath=15 , DriveTime=40 , Type="Road bike"}
            };
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
                vehicle.GetInfo();
            }


        }
    }
}