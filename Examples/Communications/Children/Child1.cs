using System;
using Akka.Actor;

namespace Communications
{
    internal class Child1 : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case Messages.FindDrive:
                    Console.WriteLine($"Received message FindDrive in Child1, Child1 sent message to Parent");
                    Sender.Tell(new Messages.RemovableDrive());
                    break;
            }
        }
    }
}
