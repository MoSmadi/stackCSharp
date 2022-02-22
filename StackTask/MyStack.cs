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

    public void Clear()
    {
        _items.Clear();
    }
}