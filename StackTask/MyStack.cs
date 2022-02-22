namespace StackTask;

public class MyStack <T>
{
    private readonly List<T> _items;
    
    public MyStack()
    {
        _items = new List<T>();
    }
    public MyStack(List<T> items)
    {
        _items = items;
    }

    // print all the list
    public void Print()
    {
        foreach (var t in _items)
        {
            Console.WriteLine(t);
        }
    }
}