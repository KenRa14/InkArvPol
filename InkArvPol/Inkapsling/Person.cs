using System.Runtime.CompilerServices;

namespace InkArvPol.Inkapsling
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private float height;
        private float weight;

        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
            Age = 1;
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age should be greater than 0");
                }
                age = value;
            }
        }
        public string FName
        {
            get => fName;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Full name can't have less than 2 or more than 10 characters");
                }
                fName = value;
            }
        }
        public string LName
        {
            get => lName;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name can't have less than 3 or more than 15 characters");
                }
                lName = value;
            }
        }
        public float Height { get => height; set => height = value; }
        public float Weight { get => weight; set => weight = value; }
    }
}