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
            arrkWhperdaydevices = new double[] {};
            arrDevicesName = new string[] {};
            //declaratie
            Console.Write("Hello, customer!!!\n What is your name : ");
            nameclient = Console.ReadLine();
            do
            {
                Console.Write("How many devices, do you have : ");
            }while(!int.TryParse(Console.ReadLine(), out clientdevices));
            //loop
            for(int Clientdevices = 0; Clientdevices != clientdevices;Clientdevices++)
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
            CalculationTotalPerDay(arrkWhperdaydevices);
            Calculationavg(arrkWhperdaydevices);
            // voorkomen derket afsluiten
            Console.ReadKey();
        }
    }
}
