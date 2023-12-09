using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStationApp.Controls
{
    public class User
    {
        private int iD { get; set; }
        public int id
        {
            get { return iD; }
            set { iD = value; }
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
        public User(string name, string second_name, string thirdName, string passport)
        {
            Name = name;
            SecondName = second_name;
            ThirdName = thirdName;
            Passport = passport;
        }
    }
}
