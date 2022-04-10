using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Expert : CarHandler
    {
        public override void HandleRequest(Car car)
        {

            Random random = new Random();
            int result = random.Next(1, 11);
            if (result < 6)
            {
                Console.WriteLine($"Test failed!! (Test result: {result}) Problem detected by: Expert");
                car.isFixed = true;
                car.fixedHandlerName = GetType().Name;
            }
            else
            {
                Console.WriteLine($"Test passed!! (Test result: {result}) Diagnosed by: Expert");
                if (NextHandler != null)
                    NextHandler.HandleRequest(car);
                else
                    Console.WriteLine("Sorry, our team could not detect your problem.");
            }
        }
    }
}
