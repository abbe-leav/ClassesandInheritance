using System;
using System.Diagnostics;
using System.Drawing;

namespace ModernAppliances
{
    public class Appliance
    {
        public string? itemNumber { get; set; }
        public string? brand { get; set; }
        public int quantity { get; set; }
        public int wattage { get; set; }
        public string? color { get; set; }
        public decimal price { get; set; }

        public Appliance(string ItemNumber, string Brand, int Quantity, int Wattage, string Color, decimal Price)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
        }

        public override string ToString()
        {
            return $"Item Number: {itemNumber}\n" +
                   $"Brand: {brand}\n" +
                   $"Quantity: {quantity}\n" +
                   $"Wattage: {wattage}\n" +
                   $"Color: {color}\n" +
                   $"Price: {price:C}\n";
        }
    }
    public class Refrigerator : Appliance
    {
        public int numberOfDoors { get; set; }
        public int height { get; set; }
        public int width { get; set; }

        public Refrigerator(string itemNumber, string brand, int quantity, int wattage, string color, decimal price,
                        int NumberOfDoors, int Height, int Width)
        : base(itemNumber, brand, quantity, wattage, color, price)
        {
            NumberOfDoors = numberOfDoors;
            Height = height;
            Width = width;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Number of Doors: {numberOfDoors}\n" +
                   $"Height: {height} inches\n" +
                   $"Width: {width} inches\n";
        }
    }
    public class Vacuum : Appliance
    {
        public string? grade { get; set; }
        public int batteryVoltage { get; set; }

        public Vacuum(string itemNumber, string brand, int quantity, int wattage, string color, decimal price,
                  string Grade, int BatteryVoltage)
        : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Grade = grade;
            BatteryVoltage = batteryVoltage;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Grade: {grade}\n" +
                   $"Battery Voltage: {batteryVoltage} V\n";
        }
    }
    public class Microwave : Appliance
    {
        public double capacity { get; set; }
        public string? roomType { get; set; }

        public Microwave(string itemNumber, string brand, int quantity, int wattage, string color, decimal price,
                     double Capacity, string RoomType)
        : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Capacity = capacity;
            RoomType = roomType;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Capacity: {capacity}\n" +
                   $"Room Type: {(roomType.Equals('K') ? "Kitchen" : "Work Site")}\n";
        }
    }
    public class Dishwasher : Appliance
    {
        public string? soundRating { get; set; }
        public string? feature {  get; set; }

        public Dishwasher(string itemNumber, string brand, int quantity, int wattage, string color, decimal price,
                      string Feature, string SoundRating)
        : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Feature = feature;
            SoundRating = soundRating;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Feature: {feature}\n" +
                   $"Sound Rating: {soundRating}\n";
        }
    }
}
