using System;

namespace ManageCarPark
{
    public class Engine
    {
        public decimal Power { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        public Engine(decimal power, int volume, string type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }

    }

    public class Chassis
    {
        public int WheelsNumber { get; set; }
        public string Number { get; set; }
        public int PermissibleLoad { get; set; }

        public Chassis(int wheelsNumber, string number, int permissibleLoad)
        {
            WheelsNumber = wheelsNumber;
            Number = number;
            PermissibleLoad = permissibleLoad;
        }
    }

    public class Transmission
    {
        public string Type { get; set; }
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }

        public Transmission(string type, int numberOfGears, string manufacturer)
        {
            Type = type;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

    }

    class Program
    {
        public static void Main(string [] args)
        {

            Engine passengerCarEngine = new Engine(2, 175, "turbo", "1554hf");
            Engine truckEngine = new Engine(3.4m, 200, "turbo", "1578kh");
            Engine busEngine = new Engine(4, 200, "turbo", "1578kh");
            Engine scooterEngine = new Engine(2, 190, "turbo", "48652f4");

            Chassis passengerCarChassis = new Chassis(4, "5844kh3", 300);
            Chassis truckChassis = new Chassis(4, "892a35", 800);
            Chassis busChassis = new Chassis(4, "8425ds", 500);
            Chassis scooterChassis = new Chassis(4, "tybh69874", 100);

            Transmission passengerCarTransmission = new Transmission("automatic", 10, "Japan");
            Transmission truckTransmission = new Transmission("automatic", 5, "China");
            Transmission busTransmission = new Transmission("automatic", 7, "Japan");
            Transmission scooterTransmission = new Transmission("automatic", 3, "USA");


            Console.WriteLine("Passenger Car Engine - Power: "  + passengerCarEngine.Power + ", Volume: " + passengerCarEngine.Volume + ", Type: " + passengerCarEngine.Type + ", SerialNumber: " + passengerCarEngine.SerialNumber);
            Console.WriteLine("Passenger Car Chassis - Wheels Number: " + passengerCarChassis.WheelsNumber + ", Number: " + passengerCarChassis.Number + ", Permissible Load: " + passengerCarChassis.PermissibleLoad);
            Console.WriteLine("Passenger Car Transmission - Type: " + passengerCarTransmission.Type + ", Number of Gears: " + passengerCarTransmission.NumberOfGears + ", Manufacturer: " + passengerCarTransmission.Manufacturer);
            
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
           
            Console.WriteLine("Truck Engine - Power: " + truckEngine.Power + ", Volume: " + truckEngine.Volume + ", Type: " + truckEngine.Type + ", SerialNumber: " + truckEngine.SerialNumber);
            Console.WriteLine("Truck Chassis - Wheels Number: " + truckChassis.WheelsNumber + ", Number: " + truckChassis.Number + ", Permissible Load: " + truckChassis.PermissibleLoad);
            Console.WriteLine("Truck Transmission - Type: " + truckTransmission.Type + ", Number of Gears: " + truckTransmission.NumberOfGears + ", Manufacturer: " + truckTransmission.Manufacturer);
            
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Bus Engine - Power: " + busEngine.Power + ", Volume: " + busEngine.Volume + ", Type: " + busEngine.Type + ", SerialNumber: " + busEngine.SerialNumber);
            Console.WriteLine("Bus Chassis - Wheels Number: " + busChassis.WheelsNumber + ", Number: " + busChassis.Number + ", Permissible Load: " + busChassis.PermissibleLoad);
            Console.WriteLine("Bus Transmission - Type: " + busTransmission.Type + ", Number of Gears: " + busTransmission.NumberOfGears + ", Manufacturer: " + busTransmission.Manufacturer);
            
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Scooter Engine - Power: " + scooterEngine.Power + ", Volume: " + scooterEngine.Volume + ", Type: " + scooterEngine.Type + ", SerialNumber: " + scooterEngine.SerialNumber);
            Console.WriteLine("Scooter Chassis - Wheels Number: " + scooterChassis.WheelsNumber + ", Number: " + scooterChassis.Number + ", Permissible Load: " + scooterChassis.PermissibleLoad);
            Console.WriteLine("Scooter Transmission - Type: " + scooterTransmission.Type + ", Number of Gears: " + scooterTransmission.NumberOfGears + ", Manufacturer: " + scooterTransmission.Manufacturer);

        }

    }

}