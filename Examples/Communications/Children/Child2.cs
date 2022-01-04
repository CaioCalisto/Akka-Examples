using System;
using Akka.Actor;

namespace Communications
{
    internal class Child2 : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case Messages.FindFiles:
                    Console.WriteLine($"Received message FindFiles in Child2, Child2 sent message to Parent");
                    Sender.Tell(new Messages.PackageDescriptionFound());
                    break;
            }
        }
    }
}
