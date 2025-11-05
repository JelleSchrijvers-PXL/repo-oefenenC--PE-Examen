namespace cs_MergeTest
{
    internal class Program
    {
        static double CalculationTotalPerDay(double[] arrkWhperdaydevices)
        {
            double TotalPerDay = 0;
            double Input;
            for(int i = 0;i < arrkWhperdaydevices.Length;i++)
            {
                Input = arrkWhperdaydevices[i];
                TotalPerDay += Input;
            }
            return TotalPerDay;
        }
        static double Calculationavg(double[] arrkWhperdaydevices)
        {
            double avg = 0;
            double Input;
            for (int i = 0; i < arrkWhperdaydevices.Length; i++)
            {
                Input = arrkWhperdaydevices[i];
                avg += Input;
            }
            avg /= arrkWhperdaydevices.Length;
            return avg;
        }
        static void Main(string[] args)
        {
            // Intalatie
            string nameclient;
            int clientdevices;
            double DevicekWhPerDay;
            double[] arrkWhperdaydevices ;
            string[] arrDevicesName;
            //declaratie
            Console.Write("Hello, customer!!!\n What is your name : ");
            nameclient = Console.ReadLine();
            do
            {
                Console.Write("How many devices, do you have : ");
            }while(!int.TryParse(Console.ReadLine(), out clientdevices));
            // arrays maken
            arrkWhperdaydevices = new double[clientdevices];
            arrDevicesName = new string[clientdevices];
            //loop
            for (int Clientdevices = 0; Clientdevices != clientdevices;Clientdevices++)
            {
                string NameDevice;
                Console.Write($"what is the name of your {Clientdevices+1} device: ");
                NameDevice = Console.ReadLine();
                do
                {
                    Console.Write("How much kWh per day, does your device use: ");
                }while(!Double.TryParse(Console.ReadLine(), out DevicekWhPerDay));
                arrDevicesName[Clientdevices] = NameDevice;
                arrkWhperdaydevices[Clientdevices] = DevicekWhPerDay;
            }
            //Berekeingen en processen
            double TotalkWh = Math.Round(CalculationTotalPerDay(arrkWhperdaydevices),1);
            double avgkWh = Math.Round( Calculationavg(arrkWhperdaydevices),1);
            string AnalayseVerbruik = "Empty";
            if (avgkWh < 5)
                AnalayseVerbruik = "Laag verbruik";
            else if (avgkWh > 15)
                AnalayseVerbruik = "Hoog verbruik";
            else
                AnalayseVerbruik = "Normaal verbruik";
            //resultaat tonen
            Console.WriteLine($"Gebruiker: {nameclient}\nAantal Toestelen: {clientdevices}\nTotaal verbuik: {TotalkWh} kWh\nGemiddelde verbuik per toestel: {avgkWh} kWh\nAnalyse: {AnalayseVerbruik}");
            // voorkomen derket afsluiten
            Console.ReadKey();
        }
    }
}
