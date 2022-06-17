using System.Collections.Generic;
namespace PREPARATION;

public class Heap
{
    public static int GetParent(int index) => (index - 1) / 2;  // Получение индекса родителя
    public static int GetLeft(int index) => 2*index + 1; // Получение индекса левого ребёнка
    public static int GetRight(int index) => 2*index + 2; // Получение индекса правого ребёнка

    private List<int> indexesVertexes; // Массив значений

    public Heap() // Инициализация конструктора
    {
        indexesVertexes = new List<int>();
    }
    public Heap(List<int> array) // Иницализации конструктора с входящим массивом
    {
        indexesVertexes = array;
        Heapify(); // Алгоритм просеивания
    }
    private void SiftUp(int index, List<int> array) // Просеивание вверх
    {
        var parent = GetParent(index); // Берётся родитель
        while (array[index] < array[parent]) // До тех пор пока Потомок меньше
        {
            (array[index], array[parent]) = (array[parent], array[index]); // Смена местами
            index = parent; 
            parent = GetParent(index);
            if (parent < 0) // Если индекс родителя 0 и меньше - выход
                break;
        }
    }
    private void SiftDown(int index, List<int> array,int count) //Просеивание вниз
    {
        while (2*index+1<count) // Пока есть дети
        {
            var change = index; // Выбор наименьшего ребёнка
            var left = GetLeft(index); // Левый ребёнок
            var right = GetRight(index); // Правый ребёнок
            if (left < count && array[left] < array[change]) // Сравнение
            {
                change = left; // Замена
            }
            if (right < count && array[right] < array[change]) // Сравнение
            {
                change = right; //Замена
            }

            if (change != index) // Если замена есть
            {
                (array[index], array[change]) = (array[change], array[index]); // Меняем местами
                index = change; // Индекс становится равным заменяемому и операция повторяется
            }
            else
            {
                break; // Выход
            }
        }
    }

    public void Add(int value) // Добавление элемента в конец кучи
    {
        indexesVertexes.Add(value);
        SiftUp(indexesVertexes.Count - 1,indexesVertexes); // Проссеивание вверх
    }

    public void Heapify() // Преобразование массива в кучу
    {
        for (int i = indexesVertexes.Count / 2 - 1; i >= 0; i--)// Просеивание вниз всех родителей
        {
            SiftDown(i,indexesVertexes,indexesVertexes.Count);
        }
        for (int i=indexesVertexes.Count-1; i>=0; i--) //Проссеивание всех элементов 
        {
            (indexesVertexes[0], indexesVertexes[i]) = (indexesVertexes[i], indexesVertexes[0]);
            SiftDown(0,indexesVertexes,i);
        }
    }

    public void Print() // Вывод элементов кучи
    {
        int k = 0;
        int border = 1;
        for (var index = 0; index < indexesVertexes.Count; index++)
        {
            var t = indexesVertexes[index];
            Console.Write($"{t} ");
            k++;
            if (k == border)
            {
                Console.WriteLine();
                border *= 2;
                k = 0;
            }
        }
        if (k != 0)
            Console.WriteLine();
    }

    public int Peek() // Просмотр корня кучи
    {
        return indexesVertexes[0];
    }

    public int Exctract() // Изъятие корня кучи
    {
        int temp = indexesVertexes[0];
        indexesVertexes[0] = indexesVertexes[indexesVertexes.Count - 1]; // Преобразование кучи за счёт последнего элемента
        SiftDown(0,indexesVertexes,indexesVertexes.Count); // Проссеивание последнего элемента вниз
        return temp;
    }
}