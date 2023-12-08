using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStationApp.Controls
{
    public class User
    {
        private int id { get; set; }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string name { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string second_name { get; set; }
        public string Second_Name
        {
            get { return second_name; }
            set { second_name = value; }
        }
        private string third_name { get; set; }
        public string Third_Name
        {
            get { return third_name; }
            set { third_name = value; }
        }
        private string passport { get; set; }
        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }
        public User() { }
        public User(int _id, string _name, string _second_name, string _third_name, string _passport)
        {
            ID = _id;
            Name = _name;
            Second_Name = _second_name; 
            Third_Name = _third_name;
            Passport = _passport;
        }
    }
}
