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
        private string year_maid { get; set; }
        public string Year_maid
        {
            get { return year_maid; }
            set { year_maid = value; }
        }
        private string pts { get; set; }
        public string PTS
        {
            get { return pts; }
            set { pts = value; }
        }
        public Car() { }
        public Car(int _id, string _mark, string _model, string _year_maid, string _pts)
        {
            ID = _id;
            Mark = _mark;
            Model = _model;
            Year_maid = _year_maid;
            PTS = _pts;
        }
    }
}
