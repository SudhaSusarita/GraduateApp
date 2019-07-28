using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateApp
{

    /**
   * 
   * Main class to perform operations
   * 
   * Age calculator calulates the current age based on the current date
   * 
   * AgeCheck performs condition to check customers between age 20 to 30
   * 
   * Vehicheck checks vehicles registered before 2010
   * 
   * CCCheck checks vehicle with engine size (cc) larger than 1100
   * 
   * GetAll returns current values of this class
   * 
   * ReportonAge returns current customer values
   * 
   * GenerateReport delegates to  business functionalities
   * 
   * 
   * **/
    class AppMain
    {
        static void Main(string[] args) {
            try
            {
                var reader = new StreamReader(File.OpenRead(@"E:\C#\Customer Information.csv"));
                List<string> listRows = new List<string>();
                List<Customer> customerList = new List<Customer>();
                List<Vehicle> vehicleList = new List<Vehicle>();
                int number;

                while (!reader.EndOfStream)
                {
                    listRows.Add(reader.ReadLine());
                }
                for (var i = 1; i < listRows.Count; i++)
                {
                    Vehicle vehicle = new Vehicle();

                    var values = listRows[i].Split(',');
                  
                    if (int.TryParse(values[4], out number))
                        vehicle.VehicleID = number;
                  
                    vehicle.RegistNo = values[5];
                    vehicle.Manufacturer = values[6];
                    vehicle.Model = values[7];
                                     
                    if (int.TryParse(values[8], out number))
                        vehicle.EngineSize = number;
                    if (values[9] != "")
                        vehicle.RegistDate = DateTime.Parse(values[9]);
                    else
                        vehicle.RegistDate = DateTime.MinValue;
                    vehicle.InteriorColour = values[10];
                    vehicle.HasHelmetStorage = values[11];
                    vehicle.VehicleType = values[12];
                   vehicleList.Add(vehicle);
                    Customer customer= new Customer(values[1], values[2], DateTime.Parse(values[3]), AgeCalculator(DateTime.Parse(values[3])), vehicleList);
                    customerList.Add(customer);

                     Console.WriteLine(customer.GetAll());
                }

                GenerateReport(customerList,vehicleList);

            }
            catch (Exception e)
            {
                Console.WriteLine("File not found");
                Console.WriteLine(e.Message);

                throw;
            }
        }

        private static void GenerateReport(List<Customer> customerList, List<Vehicle> vehicleList)

        {

            Console.WriteLine(" ");
            Console.WriteLine("All customers between the age of 20 and 30");
              ReportBasedonAge(customerList);
            Console.WriteLine(" ");
            Console.WriteLine("All Vehicles registered before 1 st January 2010");
             ReportBasedonVehi(vehicleList);
            Console.WriteLine(" ");
            Console.WriteLine("All Vehicles with an engine size over 1100");
            ReportBasedonCC(vehicleList);
        }

        private static void ReportBasedonCC(List<Vehicle> vehicleList)
        {
            if (vehicleList.FindAll(CCCheck) == null)
            {
                Console.WriteLine("No records Found");

            }
            else
            {
                foreach (Vehicle v in vehicleList.FindAll(CCCheck))
                {
                    Console.WriteLine(v.Reporter());
                }
            }
        }

        private static bool CCCheck(Vehicle obj)
        {
            return obj.EngineSize > 1100;
        }

        private static void ReportBasedonVehi(List<Vehicle> vehicleList)
        {

            if (vehicleList.FindAll(VehiCheck) == null)
            {
                Console.WriteLine("No records Found");

            }
            else
            {

                foreach (Vehicle v in vehicleList.FindAll(VehiCheck))
                {
                    Console.WriteLine(v.Reporter());
                }

            }
        }

        private static bool VehiCheck(Vehicle obj)

        {
            return obj.RegistDate.Year < 2010;
        }

        private static void ReportBasedonAge(List<Customer> customers)
        {
            if (customers.FindAll(AgeCheck) == null)
            {
                Console.WriteLine("No records Found");

            }
            else
            {
                foreach (Customer c in customers.FindAll(AgeCheck))
                {
                    Console.WriteLine(c.ReportonAge());
                }
            }

        }

        private static bool AgeCheck(Customer obj)
        {

            return (obj.Age > 20 && obj.Age < 30) ;
        }

        private static int AgeCalculator(DateTime dateOfBirth)
        {
            

            int age = DateTime.Today.Year - dateOfBirth.Year;


            return age;
        }

      
    }
}
