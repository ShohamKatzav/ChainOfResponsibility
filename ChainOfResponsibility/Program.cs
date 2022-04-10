namespace ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            GarageWorker worker = new GarageWorker();
            Mechanic mechanic = new Mechanic();
            Electrician electrician = new Electrician();
            Expert expert = new Expert();

            worker.SetNext(mechanic);
            mechanic.SetNext(electrician);
            electrician.SetNext(expert);
            expert.SetNext(null);

            Car myCar = new Car();
            worker.HandleRequest(myCar);

            if (myCar.isFixed)
                Console.WriteLine($"Car fixed by: {myCar.fixedHandlerName}");
            Console.WriteLine($"Car status - fixed: {myCar.isFixed}");
        }
    }
}
