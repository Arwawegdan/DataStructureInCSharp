namespace ConsoleApp1;  

public class GenericStack<T> 
{
    public int MaxSize { get; set; }
    public T[] StackValues { get; set; }
    public int Top { get; set; } = -1;

    public GenericStack(int size)
    {
        this.MaxSize = size;
        this.StackValues = new T[MaxSize];
    }

    public T Pop()
    {
        T value = StackValues[Top];
        Top--;
        return value;

    }

    public void Push(T value)
    {
        Top++;
        StackValues[Top] = value;
    }

    public T Peek() => StackValues[Top];
}
