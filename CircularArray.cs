using System.Collections;

namespace PREPARATION;

public class CircularArray<T> : IEnumerable
{
    private const int ArraySize = 5; // Размер массива по-умолчанию
    private T[] _array; // Наш массив
    public int Count { get; private set; } // Кол-во элементов массива


    public CircularArray() //Конструктор создания массива
    {
        Count = 0; // Инициализация счётчика
        _array = new T[ArraySize]; // Инициализация массива
    }

    public void Add(T element) //Добавление элемента
    {
        _array[Count++ % _array.Length] = element; // Добавление элемента и Увеличение счётчика
    }

    public void Delete(int index) // Удаление элемента
    {
        if (Count - 1 < index) // Проверка наличия элемента
        {
            Console.WriteLine("Index out of range"); // Вывод сообщения
        }
        else
        {
            _array[index % _array.Length] = default; // Удаление элемента
        }
    }

    public T Get(int index) // Получение элемента
    {
        if (Count - 1 < index) // Проверка наличия элемента
        {
            Console.WriteLine("Index out of range"); // Вывод сообщения
            return default; // Вывод null, если элемента нет
        }

        return _array[index % _array.Length]; // Вывод элемента
    }

    public IEnumerator GetEnumerator() // Создание итератора
    {
        for (int i = ArraySize; i >= 1; i--) // Проход по всем элементам
        {
            yield return _array[(Count-ArraySize-i) % _array.Length]; // Возвращение итератора
        }
    }
}