using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T>
    {

        private T[] array;
        public int Capacity { get; private set; }
        public int Count { get; private set; }
        public T this[int i]
        {
            get => array[i];
            set => array[i] = value;
        }
        public CustomList()
        {
            Capacity = 4;
            Count = 0;
            array = new T[Capacity];
        }



       public void Add(T item)
        {
            CapacityCounter();                // made

            T[]tempArray = new T[Capacity];
            for (int i = 0; i <= Count;i++)
            {
                if(i == Count)
                {
                    tempArray[i] = item;
                }
                else
                {
                     tempArray[i] = array[i];
                }              
            }
            array = tempArray;
            Count++;
        }
       
        public void Remove(T item)
        {
            bool arraychecker = ArrayChecker(item);
            if(arraychecker == true)
            {
                T[] tempArray = new T[Capacity];
                int indexShifter = 0;
                for (int i = 0; i < Count; i++)
                {
                        if (item.Equals(array[i]))
                        {
                            indexShifter = i;
                            break;
                        }
                    tempArray[i] = array[i];
                }
                for (int i = indexShifter; i< Count - 1; i++)
                {
                    tempArray[i] = array[i + 1]; 
                }
                array = tempArray;
                Count--;
            }           

        }
      
        public void CapacityCounter()
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
            }
        }
        private bool ArrayChecker(T item)
        {
            bool check = false;

            for (int i = 0; i < Count; i++)
            {
                if(item.Equals(array[i]))
                {
                    check = true;
                }

            }
            return check;
        }

       
    }







}
    
