namespace CabInvoiceGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            double fare = invoiceGenerator.CalculateFare(2.0, 5);

            Console.WriteLine("The total fair is " + fare);

            RideRepository rideRepository = new RideRepository();

            Ride[] rides = { new Ride(2.0, 5), new Ride(5, 7) };

            rideRepository.AddRide("Raj", rides);

            Ride[] val = rideRepository.GetRides("Raj");
            
            foreach (Ride ride in val)
            {
                Console.WriteLine("Distanc: "+ride.distance);
                Console.WriteLine("Time: " + ride.time);
            }
        }
    }
}
