using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class CarHandler
    {

        protected CarHandler NextHandler;

        public void SetNext(CarHandler next)
        {
            this.NextHandler = next;
        }

        public abstract void HandleRequest(Car car);

    }
}
