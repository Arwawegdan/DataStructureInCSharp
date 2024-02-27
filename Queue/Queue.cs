namespace ConsoleApp1;

public class Queue
{
    public Queue(int size)
    {
        MaxSize = size;
        Data = new int[MaxSize];
    }
    public int MaxSize { get; set; }
    public int[] Data { get; set; }

    // index to keep track of the front 
    public int Front { get; set; } = 0;

    // index to keep track of the back 
    public int Back { get; set; } = 0;



    public void Enqueue(int num)
    {
        Back++; 
        Data[Back] = num;
    }

    public int dequeue()
    {
        var data =  Data[Front];
        Front++;
        return data;
    }

}

