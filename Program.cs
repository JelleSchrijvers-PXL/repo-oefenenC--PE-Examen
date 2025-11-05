namespace cs_MergeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intalatie
            string nameclient;
            int clientdevices;
            double[] arrkWhperdaydevices = {};
            string[] arrDevicesName= {};

            //declaratie
            Console.Write("Hello, customer!!! \n What is your name : ");
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
                }while(!Double.TryParse(Console.ReadLine(), out double DevicekWhPerDay));

            }
            // voorkomen derket afsluiten
            Console.ReadKey();
        }
    }
}
