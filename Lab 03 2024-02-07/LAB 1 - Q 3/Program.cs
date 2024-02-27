using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_02_07
{
    class TemperatureTracker
    {
        private double[] temperatures;
        private int currentDay;

        public TemperatureTracker()
        {
            temperatures = new double[7];
            currentDay = 0;
        }

        public void AddTemperature(float temperature)
        {
            if (currentDay < 7)
            {
                temperatures[currentDay] = temperature;
                currentDay++;
            }
            else
            {
                throw new InvalidOperationException("Cannot add more than 7 temperatures");
            }
        }

        public void DisplayTemperatures()
        {
            Console.WriteLine("Weekly temperature report:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {temperatures[i]} °C");
            }
        }
    }

}
