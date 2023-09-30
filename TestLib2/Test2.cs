using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib2
{
    public class Test2
    {
        int x { get; set; }
        async public void DoSomething()
        {
            x = int.Parse(Console.ReadLine());
            if (x < 0) { throw new EInvalidNumber($"{x}"); }
            while(true) 
            { 
                Cycle();
                if (Console.KeyAvailable) 
                    if(Console.ReadLine() == "stop") break;
            }
            Console.WriteLine(x);
        }
        private void Cycle() 
        { 
            x += 3;
            if(x > 1000)
            {
                x = 0;
            }
            else if (x % 11 == 0)
            {
                Console.WriteLine(x);
            }
        }
    }
}
