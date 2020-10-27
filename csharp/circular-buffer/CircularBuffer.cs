using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private Queue<T> queBuffer;
    private int intCapacity;

    public CircularBuffer(int capacity)
    {
        intCapacity = capacity;
        queBuffer = new Queue<T>(capacity);
    }

    public T Read()
    {
        if (queBuffer.Peek() == null)
        {
            throw new InvalidOperationException("The queue is empty, Cannot Read.");
        }

        return queBuffer.Dequeue();
    }

    public void Write(T value)
    {
        if (queBuffer.Count >= intCapacity)
        {
            throw new InvalidOperationException("The queue is full, Cannot Write.");
        }
        queBuffer.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (queBuffer.Count >= intCapacity)
        {
            queBuffer.Dequeue();
        }
        queBuffer.Enqueue(value);
    }

    public void Clear()
    {
        queBuffer.Clear();
    }
}
//submit C:\Users\eric\Exercism\csharp\circular-buffer\CircularBuffer.cs
