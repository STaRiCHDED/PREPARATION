using System.Collections;

namespace PREPARATION;

public class Node<T>
{

    public T Value; // Хранимые данные
        
    public Node<T> Next; // Следующий элемент связного списка
    public Node<T> Previous; // Предыдущий элемент связного списка.
        
        
    public Node(T value) // Создание нового экземпляра связного списка
    {
        Value = value; // Присваивание значаения
    }
        
    public void Print() // Приведение объекта к строке
    {
        Console.WriteLine($"Node value :{Value}"); // Вывод информации
    }
}
public class LinkedList<T>:IEnumerable
{
    public Node<T> Head; // Первый (головной) элемент списка
    public Node<T> Tail; // Крайний (хвостовой) элемент списка 

    public LinkedList() //Инициализация конструктора
    {
        Head = null; //Иницализация ссылок на начало и конец списка
        Tail = null;
    }

    public void AddLast(T element) // Добавить данные в  связный список
    {
        if (Tail == null) // Проверка, что хвост не null
        {
            Head = Tail = new Node<T>(element); // Добавление первого элемента
        }
        else
        {
            Tail.Next = new Node<T>(element); // Создание элемента
            Tail.Next.Previous = Tail; // Привязка элемента, что previous = tail, next = null, tail равен последнему элементу
            Tail = Tail.Next;    
        }
    }
        
    public void AddFirst(T element) // Добавляет ноду в самое начало
    {
        if (Head == null) // Проверка, что хвост не null
        {
            Head = Tail = new Node<T>(element); // Добавление первого элемента
        }
        else
        {
            var first = new Node<T>(element); // Создание элемента
            first.Next = Head;  // Привязка элемента, что previous = элементу, next = head, head равен первому элементу
            Head.Previous = first;
            Head = first; 
        }
    }
        
    public void Remove(T element) // Удалить данные из связного списка
    {
        Node<T> tempBefore = null; // Node перед удаляемым элементом
        var temp = Head; // Указатель на начало
        while (temp != null) // Пока temp не null
        {
            if (Equals(temp.Value,element)) // Если значения совпали, то удаляем
            {
                if (tempBefore == null) // Если наш элемент был head
                {
                    var temp2 = Head; // Удаление ссылок на head и присвоение следующему node указателя head
                    Head = temp.Next;
                    temp2.Next = null;
                    Head.Previous = null;
                    break;
                }

                tempBefore.Next = temp.Next; //Иначе удаление ссылок и перенаправление ссылок соседей друг на друга
                temp.Next.Previous = tempBefore;
                temp.Next = temp.Previous = null;
            }

            tempBefore = temp; // Проход дальше
            temp = temp.Next;
        }
    }
        

    public IEnumerator GetEnumerator() // Создание итератора
    {
        var temp = Head; // Начиная с головы
        while (temp != null) // Пока не будет конец
        {
            yield return temp.Value;
            temp = temp.Next;
        }
    }

        
}