using System;
using Akka.Actor;

namespace Communications
{
    internal class Child3 : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case Messages.Download:
                    IActorRef grandChild1 = Context.ActorOf(Props.Create<GrandChild1>(), "grandchild1");
                    Console.WriteLine("Child3 send message to GrandChild1");
                    grandChild1.Tell(new Messages.Notify());
                    break;

                case Messages.XptoFromGrandChild1:
                    IActorRef grandChild2 = Context.ActorOf(Props.Create<GrandChild2>(), "grandchild2");
                    Console.WriteLine("Child3 send message to GrandChild2");
                    grandChild2.Tell(new Messages.XptoFromChild3());
                    break;
            }
        }
    }
}
