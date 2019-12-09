using System;
using System.Collections.Generic;
using System.Text;
using StackInterface;

namespace PalindromeProgram
{
    public class StackImplementation : IStack
    {
            
            private char[] chars;
            private int top;
            
            /// <summary>
            /// Stack constructor
            /// Instantiates default char[1000];
            /// </summary>
            public StackImplementation()
            {
                chars = new char[1000];
                top = 0;
            }
            /// <summary>
            /// Checking if stack is empty
            /// </summary>
            /// <returns> Return true if top is zero, false otherwise </returns>
            public bool IsEmpty()
            {
                return top == 0 ? true : false;
            }
            /// <summary>
            /// Peek method to peek the top stack
            /// </summary>
            /// <returns> Return the value of char of the first charachter </returns>
            public char Peek()
            {
                return chars[top - 1];
            }

            /// <summary>
            /// Pop's the stack
            /// </summary>
            /// <returns> Returns value char of the first charachter of the stack to pop </returns>
            public char Pop()
            {
                top--;
                return chars[top + 1];
            }

            /// <summary>
            /// Push char value down to the stack
            /// </summary>
            /// <param name="c">Type char, returns void </param>
            public void Push(char c)
            {
                top++;
                chars[top] = c;
            }

            /// <summary>
            /// Check the size of the stack
            /// </summary>
            /// <returns> Returns int value depending on the size of the stack </returns>
            public int Size()
            {
                return top;
            }
        }

    }

