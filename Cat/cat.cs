﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Cat
    {
        private string _name;
        private int _health;
        private string _currentColor;
        
        public Cat(int age, int health, string sickColor, string healthyColor)
        {
            Color.HealthyColor = healthyColor;
            Color.SickColor = sickColor;
            Age = age;
            _health = health; 
        }
        public int Age { get; private set; }

        public CatColor Color { get; set; } = new CatColor();

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                    _name = value;
            }
        }

        public int Health
        {
            get { return _health; }
            private set { _health = value; }
        }
        
        public string CurrentColor
        {
            get
            {
                if (_health == 5)
                {
                    _currentColor = Color.HealthyColor;
                    return _currentColor;
                }
                else
                {
                    _currentColor = Color.SickColor;
                    return _currentColor;
                }
                
            }
        }


        public void Feed()
        {
            _health++;   
        }

        public void Punish()
        {
            if (_health > 0)
                _health--;
        }

        public class CatColor
        {
            public string HealthyColor { get; set; }

            public string SickColor { get; set; }
        }
    }
   

}
