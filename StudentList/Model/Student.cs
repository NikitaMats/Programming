namespace StudentList.Model
{
    /// <summary>
    /// Класс отвечающий за хранение данных о студентах.
    /// </summary>
    internal class Student
    {
        /// <summary>
        /// Id студента.
        /// </summary>
        private int _id;
        
        /// <summary>
        /// Имя студента.
        /// </summary>
        private string _name;
        
        /// <summary>
        /// Группа студента.
        /// </summary>
        private string _group;
        
        /// <summary>
        /// Счетчик студентов.
        /// </summary>
        private static int _allStudentCount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Student"/>.
        /// </summary>
        public Student()
        {
            _allStudentCount++;
            _id = _allStudentCount;
        }

        /// <summary>
        /// Возвращает Id Студента.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задаёт факультет студента.
        /// </summary>
        public string Faculty { get; set; }

        /// <summary>
        /// Возвращает и задаёт форму обучения студента.
        /// </summary>
        public string EducationForm { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя студента. Длинна не должна превышать 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Name), 0, 200, value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя студента. Длинна не должна превышать 10 символов.
        /// </summary>
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Group), 0, 10, value);
                _group = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Student"/>.
        /// </summary>
        public Student(string name, string group,string faculty, string educationForm)
        {
            Name = name;
            Group = group;
            Faculty = faculty;
            EducationForm = educationForm;
            _allStudentCount++;
            Id = _allStudentCount;
        }
    }
}
