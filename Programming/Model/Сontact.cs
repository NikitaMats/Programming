using System;

namespace Programming.Model
{
    public class Сontact
    {
        private const int _phoneLength = 11;
        private string _number;
        private string _name;
        private string _surname;

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
                if (value.Length != _phoneLength)
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

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

    }
}
