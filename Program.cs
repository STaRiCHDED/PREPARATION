// Подключение консоли вывода
using System;

namespace PREPARATION
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            /*----------------------------Динамический массив------------------------------------*/
            Console.WriteLine("DArray");
            DynamicArray<int> dynamicArray = new DynamicArray<int>(); // Создание динамического массива
            dynamicArray.Add(1); // Добавление элемента
            dynamicArray.Add(2); // Добавление элемента
            foreach (var o in dynamicArray) // Прохожение по массиву с помощью итератора
            {
                Console.WriteLine(o); //Вывод элемента
            }

            Console.WriteLine($"Count ={dynamicArray.Count} Capacity ={dynamicArray.Capacity}"); // Вывод х-к массива
            dynamicArray.Add(3); // Добавление элемента
            dynamicArray.Add(4); // Добавление элемента
            dynamicArray.Add(5); // Добавление элемента
            foreach (var o in dynamicArray) // Вывод элементов через итератор
            {
                Console.WriteLine(o); // Вывод элемента
            }

            Console.WriteLine($"Count ={dynamicArray.Count} Capacity ={dynamicArray.Capacity}"); // Печать х-к массива
            dynamicArray.Delete(5); // Удаление элемента
            dynamicArray.Delete(2); // Удаление элемента
            dynamicArray.Set(3, 123); // Изменение элемента
            foreach (var o in dynamicArray) // Печать элементов через итератор
            {
                Console.WriteLine(o); // Печать элемента
            }

            Console.WriteLine($"Count ={dynamicArray.Count} Capacity ={dynamicArray.Capacity}"); // Печать х-к массива
            /*-----------------------------Heap--------------------------------------------*/
            Console.WriteLine("Heap");
            Heap heap1 = new Heap(); // Создание кучи
            heap1.Add(10); // Добавление элемента
            heap1.Print(); // Вывод кучи
            Console.WriteLine("Heap1");
            heap1.Add(20); // Добавление элемента
            heap1.Print(); // Вывод кучи
            Console.WriteLine("Heap2");
            heap1.Add(3); // Добавление элемента
            heap1.Print(); // Вывод кучи
            Console.WriteLine("Heap3");
            /*-----------------------------Stack--------------------------------------------*/
            Console.WriteLine("Stack");
            Stack<int> stack1 = new Stack<int>(); // Инициализация стэка
            stack1.Push(2); //Добавление элемента
            Console.WriteLine($"Count ={stack1.Count} Capacity ={stack1.Capacity}"); // Печать х-к массива
            stack1.Push(3); // Добавление элемента
            stack1.Push(4); // Добавление элемента
            foreach (var o in stack1) // Вывод элементов через итератор
            {
                Console.WriteLine(o); // Вывод элемента
            }

            stack1.Push(5); // Добавление элемента
            stack1.Push(6); // Добавление элемента
            Console.WriteLine($"Count ={stack1.Count} Capacity ={stack1.Capacity}"); // Печать х-к массива
            stack1.Push(7); // Добавление элемента
            foreach (var o in stack1) // Вывод элементов через итератор
            {
                Console.WriteLine(o); // Вывод элемента
            }

            Console.WriteLine($"Pop:{stack1.Pop()}"); // Изъятие элемента
            foreach (var o in stack1) // Вывод элементов через итератор
            {
                Console.WriteLine(o); // Печать элемента
            }
            /*-----------------------------Queue--------------------------------------------*/
            Console.WriteLine("Queue");
            Queue<int> queue1 = new Queue<int>(); // Инициализация очереди
            queue1.Enqueue(1); // Добавление элемента
            Console.WriteLine($"Count ={queue1.Count} Capacity ={queue1.Capacity}"); // Печать х-к массива
            queue1.Enqueue(10); // Добавление элемента
            queue1.Enqueue(11); // Добавление элемента
            foreach (var o in queue1) // Вывод элементов через итератор
            {
                Console.WriteLine(o); // Вывод элемента
            }

            queue1.Enqueue(12); // Добавление элемента
            Console.WriteLine($"Dequeue:{queue1.Dequeue()}"); // Изъятие элемента
            queue1.Enqueue(99); // Добавление элемента
            foreach (var o in queue1) // Печать элементов через итератор
            {
                Console.WriteLine(o); // Печать элемента
            }
            queue1.Enqueue(13); // Добавление элемента
            Console.WriteLine($"Count ={queue1.Count} Capacity ={queue1.Capacity}"); // Печать х-к массива
            queue1.Enqueue(7); // Добавление элемента
            foreach (var o in queue1) // Печать элементов через итератор
            {
                Console.WriteLine(o); // Печать элемента
            }
            /*-----------------------------LinkedList--------------------------------------------*/
            Console.WriteLine("LinkedList");
            LinkedList<int> linkedList1 = new LinkedList<int>(); // Инициализация двусвязного списка
            linkedList1.AddFirst(1); // Добавление элемента в начало
            linkedList1.AddFirst(2); // Добавление элемента в начало
            linkedList1.AddFirst(3); // Добавление элемента в начало
            linkedList1.AddFirst(4); // Добавление элемента в начало
            linkedList1.AddFirst(5); // Добавление элемента в начало
            linkedList1.AddFirst(6); // Добавление элемента в начало
            Console.WriteLine("Link1");
            foreach (var o in linkedList1) // Вывод элемнтов списка через итератор
            {
                Console.WriteLine(o); // Вывод элемента
            }
            linkedList1.Remove(4); // Удаление элемента
            Console.WriteLine("Link2");
            foreach (var o in linkedList1) // Вывод элементов списка через итератор
            {
                Console.WriteLine(o); // Вывод элемента
            }
            linkedList1.AddLast(96); // Добавление элемента в начало
            Console.WriteLine("Link3");
            foreach (var o in linkedList1) // Вывод элементов списка через итератор
            {
                Console.WriteLine(o); // Вывод элемента
            }
            /*-----------------------------Circular_Array--------------------------------------------*/
            Console.WriteLine("CircularArray");
            CircularArray<int> circularArray1 = new CircularArray<int>();
            circularArray1.Add(1); // Добавление элемента
            circularArray1.Add(2); // Добавление элемента
            circularArray1.Add(3); // Добавление элемента
            circularArray1.Add(4); // Добавление элемента
            circularArray1.Add(5); // Добавление элемента
            circularArray1.Add(6); // Добавление элемента
            circularArray1.Add(7); // Добавление элемента
            circularArray1.Add(8); // Добавление элемента
            circularArray1.Add(9); // Добавление элемента
            circularArray1.Add(10); // Добавление элемента
            circularArray1.Add(11); // Добавление элемента
            foreach (var o in circularArray1) // Вывод элементов через итератор
            {
                Console.WriteLine(o); // Вывод элемента
            }
            circularArray1.Delete(10); // Удаление элемента
            foreach (var o in circularArray1) // Вывод элементов через итератор
            {
                Console.WriteLine(o); // Вывод элемента
            }
        }
    }
}