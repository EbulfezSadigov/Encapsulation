using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Models
{
    class Singer
    {
        private string _Name;
        private string _Surname;
        private int _Age;
        public string name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length > 0 && value.Length <= 100)
                {
                    _Name = value;
                }
            }
        }
        public string surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                if (value.Length > 0 && value.Length <= 100)
                {
                    _Surname = value;
                }
            }
        }
        public int age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value > 0 && value <= 170)
                {
                    _Age = value;
                }
            }
        }
    }
}
