using System;

namespace Programming.Model
{
    public class Сontact
    {
        private string _number;

        public Сontact()
        { }

        public Сontact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public string Number
        {
            get 
            {
                return _number; 
            }
            set 
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException();
                }
                if (!int .TryParse(value, out _))
                {
                    throw new ArgumentException();
                }
                _number = value;
            }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        
    }
}
