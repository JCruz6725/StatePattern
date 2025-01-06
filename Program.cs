using StatePattern.Entity;
using StatePattern.Entity.States;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p = new(new Standing());

            try {
                Standing standing = new Standing();
                Walking walking = new Walking();
                Running running = new Running();
                Jumping jumping = new Jumping();    

                p.ChangeAndExecute(walking);
                p.ChangeAndExecute(running);
                p.ChangeAndExecute(jumping);
                p.ChangeAndExecute(running);
                
                //throw error not with in person FSM
                p.ChangeAndExecute(walking);
                p.ChangeAndExecute(jumping);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
