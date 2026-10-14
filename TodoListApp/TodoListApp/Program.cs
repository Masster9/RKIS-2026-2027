namespace TodoListApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Работу выполнили Киснер и Маркелов");

        Console.Write("Введите имя: ");
        string firstName = Console.ReadLine();
        Console.Write("Введите фамилию: ");
        string lastName = Console.ReadLine();
        Console.Write("Введите год рождения: ");
        int birthYear = int.Parse(Console.ReadLine());

        int age = DateTime.Now.Year - birthYear;

        Console.WriteLine($"Добавлен пользователь {firstName} {lastName}, возраст - {age}");
    }
}
