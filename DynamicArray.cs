using System.Collections;

namespace PREPARATION;

public class DynamicArray<T> : IEnumerable
{
    private const int ArraySize = 4; // Размер массива по-умолчанию
    private T[] _array; // Наш массив
    public int Count { get; private set; } // Кол-во элементов массива
    public int Capacity => _array.Length; // Размер созданного массива
    
    public T this[int index] // Индексатор
    {
        get => _array[index]; // Вывод элемента
        set => _array[index] = value; // Присвоение значения
    }

    public DynamicArray() //Конструктор создания массива
    {
        Count = 0;
        _array = new T[ArraySize]; // Инициализация массива
    }

    public void Add(T element) //Добавление элемента
    {
        if (Count == _array.Length) // Проверка на переполнение
        {
            Array.Resize(ref _array, _array.Length * 2); // Увеличение размера
        }

        _array[Count] = element; // Добавление элемента
        Count++; // Увеличение счётчика
    }

    public void Delete(int index) // Удаление элемента
    {
        if (Count - 1 < index) // Проверка наличия элемента
        {
            Console.WriteLine("Index out of range"); // Вывод сообщения
        }
        else
        {
            _array[index] = default; // Удаление элемента
        }
    }

    public T Get(int index) // Получение элемента
    {
        if (Count - 1 < index) // Проверка наличия элемента
        {
            Console.WriteLine("Index out of range"); // Вывод сообщения
            return default; // Вывод null, если элемента нет
        }

        return _array[index]; // Вывод элемента
    }

    public void Set(int index, T value) // Изменение элемента
    {
        if (Count - 1 < index) // Проверка наличия элемента
        {
            Console.WriteLine("Index out of range"); // Вывод сообщения
        }
        else
        {
            _array[index] = value; // Изменение элемента
        }
    }

    public IEnumerator GetEnumerator() // Создание итератора
    {
        for (int i = 0; i < Count; i++) // Проход по всем элементам
        {
            yield return _array[i]; // Возвращение итератора
        }
    }
}