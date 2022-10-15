using System.Text;

class Program
{
    static void Main()
    {
        int a;
        string[] month = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        Console.Write("Введите число A: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a < 0 || a > 7)
        {
            Console.WriteLine("You're wrong");
        }
        else
        {
            Console.Write(month[a]);
        }
        Console.ReadKey();
    }
}
