namespace ConsoleApp1;          

public class Node
{
    public int Data { get; set; }

    // self refernce to a new node 
    public Node? Next { get; set; }
}
