using System;
using Akka.Actor;

namespace Communications
{
    internal class GrandChild2 : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case Messages.XptoFromChild3:
                    Console.WriteLine($"Received message XptoFromChild3 in GrandChild2");
                    break;
            }
        }
    }
}
