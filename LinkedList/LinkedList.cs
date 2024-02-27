namespace ConsoleApp1;  


// Like an array but it is objectified 
// bad things about array , thery are fixed 
// array you cant insert the middle O(N)
// THE GOOD THINGS ABOUT LINKEDLIST 
//      DYNAMIC 
//      YOU CAN INSERT VALUES ANY THINGS 
//      Like a group holding hands 
// consists of Nodes + Reference pointer (what holds them together) 
public class LinkedList
{
    public Node First { get; set; }

    public void InsertAtTheBeginning(int data)
    {
        Node newNode = new(); 
        newNode.Data = data;

        newNode.Next = First;
    }


}
