using System;

namespace dpState
{
    public class IAmBroken : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("broken ... please call technician");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("broken ... please call technician");
            return this;
        }
    }
}