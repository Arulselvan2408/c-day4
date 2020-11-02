using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface ICAR
    {
       void Brake();
       void Engine();
    }
    class Bens:ICAR
    {
       public void Brake()
        {
            Console.WriteLine("Bens Brake uses Eddy tech");
        }
       public void Engine()
        {
            Console.Write("Bens Engine is Costly");
        }
        public string Functionality()
        {
            return "Bens Cars has Various Functionality";
        }

    }
    class Toyato:ICAR
    {
        public void Brake()
        {
            Console.WriteLine("ToyotoBrakes");
        }
        public void Engine()
        {
            Console.WriteLine("ToyotoEngine");
        }
        public string Functionality()
        {
            return "Toyoto cars are Spacious";
        }
    }

    class Arul
    {
        static void Main()
        {
            Bens B = new Bens();
            B.Functionality();
            B.Brake();
            B.Engine();
            Toyato T = new Toyato();
            T.Brake();
            T.Engine();
            T.Functionality();
            
            



        }
    }
}
