using System;

namespace dpState
{
    public class IAmOff : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("Light is already off... now it is broken.... kol hakavod");
            return new IAmBroken();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Turning on the light!");
            return new IAmOn();
        }
    }
}