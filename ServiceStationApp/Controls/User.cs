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
        private string secondName { get; set; }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        private string thirdName { get; set; }
        public string ThirdName
        {
            get { return thirdName; }
            set { thirdName = value; }
        }
        private string passport { get; set; }
        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }
        public User() { }
        public User(int id, string name, string second_name, string thirdName, string passport)
        {
            ID = id;
            Name = name;
            SecondName = second_name;
            ThirdName = thirdName;
            Passport = passport;
        }
    }
}
