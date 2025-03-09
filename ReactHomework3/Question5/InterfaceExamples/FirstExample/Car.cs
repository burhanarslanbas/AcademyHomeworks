using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactHomework3.Question5.InterfaceExamples.FirstExample
{
    public class Car : IVehicle
    {
        // Private alanlar (Encapsulation)
        private string _brand;
        private string _model;
        private DateTime _producedTime;

        // Public Özellikler (Interface İmplementasyonu)
        public string Brand => _brand;
        public string Model => _model;
        public DateTime ProducedTime => _producedTime;

        // Constructor (Yapıcı Metot)
        public Car(string brand, string model, DateTime producedTime)
        {
            _brand = brand;
            _model = model;
            _producedTime = producedTime;
        }

        // Arabaya özel Start metodu
        public void Start()
        {
            Console.WriteLine($"{Brand} araba çalıştı.");
        }

        // Arabaya özel Stop metodu
        public void Stop()
        {
            Console.WriteLine($"{Brand} araba durdu.");
        }
    }
}