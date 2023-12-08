using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStationApp.Controls
{
    public class Order
    {
        private int id { get; set; }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int id_client { get; set; }
        public int ID_Client
        {
            get { return id_client; }
            set { id_client = value; }
        }
        private int id_car { get; set; }
        public int ID_Car
        {
            get { return id_car; }
            set { id_car = value; }
        }
        private string subject { get; set; }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        private string about { get; set; }
        public string About
        {
            get { return about; }
            set { about = value; }
        }
        private string price { get; set; }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public Order() { }
        public Order(int _id, int _id_Client, int _id_Car, string _subject, string _about, string _price)
        {
            ID = _id;
            ID_Client = _id_Client;
            ID_Car = _id_Car;
            Subject = _subject;
            About = _about;
            Price = _price;
        }
    }
}
