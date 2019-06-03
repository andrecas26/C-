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
        public string title { get; set; }
        public string authors { get; set; }
        public int pages { get; set; }
        public int sku { get; set; }
        public string publisher { get; set; }
        public int price { get; set; }

        public book( string title, string authors, int pages, int sku, string publisher, int price)
        {

        }
    }

    public class airplane
    {
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string variant { get; set; }
        public int capacity { get; set; }
        public int engines { get; set; }

        public airplane (string manufacturer, string model, string variant, int capacity, int engines)
        {

        }
    }
}
