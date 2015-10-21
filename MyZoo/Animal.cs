using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public enum Gender
    {
        M, F
    }
    public class Animal
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Gender _sex;
        public Gender Sex { get { return _sex; } set { _sex = value; } }
        public override string ToString()
        {
            return String.Format("Name: {0} Sex: {1}", Name, Sex);
        }

        public Animal():this("Lassie", Gender.F)
        {

        }

        public Animal(string nme)
        {
            Name = nme;
        }

        public Animal(string nme, Gender sx)
        {
            Name = nme;
            Sex = sx;
        }

    }  // end class
}  // end ns
