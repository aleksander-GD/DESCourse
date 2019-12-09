
namespace Server
{

    class Stack : IStack
    {
        char[] chars;
        int top;

        public Stack()
        {
            chars = new char[1000];
            top = 0;
        }

        public bool IsEmpty()
        {
            return top == 0 ? true : false;
        }

        public char Peek()
        {
            return chars[top - 1];
        }

        public char Pop()
        {
            top--;
            return chars[top];
        }

        public void Push(char c)
        {
            chars[top] = c;
            top++;
        }

        public int Size()
        {
            return top;
        }
    }
}