using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackData
{
    class DisplayStack
    {
        public static void display(Stack<string> mystack)
        {
            string display = mystack.Pop();
            Console.WriteLine(display);

            foreach (string lin in mystack)
            {
                Console.WriteLine(lin);
            }
        }
    }
}
