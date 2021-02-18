using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2
{
    public class Service2
    {
        private String custName;
        private String lastName;
        private String employeeID;
        private String serviceDate;
        private String estCost;
        private String compDate;
        private String vehicleUsed;
        private String inventoryDate;
        private String itemName;
        private String itemCost;
        private String itemID;
        private String moveTime;
        private String foodCost;
        private String fuelCost;
        private String lodgeCost;
        private String equipNeeded;
        private String destinationAddress;
        private String destinationCity;
        private String destinationState;
        private String destinationZip;

        private int serviceID { get; set; }
        private int customerID { get; set; }

        //constructors
        public Service2(String n, string ln, string emp, string sdate, string est, string comp, string vehicle, string idate, string iname, string icost, string iID, string mtime, string food, string fuel, string lodge, string equip, string address, string city, string state, string zip, int servID, int custID)

        {
            this.custName = n;
            this.lastName = ln;
            this.employeeID = emp;
            this.serviceDate = sdate;
            this.estCost = est;
            this.compDate = comp;
            this.vehicleUsed = vehicle;
            this.inventoryDate = idate;
            this.itemName = iname;
            this.itemCost = icost;
            this.itemID = iID;
            this.moveTime = mtime;
            this.foodCost = food;
            this.fuelCost = fuel;
            this.lodgeCost = lodge;
            this.equipNeeded = equip;
            this.destinationAddress = address;
            this.destinationCity = city;
            this.destinationState = state;
            this.destinationZip = zip;

            this.serviceID = servID;
            this.customerID = custID;
        }

        //methods (getters and setters) aka properties
        //properties handle get and set abilities
        public string CustomerName
        {
            get
            {
                return custName;
            }
            set
            {
                custName = value;
            }
        }
        public string CustomerLName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string EmployeeId
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public string ServiceDate
        {
            get
            {
                return serviceDate;
            }
            set
            {
                serviceDate = value;
            }
        }
        public string EstimatedCost
        {
            get
            {
                return estCost;
            }
            set
            {
                estCost = value;
            }
        }
        public string CompletionDate
        {
            get
            {
                return compDate;
            }
            set
            {
                compDate = value;
            }
        }
        public string VehicleUsed
        {
            get
            {
                return vehicleUsed;
            }
            set
            {
                vehicleUsed = value;
            }
        }
        public string InventoryDate
        {
            get
            {
                return inventoryDate;
            }
            set
            {
                inventoryDate = value;
            }
        }
        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }
        public string ItemCost
        {
            get
            {
                return itemCost;
            }
            set
            {
                itemCost = value;
            }
        }
        public string ItemID
        {
            get
            {
                return itemID;
            }
            set
            {
                itemID = value;
            }
        }
        public string MoveTime
        {
            get
            {
                return moveTime;
            }
            set
            {
                moveTime = value;
            }
        }
        public string FoodCost
        {
            get
            {
                return foodCost;
            }
            set
            {
                foodCost = value;
            }
        }
        public string FuelCost
        {
            get
            {
                return fuelCost;
            }
            set
            {
                fuelCost = value;
            }
        }
        public string LodgeCost
        {
            get
            {
                return lodgeCost;
            }
            set
            {
                lodgeCost = value;
            }
        }
        public string EquipmentNeeded
        {
            get
            {
                return equipNeeded;
            }
            set
            {
                equipNeeded = value;
            }
        }
        public string DestinationAddress
        {
            get
            {
                return destinationAddress;
            }
            set
            {
                destinationAddress = value;
            }
        }
        public string DestinationCity
        {
            get
            {
                return destinationCity;
            }
            set
            {
                destinationCity = value;
            }
        }
        public string DestinationState
        {
            get
            {
                return destinationState;
            }
            set
            {
                destinationState = value;
            }
        }
        public string DestinationZip
        {
            get
            {
                return destinationZip;
            }
            set
            {
                destinationZip = value;
            }
        }
    }
} 


