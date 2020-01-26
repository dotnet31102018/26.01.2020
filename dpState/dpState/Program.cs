using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpState
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new IAmOn());
            ctx.pressedOn();
            ctx.pressedOn();
            ctx.pressedOff();
            ctx.pressedOff();
            ctx.pressedOn();
            ctx.pressedOff();
        }
    }
}
