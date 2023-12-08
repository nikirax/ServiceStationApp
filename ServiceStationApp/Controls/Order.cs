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
        private int idClient { get; set; }
        public int IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }
        private int idCar { get; set; }
        public int IdCar
        {
            get { return idCar; }
            set { idCar = value; }
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
        public Order(int id, int idClient, int idCar, string subject, string about, string price)
        {
            ID = id;
            IdClient = idClient;
            IdCar = idCar;
            Subject = subject;
            About = about;
            Price = price;
        }
    }
}
