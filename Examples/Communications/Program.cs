using System;
using Akka.Actor;

namespace Communications
{
    internal class Program
    {
        /*
         The objective here is to try and confirm what 
            Pros and Cons about communication between Child and Parent
            e.g. Top-Down, Bottom-Up
         */
        static void Main(string[] args)
        {
            using (var actorSystem = ActorSystem.Create("my-custom-actorSystem"))
            {
                IActorRef parent = actorSystem.ActorOf(Props.Create<Parent>(), "parentActor");
                parent.Tell(new Messages.Start());
            }

            Console.ReadKey();
        }
    }
}
