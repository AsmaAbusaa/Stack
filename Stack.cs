using System;
using System.Collections.Generic;

public class Stack<T>
{
	private Node top;
	private int size = 0;
	public Stack(){}
	 
	public int Size =>size;
	public bool isEmpty() { return size == 0; }
	public void push(T element) { 
		top = new Node(element, top);
		size++;
	    
	}

	public T pop() {
		if (isEmpty())
			throw new InvalidOperationException();
		else
		{
			var temp = top.Element;
			top = top.Next;
			size--;
			return temp;
		}
	}
	public void print()
	{
		if (isEmpty())
			throw new InvalidOperationException();
		else
		{
			var list = new List<object>();
			Node node = top;
			while (node != null)
			{
				list.Add(node.Element);
				node = node.Next;
			}
			Console.WriteLine($"[{string.Join(",",list)}]");
		}
	}
	public void peak()
    {
        if (!isEmpty())
            Console.WriteLine("The Top of the Stack is:" + top.Element);
        else throw new Exception("Stack is Empty");
    }

	public void clear()
    {
		top = null;
		size = 0;
    }

	private class Node
    {
		public Node(T element, Node next)
		{
			this.Element = element;
			this.Next = next;
		}
		public T Element { get; set; }
		public Node Next { get; set; }
	}
    

}
