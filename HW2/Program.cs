using System.Text;

class Zad1 //Требуется сложить числа A и B
{
    static void Main()
    {
        int a;
        string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        Console.Write("Введите число A: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write(month[a]);
        Console.ReadKey();
    }
}
