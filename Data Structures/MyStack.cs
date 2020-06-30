namespace DSA
{
    //TODO: Implement IEnumerable for foreach.
    public class MyStack<T>
    {

	private readonly T[] _stack;
	private int _top = -1;
	private readonly int _cap;

	public MyStack(int size)
	{
	    _stack = new T[size];
	    _cap = size;
	}


	// Doesn't Modify State. //
	private bool IsEmpty() =>
	    _top == -1;

	private bool IsFull() =>
	    _top == _cap - 1;

	public T Peek() =>
	    _stack[0];

	public void Push(T element)
	{
	    if (!IsFull())
	    {
		_top++;
		_stack[_top] = element;
	    }
	}

	public object Pop()
	{
	    if (!IsEmpty())
	    {
		var element = _stack[_top];
		_top--;
		return element;
	    }

	    return null;
	}
    }
}
