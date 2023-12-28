namespace FactoryPattern
{
    public class Program
    {
        static void Main()
        {
            
            IVehicle vehicle1 = VehicleFactory.GetVehicle(4); 
            IVehicle vehicle2 = VehicleFactory.GetVehicle(6); 

            vehicle1.Driver(); 
            vehicle2.Driver(); 
        }
    }
}
