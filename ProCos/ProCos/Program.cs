using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCos
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class driverslicense
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string gender { set; get; }
        public string licenseNumber { set; get; }
    public driverslicense (string firstName, string lastName, string gender, string licenseNumber)
        {
            
        }
    
    public string getFullName()
    {
        return ("firstName" + "lastName");
    }
    }
    


    public class book
    {
        public string title;
        public string authors;
        public int pages;
        public int Sku;
        public string publisher;
        public int price;
    }

    public class airplane
    {
        public string Manufacturer;
        public string model;
        public string variant;
        public int capacity;
        public int engines;
    }
}
