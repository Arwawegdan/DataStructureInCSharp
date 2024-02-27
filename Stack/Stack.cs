namespace ConsoleApp1;

public class Stack : GenericStack<string>
{
    public Stack(int size) : base(size) { }

    public bool IsEmpty() => Top == 0;

    public bool IsFull() => Top + 1 == MaxSize;
}