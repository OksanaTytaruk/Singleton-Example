# Singleton Example

Цей репозиторій містить приклад патерну проектування "Одинак".

## Патерн Одинак (Singleton)

Патерн "Одинак" забезпечує, щоб у класу був лише один екземпляр, і надає глобальну точку доступу до нього.

### Приклад коду:

```csharp
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
}
