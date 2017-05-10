using System.Collections.Generic;

namespace Maturita._11_Qeue_Stack
{
    public class Tester
    {
        public static bool TestMyQeue()
        {
            var qeue = new Queue<int>();
            qeue.Enqueue(5);
            qeue.Enqueue(4);
            qeue.Enqueue(3);
            qeue.Enqueue(2);
            var peak1 = qeue.Peek();
            qeue.Dequeue();
            var peak12 = qeue.Peek();

            var myQeue = new MyQeue<int>(2);
            myQeue.Enqueue(5);
            myQeue.Enqueue(4);
            myQeue.Enqueue(3);
            myQeue.Enqueue(2);
            var mypeak1 = myQeue.Peek();
            myQeue.Dequeue();
            var mypeak12 = myQeue.Peek();

            return peak1 == mypeak1 && peak12 == mypeak12;
        }

        public static bool TestMyStack()
        {
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            var peak2 = stack.Peek();
            stack.Pop();
            var peak22 = stack.Peek();

            var myStack = new MyStack<int>();
            myStack.Push(5);
            myStack.Push(4);
            myStack.Push(3);
            myStack.Push(2);
            var mypeak2 = myStack.Peek();
            myStack.Pop();
            var mypeak22 = myStack.Peek();

            return peak2 == mypeak2 && peak22 == mypeak22;
        }
    }
}