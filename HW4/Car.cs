using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public partial class Car
    {
        private string _model;
        private CarCondition _condition;
        private string _body;
        private int _releaseYear;
        private double _price;
        private bool _isClearedCustoms; //Растаможен
        public static int CarCount { get; private set; } 

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public bool IsClearedCustoms
        {
            get
            {
                return _isClearedCustoms;
            }
            set
            {
                _isClearedCustoms = value;
            }
        }

        public Car()
        {
            CarCount++;
        }

        public Car(CarCondition carCondition)
        {
            _condition = carCondition;
        }

        public Car(string model, CarCondition carCondition, string body, int releaseYear)
        {
            _model = model;
            _condition = carCondition;
            _body = body;
            _releaseYear = releaseYear;
        }

        static Car()
        {
            CarCount = 0;
        }
    }
}
