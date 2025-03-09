using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactHomework3.Question5.InterfaceExamples.FirstExample
{
    public interface IVehicle
    {
        // Properties
        string Brand { get; }
        string Model { get; }
        DateTime ProducedTime { get; }

        // Methods
        void Start();
        void Stop();

        // C# 8'den sonra eklenen özellik (Default Metot)
        void ShowInfo()
        {
            Console.WriteLine($"Araç Markası: {Brand}, Modeli: {Model} km/h");
        }
    }
}
