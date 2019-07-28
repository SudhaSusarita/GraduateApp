using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateApp
{

    /**
   * 
   * POJO class to store customer data
   * 
   * Getter setter is set 
   * 
   * GetAll returns current values of this class
   * 
   * ReportonAge returns current customer values
   * 
   * 
   * **/
    class Customer
    {
        String foreName;
        String surName;
        DateTime dateOfBirth;
        public List<Vehicle> Vehicles { get; set; }

        int age;
        public string GetAll()

        {
            String VehicleInformation = "";

            foreach (Vehicle item in Vehicles)
            {
                VehicleInformation = item.Reporter();
            }

            return "Customer Information :: [foreName=" + foreName + ", surName=" + surName + ", dateOfBirth=" + dateOfBirth + "] Vehicle Details "+ VehicleInformation;

           
        }

        public Customer(string foreName, string surName, DateTime dateOfBirth, int age, List<Vehicle> vehicles) {
            this.ForeName = foreName;
            this.SurName = surName;
            this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.Vehicles = vehicles;
            }
        public String ReportonAge() {
            return "Customer Information :: [foreName=" + foreName + ", surName=" + surName + ", dateOfBirth=" + dateOfBirth + "]";
        }
        public string ForeName { get => foreName; set { 
                if (value == null)
                    foreName = "";
                else
                    foreName = value;
            }
 }
        public string SurName { get => surName; set
            {
                if (value == null)
                    surName = "";
                else
                    surName = value;
            }
        }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        
       

        public int Age { get => age; set => age = value; }


     
        public Customer()
        {
        }
    }
}
