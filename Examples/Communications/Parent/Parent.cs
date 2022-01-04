using System;
using Akka.Actor;

namespace Communications
{
    internal class Parent : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case Messages.Start:
                    IActorRef actor1 = Context.ActorOf(Props.Create<Child1>(),"child1");
                    Console.WriteLine("Parent send message to Child1");
                    actor1.Tell(new Messages.FindDrive());
                    break;

                case Messages.RemovableDrive: // come from child1
                    IActorRef actor2 = Context.ActorOf(Props.Create<Child2>(), "child2");
                    Console.WriteLine("Parent send message to Child2");
                    actor2.Tell(new Messages.FindFiles());
                    break;

                case Messages.PackageDescriptionFound: // come from child2
                    IActorRef actor3 = Context.ActorOf(Props.Create<Child3>(), "child3");
                    Console.WriteLine("Parent send message to Child3");
                    actor3.Tell(new Messages.Download());
                    break;
            }
        }
    }
}
