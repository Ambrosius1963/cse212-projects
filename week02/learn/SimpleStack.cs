using System;
using System.Collections.Generic;

public class SimpleStack {
    public static void Run() {

        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();
        stack.Pop();
        stack.Push(4);
        stack.Push(5);
        stack.Pop();
        stack.Push(6);
        stack.Push(7);
        stack.Push(8);
        stack.Push(9);
        stack.Pop();
        stack.Pop();
        stack.Push(10);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(11);
        stack.Push(12);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(13);
        stack.Push(14);
        stack.Push(15);
        stack.Push(16);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(17);
        stack.Push(18);
        stack.Pop();
        stack.Push(19);
        stack.Push(20);
        stack.Pop();
        stack.Pop();

        Console.WriteLine("Final contents:");
        Console.WriteLine(String.Join(", ", stack.ToArray()));
    }
}