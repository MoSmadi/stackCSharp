namespace StackTask;

public class MyStack <T>
{
    private readonly T[] _items;
    private int _index = -1;
    public MyStack()// =>   _items = new T[10];
    {
        _items = new T[10];
    }
    
    public MyStack(int size)// =>   _items = new T[size];
    {
        _items = new T[size];
    }
}