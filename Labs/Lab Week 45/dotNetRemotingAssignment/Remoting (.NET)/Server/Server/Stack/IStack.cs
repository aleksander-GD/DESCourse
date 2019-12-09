
namespace Server
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