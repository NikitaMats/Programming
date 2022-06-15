using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные телефонной книги.
    /// </summary>
    public class Сontact
    {
        private const int _phoneLength = 11;

        /// <summary>
        /// Номер человека.
        /// </summary>
        private string _number;

        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Сontact()
        { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя человека. Должно состоять только из букв английского алфавита.</param>
        /// <param name="surname">Фамилия человека. Должна состоять только из букв английского алфавита.</param>
        /// <param name="number">Номер человека. Должен состоять только из цифр и иметь длину 11.</param>
        public Сontact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Возвращает и задает номер контакта. Должен состоять только из цифр.
        /// Должен иметь длину одиннадцать символов.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт имя человека. Должно состоять только из букв английского алфавита.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт фамилию человека. Должно состоять только из букв английского алфавита.
        /// </summary>
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
