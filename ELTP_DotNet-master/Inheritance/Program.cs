
using System.Collections;

var stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());


public class stack
{

    List<object> list = new List<object>();

    public void push(object obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException();
        }
        else
        {
            list.Add(obj);
        }
    }

    public object Pop()
    {
        var last = list.Last();
        list.Remove(last);
        return list;
    }

    public void Clear()
    {
        list.Clear();
    }
}