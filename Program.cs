using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack=new Stack<int>();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            stack.push(6);
            stack.print();
            stack.peak();
            stack.pop();
            stack.print();
            stack.peak();



        }
    }
}
