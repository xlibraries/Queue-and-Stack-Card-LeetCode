public class MyCircularQueue {
    private int frontIndex = 0;
    private int rearIndex = -1;
    private readonly int capacity;
    private int size = 0;
    private int[] values;

    /** Initialize your data structure here. Set the size of the queue to be k. */
    public MyCircularQueue(int k) 
    {
        capacity = k;
        values = new int[k];
    }
    
    /** Insert an element into the circular queue. Return true if the operation is successful. */
    public bool EnQueue(int value) 
    {
        if (size >= capacity) return false;
        size++;
        rearIndex = (rearIndex + 1) % capacity;
        values[rearIndex] = value;
        return true;
    }
    
    /** Delete an element from the circular queue. Return true if the operation is successful. */
    public bool DeQueue() 
    {
        if (size == 0) return false;
        size--;
        frontIndex = (frontIndex + 1) % capacity;
        return true;
    }
    
    /** Get the front item from the queue. */
    public int Front() 
    {
        if (size == 0) return -1;
        return values[frontIndex];
    }
    
    /** Get the last item from the queue. */
    public int Rear() 
    {
        if (size == 0) return -1;
        return values[rearIndex];
        
    }
    
    /** Checks whether the circular queue is empty or not. */
    public bool IsEmpty() 
    {
        return size == 0;
    }
    
    /** Checks whether the circular queue is full or not. */
    public bool IsFull() 
    {
        return size == capacity;
    }
}
