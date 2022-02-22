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
    
    // add push method that take a parameter and push it to the list
    public void Push(T item) 
    {
        _items.Add(item);
    }
}