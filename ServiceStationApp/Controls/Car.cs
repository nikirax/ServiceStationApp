using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStationApp.Controls
{
    public class Car
    {
        private int id { get; set; }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string mark { get; set; }
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        private string model { get; set; }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private string yearMaid { get; set; }
        public string YearMaid
        {
            get { return yearMaid; }
            set { yearMaid = value; }
        }
        private string pts { get; set; }
        public string PTS
        {
            get { return pts; }
            set { pts = value; }
        }
        public Car() { }
        public Car(int id, string mark, string model, string yearMaid, string pts)
        {
            ID = id;
            Mark = mark;
            Model = model;
            YearMaid = yearMaid;
            PTS = pts;
        }
    }
}
