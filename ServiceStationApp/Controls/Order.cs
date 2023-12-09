using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStationApp.Controls
{
    public class Order
    {
        private int iD { get; set; }
        public int id
        {
            get { return iD; }
            set { iD = value; }
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
        public Order(int idClient, int idCar, string subject, string about, string price)
        {
            IdClient = idClient;
            IdCar = idCar;
            Subject = subject;
            About = about;
            Price = price;
        }
    }
}
