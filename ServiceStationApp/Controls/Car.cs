using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStationApp.Controls
{
    public class Car
    {
        private int iD { get; set; }
        public int id
        {
            get { return iD; }
            set { iD = value; }
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
        public Car(string mark, string model, string yearMaid, string pts)
        {
            Mark = mark;
            Model = model;
            YearMaid = yearMaid;
            PTS = pts;
        }
    }
}
