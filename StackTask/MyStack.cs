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
    
    // remove the top of the stack and return it
    public T? Pop()
    {
        var length = _items.Count;

        if (length == 0)
        {
            return default;
        }
        
        var top = _items.ElementAt(length-1);
        _items.RemoveAt(length-1);
        //Console.WriteLine(top);
        return top;

    // add push method that take a parameter and push it to the list
    public void Push(T item) 
    {
        _items.Add(item);
    }
}