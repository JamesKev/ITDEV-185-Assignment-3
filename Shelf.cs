using System.Collections.Generic;
using System;
namespace ITDEV185
{
    
    class Shelf<T> {
        
         private List<T> list;

        public Shelf(){
            list =  new List<T>();
        }

        public void Add(T value){
            list.Add(value);
        }

        public T getValue(int index){
           return list[index];
        }
        public void Remove(T value){
            list.Remove(value);
        }
        public void Remove(int index){
            list.RemoveAt(index);
        }

        public void printList(){
            Console.WriteLine("Here's your current shelf");
            foreach (T item in this.list)
            {
                
                
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("End of Shelf");
        }
        public int getSize(){
            return list.Count;
        }
    }
    
}