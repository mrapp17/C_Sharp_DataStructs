using System.Collections.Generic;

namespace Stack
{
    public class Stack<T>
    {
        private List<T> dataList;

        //Constructor creates empty stack
        public Stack()
        {
            dataList = new List<T>();
        }

        //Constructor creates a stack and puts the input parameter onto the stack
        public Stack(T input)
        {
            dataList = new List<T>();
            dataList.Add(input);
        }

        //Push adds an element to the top of the stack
        public void Push(T input)
        {
            dataList.Add(input);
        }

        //Size returns the number of elements currently in the stack
        public int Size()
        {
            return dataList.Count;
        }
        //PeakTop looks at the first element on the stack
        public T Peak()
        {
            return dataList[dataList.Count -1];
        }

        //PopLook removes the top element and returns it
        public T PopLook()
        {
            T temp = dataList[dataList.Count - 1];
            dataList.RemoveAt(dataList.Count - 1);
            return temp;
        }

        //Pop remove the top element but does not return it
        public void Pop()
        {
            dataList.RemoveAt(dataList.Count - 1);
        }
    }
}
