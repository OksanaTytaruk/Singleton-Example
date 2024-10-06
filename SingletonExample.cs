using System;

public class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();

    // Приватний конструктор
    private Singleton() 
    {
        // Ініціалізація
    }

    // Метод для отримання екземпляра
    public static Singleton Instance
    {
        get
        {
            lock (_lock) // Захист від багатопоточного доступу
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Привіт з патерну Одинак!");
    }
}

// Клієнт
class Program
{
    static void Main(string[] args)
    {
        Singleton instance1 = Singleton.Instance;
        Singleton instance2 = Singleton.Instance;

        // Перевірка, що обидва екземпляри однакові
        Console.WriteLine(Object.ReferenceEquals(instance1, instance2)); // True

        instance1.DisplayMessage();
    }
}
