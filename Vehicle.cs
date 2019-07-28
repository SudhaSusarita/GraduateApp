using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateApp
{
    /**
     * 
     * POJO class to store vehicle data
     * 
     * Getter setter is set 
     * 
     * Reporter returns current values of this class
     * 
     * 
     * 
     * 
     * **/
   public class Vehicle
    {
        String registNo;
        DateTime registDate;
        String interiorColour;
        String hasHelmetStorage;
        String manufacturer;
        String model;
        String owner;
        int engineSize;
        int vehicleID;
        String vehicleType;

         public string Reporter()

        {

            return " [registNo=" + registNo + ", registDate=" + registDate + ", interiorColour=" + interiorColour
                + ", hasHelmetStorage=" + hasHelmetStorage + ", manufacturer=" + manufacturer + ", model=" + model
                + ", owner=" + owner + ", engineSize=" + engineSize + ", vehicleID=" + vehicleID + ", vehicleType="
                + vehicleType + "]";
        }

        public Vehicle()
        {
        }

        public Vehicle(string registNo, DateTime registDate, string interiorColour, string hasHelmetStorage, string manufacturer, string model, string owner, int engineSize, int vehicleID, string vehicleType) 
        {
            this.registNo = registNo;
            this.registDate = registDate;
            this.interiorColour = interiorColour;
            this.hasHelmetStorage = hasHelmetStorage;
            this.manufacturer = manufacturer;
            this.model = model;
            this.owner = owner;
            this.engineSize = engineSize;
            this.vehicleID = vehicleID;
            this.vehicleType = vehicleType;
        }

   
               public String RegistNo { get => registNo; set
            {
                if (value == null)
                    registNo = "";
                else
                    registNo = value;
            }
        }

        
        public DateTime RegistDate { get => registDate; set => registDate = value; }
        

        public string InteriorColour { get => interiorColour; set
            {
                if (value == null)
                    interiorColour = "";
                else
                    interiorColour = value;
            }
        }

        public String HasHelmetStorage { get => hasHelmetStorage; set
            {
                if (value == null)
                    hasHelmetStorage = "";
                else
                    hasHelmetStorage = value;
            }
        }

        public string Manufacturer { get => manufacturer; set
            {
                if (value == null)
                    manufacturer = "";
                else
                    manufacturer = value;
            }
        }

        public string Model { get => model; set
            {
                if (value == null)
                    model = "";
                else
                    model = value;
            }
        }

        public string Owner { get => owner; set
            {
                if (value == null)
                    owner = "";
                else
                    owner = value;
            }
        }

        public int EngineSize { get => engineSize; set
            {
                if (value==0)
                    engineSize = 0;
                else
                    engineSize = value;
            }
        }

        public int VehicleID { get => vehicleID; set
            {
                if (value==0)
                    vehicleID = 0;
                else
                    vehicleID = value;
            }
        }

        public string VehicleType { get => vehicleType; set
            {
                if (value == null)
                    vehicleType = "";
                else
                    vehicleType = value;
            }
        }

    }
}
