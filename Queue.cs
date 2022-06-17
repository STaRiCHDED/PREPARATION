using System.Collections;

namespace PREPARATION;

public class Queue<T> : IEnumerable
{
    private const int QueueSize = 4; // Размер очереди по-умолчанию
    public int Count { get; private set; } // Количество элементов
    public int Capacity => _array.Length; // Вместимость очереди
    private T[] _array; // Элементы стека
    private int _tail; // Указатель на конец очереди
    private int _head; // Указатель на начало очереди

    public Queue() // Инициализация конструктора
    {
        _array = new T[QueueSize]; // Создание массива
        Count = 0; // Инициализация счётчиков
        _head = 0;
        _tail = 0;
    }

    public void Enqueue(T element) // Добавление в очередь
    {
        if (Count == _array.Length) // Если очередь заполнена
        {
            int temp = _array.Length;
            Array.Resize(ref _array, _array.Length * 2); // Увеличение размера
            if (_head != 0)
            {
                for (int i = 0; i < temp - _head; i++) // Копирование элементов с head в конец для удобства
                {
                    _array[^(temp - _head - i)] = _array[_head + i];
                }

                _head = _array.Length - (temp - _head); // Изменение положения головы
            }
        }

        _array[_tail] = element; // Добавление элемента
        _tail++; // Увеличение счётчикка
        _tail %= _array.Length; // Остаток от деления
        Count++; // Увеличение счётчика кол-ва элементов
    }


    public T Dequeue() // удаление из очереди
    {
        if (Count == 0) // Если очередь пуста
        {
            Console.WriteLine("The queue is empty");
            return default;
        }

        var temp = _array[_head]; // Запоминание элемента
        _head++; // Увеличение счётчика головы
        _head %= _array.Length; // Остаток от деления
        Count--; // Уменьшение счётчика кол-ва элементов
        return temp;
    }

    // возвращает первый элемент
    public T Peek() // Вывод самого первого элемента в очереди
    {
        return _array[_head];
    }

    public IEnumerator GetEnumerator() // Инициализация итератора
    {
        int k = 0;
        while (k < Count) // Начиная с head до tail
        {
            yield return _array[(_head + k) % _array.Length]; // Вывод элементов 
            k++;
        }
    }
}