using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace StudentList.Model
{
    /// <summary>
    /// Класс отвечающий за запись данных в файл.
    /// </summary>
    internal class Serializer
    {
        /// <summary>
        /// Путь к системной папке AppData.
        /// </summary>
        private static string DataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\StudentList_571-1_Matskevich"; //"/StudentList_Test.txt"

        /// <summary>
        /// Метод отвечающий за создание файла в системной папке.
        /// </summary>
        public static void CreateFile()
        {
            File.Create(DataPath);
        }

        /// <summary>
        /// Метод отвечающий за загрузку данных из файла.
        /// </summary>
        /// <returns>Список объектов класса <see cref="Student"/>.</returns>
        public static List<Student> LoadData()
        {

            var jsonObject = File.ReadAllText(DataPath);

            var Students = JsonConvert.DeserializeObject<List<Student>>(jsonObject);

            return Students;
        }

        /// <summary>
        /// Метод отвечающий за чтение данных из файла.
        /// </summary>
        /// <param name="Students"> Список объектов класса <see cref="Student"/> для записи.</param>
        public static void WriteData(List<Student> Students)
        {
            var jsonObject = JsonConvert.SerializeObject(Students);

            File.WriteAllText(DataPath, jsonObject);
        }
    }
}
