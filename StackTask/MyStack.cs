namespace StackTask;

public class MyStack <T>
{
    private readonly List<T> _items;
    public MyStack(List<T> items)// =>   _items = new T[10];
    {
        _items = items;
    }
}