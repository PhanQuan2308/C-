using System;

namespace Slot10
{
    public class Thermostat
    {
        public delegate void TemperatureChangeHandler(float newTemperature);
        private TemperatureChangeHandler _OnTemperatureChange;
        
        public TemperatureChangeHandler OnTemperatureChange
        {
            get { return _OnTemperatureChange; }
            set { _OnTemperatureChange = value; }
        }

         public float CurrentTemperature
        {
            get { return _CurrentTemperature; }
            set
            {
                if (value != _CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    if (OnTemperatureChange != null)
                    {
                        OnTemperatureChange(value);
                    }
                }
            }
        }
        private float _CurrentTemperature;
    }

    class Cooler
    {
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }
        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }
        private float _Temperature;

        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature > Temperature)
            {
                Console.WriteLine("Cooler: On");
            }
            else
            {
                Console.WriteLine("Cooler: Off");
            }
        }
    }

    class Heater
    {
        public Heater(float temperature)
        {
            Temperature = temperature;
        }
        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }
        private float _Temperature;

        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature < Temperature)
            {
                Console.WriteLine("Heater: On");
            }
            else
            {
                Console.WriteLine("Heater: Off");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChange += heater.OnTemperatureChanged;
            
            Heater heaterCuong = new Heater(100);
            thermostat.OnTemperatureChange += heaterCuong.OnTemperatureChanged;

            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;

            Console.Write("Enter temperature: ");
            string temperature = Console.ReadLine();
            thermostat.CurrentTemperature = float.Parse(temperature);
            Console.ReadLine();
        }
    }
}
