using System;
using System.Collections.Generic;
using System.Text;

namespace StackInterface
{
    interface IStack
    {
        void Push(char c);
        char Pop();
        char Peek();
        int Size();
        bool IsEmpty();
    }
}
