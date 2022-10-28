public class StackExeption
{

    private int maxStackSize, topOfStack;
    private int[] stack;

    public StackExeption(int maxStackSize)
    {
        if (maxStackSize <= 0)
            Console.WriteLine("Stack size should be a positive integer.");
        else
        {
            this.maxStackSize = maxStackSize;
            topOfStack = -1;
            stack = new int[maxStackSize];
        }
    }

    public void push(int val)
    {
        if (topOfStack == maxStackSize - 1)
            Console.WriteLine("Cannot push! Stack is full.");
        else
            stack[++topOfStack] = val;
    }

    public int pop()
    {
        if (topOfStack == -1)
            throw new ArrayIndexOutOfBoundsException("Cannot pop! Stack is empty.");
        else
            return stack[topOfStack--];
    }

    public int size()
    {
        return (topOfStack + 1);
    }
}
