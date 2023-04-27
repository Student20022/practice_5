abstract class Animal
{
    protected string name;
    protected string type;
    protected string livingPlace;

    public Animal(string name, string type, string livingPlace)
    {
        this.name = name;
        this.type = type;
        this.livingPlace = livingPlace;
    }

    public abstract void PrintInfo();
}

class Mammal : Animal
{
    protected string diet;

    public Mammal(string name, string type, string livingPlace, string diet) : base(name, type, livingPlace)
    {
        this.diet = diet;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Млекопитающее: {name}");
        Console.WriteLine($"Вид: {type}");
        Console.WriteLine($"Место обитания: {livingPlace}");
        Console.WriteLine($"Тип питания: {diet}");
    }
}

class Fish : Animal
{
    protected bool isSaltwater;

    public Fish(string name, string type, string livingPlace, bool isSaltwater) : base(name, type, livingPlace)
    {
        this.isSaltwater = isSaltwater;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Рыба: {name}");
        Console.WriteLine($"Вид: {type}");
        Console.WriteLine($"Место обитания: {livingPlace}");
        Console.WriteLine($"Среда обитания: {(isSaltwater ? "морская" : "пресноводная")}");
    }
}

class Bird : Animal
{
    protected bool isWild;
    protected bool isMigratory;

    public Bird(string name, string type, string livingPlace, bool isWild, bool isMigratory) : base(name, type, livingPlace)
    {
        this.isWild = isWild;
        this.isMigratory = isMigratory;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Птица: {name}");
        Console.WriteLine($"Вид: {type}");
        Console.WriteLine($"Место обитания: {livingPlace}");
        Console.WriteLine($"Домашняя: {!isWild}");
        if (isWild)
        {
            Console.WriteLine($"Перелетная: {isMigratory}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal mammal = new Mammal("Лев", "Хищник", "Саванна", "Всеядное");
        Animal fish = new Fish("Тунец", "Хищник", "Море", true);
        Animal bird = new Bird("Сокол", "Хищник", "Горы", true, false);

        mammal.PrintInfo();
        fish.PrintInfo();
        bird.PrintInfo();
    }
}
