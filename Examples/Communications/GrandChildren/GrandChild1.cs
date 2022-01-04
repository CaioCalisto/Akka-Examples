using System;
using Akka.Actor;

namespace Communications
{
    internal class GrandChild1 : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case Messages.Notify:
                    Console.WriteLine($"Received message Notify in GrandChild1, GrandChild1 sent message to child3");
                    Sender.Tell(new Messages.XptoFromGrandChild1());
                    break;
            }
        }
    }
}
