using ClassLibrary1;

namespace ClassLibrary1
{
    public class Vehicle
    {
        private string? _brand;

        private string _model;

        private string _licensePlate;

        private int _year;

        private float _kms;

        private int _wheels;

        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set => _licensePlate = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public float Kms
        {
            get => _kms;
            set => _kms = value;
        }

        public int Wheels
        {
            get => _wheels;
            set => _wheels = value;
        }

        public Vehicle (string brand, string model, string licensePlate, int year, float kms, int wheels)
        {
            _brand = brand;
            _model = model;
            _licensePlate = licensePlate;
            _year = year;
            _kms = kms;
            _wheels = wheels;
        }
        public bool IsOlder()
        {
            return _year < 2005;
        }
    }

    public class Truck : Vehicle
    {
        private string _type;

        private float _tones;

        public string Type
        {
            get => _type;
            set => _type = value;
        }
        public float Tones
        {
            get => _tones;
            set => _tones = value;
        }

        public Truck (string brand, string model, string licensePlate, int year, float kms, int wheels, string type, float tones) : base(brand, model, licensePlate, year, kms, wheels)
        {
            _type = type;
            _tones = tones;
        }
        public bool IsHeavy()
        {
            return _tones > 15;
        }
    }

    public class Car : Vehicle
    {
        private string _color;

        private int _doors;

        public string Type
        {
            get => _color;
            set => _color = value;
        }
        public int Doors
        {
            get => _doors;
            set => _doors = value;
        }

        public Car (string brand, string model, string licensePlate, int year, float kms, int wheels, string color, int doors) : base(brand, model, licensePlate, year, kms, wheels)
        {
            _color = color;
            _doors = doors;
        }
        public bool IsBig()
        {
            return Year < 2009;
        }
    }

    public class Motorbike : Vehicle
    {
        private bool _sideCar;

        private float _cc;

        public bool Type
        {
            get => _sideCar;
            set => _sideCar = value;
        }
        public float Cc
        {
            get => _cc;
            set => _cc = value;
        }

        public Motorbike (string brand, string model, string licensePlate, int year, float kms, int wheels, bool sideCar, float cc) : base(brand, model, licensePlate, year, kms, wheels)
        {
            _sideCar = sideCar;
            _cc = cc;
        }

        public bool IsSideCar()
        {
            return _sideCar;
        }
    }
}



