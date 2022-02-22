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

    // return the top of stack without delete it
    public T? Peak()
    {
        var length = _items.Count;
        
        if (length == 0)
        {
            return default;
        }
        var top = _items.ElementAt(length-1);
        return top;   
    }
}