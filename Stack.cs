using System.Collections;

namespace PREPARATION;

public class Stack<T>:IEnumerable
{
    private const int StackSize = 4; // Размер стэка по-умолчанию
    private T[] _array; // элементы стека
    public int Count { get; private set; } // количество элементов
    public int Capacity => _array.Length; // Вместимость стэка

    public Stack() // Инициализация конструктора
    {
        _array = new T[StackSize]; // Инициализация массива
        Count = 0;
    }
        
    public void Push(T element) // добавление элемента
    {
        if (Count ==_array.Length) // если стек заполнен
        {
            Array.Resize(ref _array, _array.Length * 2); // Увеличение размера
        }
        _array[Count] = element; // Добавление элемента
        Count++; // Увеличение счётчика
    }
        
    public T Pop() // извлечение элемента
    {
        if (Count ==0) // Если стэк пуст
        {
            Console.WriteLine("The stack is empty");
            return default; // Возврат по умолчанию
        }
        var temp = _array[Count-1]; // Возврат элемента
        _array[Count - 1] = default;
        Count--;
        return temp;
    }
        
    public T Peek() //Просмотр самого верхнего элемента
    {
        if(Count == 0) // Если пуст
        {
            Console.WriteLine("The stack is empty");//Выводим сообщение,что пустой
            return default;
        }
        return _array[Count - 1]; //Возвращаем последний элемент
    }

    public IEnumerator GetEnumerator() // Инициализация итератора
    {
        for (int i = 0; i < Count; i++) // Проход по всем элементам
        {
            yield return _array[i]; // Возвращение итератора
        }
    }
}