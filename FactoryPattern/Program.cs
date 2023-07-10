namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires do you want on your new vehicle?");
            int input = int.Parse(Console.ReadLine());
            var instance = VehicleFactory.GetVehicle(input);
            instance.Drive();
        }
    }
}
