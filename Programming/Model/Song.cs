using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private int _id;
        private int _durationMinute;
        public Song()
        { }

        public Song(int id, string name, string autor, int duretionminute)
        {
            Id = id;
            Name = name;
            Autor = autor;
            DuretionMinute = duretionminute;
        }
        public int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                _id = value;
            }
        }
        public string Name { get; set; }
        public string Autor { get; set; }
        public int DuretionMinute 
        {
            get
            {
                return _durationMinute;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                _durationMinute = value;
            }
        }
    }
}
