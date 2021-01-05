using System;

namespace TemperConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            do {
                Console.WriteLine(" Welcome to the Temperature Converter! ");
                Console.WriteLine();
                TemperatureConverter temp = new TemperatureConverter();

                
                Console.Write(" What is the temperature ?");

                double tempInput = double.Parse(Console.ReadLine());
                
                
                double fahrenheit = temp.Celsiustofarenheit(tempInput);
                double celsius = temp.FarenheitToCelsius(tempInput);

                Console.WriteLine(" What unit is that?\n (F = Farenheit) \n (C = Celsius)");

                string typeOfTemp = Console.ReadLine();
                
                if ( (typeOfTemp.Contains("F") && tempInput >= 80.7) )
                {
                  
                        Console.WriteLine($"The {tempInput}, degrees Fahrenhit is {celsius} Celsius ");
                        Console.WriteLine("Esta muy caliente! ");
                }
                else if (typeOfTemp == "F" || typeOfTemp == "f" || typeOfTemp == "Farenheit")
                {
                    Console.WriteLine($"The {tempInput}, degrees Fahrenhit is {celsius} Celsius ");
                }
                else if ((typeOfTemp.Contains("C") && tempInput >= 26.7)) 
                {
                 
                    Console.WriteLine($"The { tempInput}, degrees Fahrenhit is {fahrenheit} Fahrenheit ");
                    Console.WriteLine("Esta muy caliente! ");
                }
                else if (typeOfTemp == "C" || typeOfTemp == "c" || typeOfTemp == "Celsius")
                {
                    Console.WriteLine($"The { tempInput}, degrees Fahrenhit is {fahrenheit} Fahrenheit ");
                }
                else
                {
                    Console.WriteLine(" Sorry, You information is NO BUENO ! ");
                }

                Console.WriteLine();
                Console.WriteLine(" Would you like to convert another temperature ? (Y/N)");

                string response = Console.ReadLine();
                if ((response == "Y" || response == "y"))
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Gracias & Adios Amigo! ");
                    break;
                }

            } while (true);
            Console.ReadKey();
        }
    }

    class TemperatureConverter
    {
        public double Celsiustofarenheit(double celsiustemp) 
        {
            double celsius = celsiustemp;
            double fahrenheit = (celsius * 9 / 5) + 32;
            fahrenheit = Math.Round(fahrenheit, 1);
            return fahrenheit;
        }

        public double FarenheitToCelsius(double fahrenheitTemp)
        {
            double fahrenhit = fahrenheitTemp;
            double celsius = (fahrenhit - 32) * 5 / 9;
            celsius = Math.Round(celsius, 1);
            return celsius;
        }

        
    }
}
