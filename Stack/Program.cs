using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);            
           
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());            

            Console.ReadLine();
        }
    }
}
