using System.Xml.Linq;

namespace InkArvPol.Inkapsling
{
    internal class PersonHandler
    {
        public Person CreatePerson(int age, string fName, string lName, float height, float weight)
        {
            return new Person(fName, lName) { Age = age, Height = height, Weight = weight };
        }

        public int GetAge(Person pers)
        {
            return pers.Age;
        }

        public void SetAge(Person pers, int value)
        {
            pers.Age = value;
        }

        public string GetFName(Person pers)
        {
            return pers.FName;
        }

        public void SetFName(Person pers, string value)
        {
            pers.FName = value;
        }

        public string GetLName(Person pers)
        {
            return pers.LName;
        }

        public void SetLName(Person pers, string value)
        {
            pers.LName = value;
        }

        public float GetHeight(Person pers)
        {
            return pers.Height;
        }

        public void SetHeight(Person pers, float value)
        {
            pers.Height = value;
        }

        public float GetWeight(Person pers)
        {
            return pers.Weight;
        }

        public void SetWeight(Person pers, float value)
        {
            pers.Weight = value;
        }
    }
}