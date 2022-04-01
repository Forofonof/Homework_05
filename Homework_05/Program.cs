using System;

    internal class Program
{
    static void Main(string[] args)
    {
        int gold;
        int crystalPrice = 15;
        int crystalCount;

        Console.WriteLine("У вас новое задание: нужно обменять золотые монеты на кристалы, сколько возьмете золотых монет?");
        Console.WriteLine("Введите количество золотых монет:");
        gold = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Вы получили: {gold} золотых монет.");
        Console.WriteLine($"Добро пожаловать в forofonof.bank! Курс обмена: 1 кристал = {crystalPrice} золотых монет.");
        Console.WriteLine("Сколько кристалов желаете приобрети?");
        crystalCount = Convert.ToInt32(Console.ReadLine());
        gold -= crystalPrice * crystalCount;
        Console.WriteLine("Сделка успешно завершена!");
        Console.WriteLine($"Вы получили: {crystalCount} кристалов.");
        Console.WriteLine($"У вас осталось: {gold} золотых монет. {crystalCount} кристалов.");
    }
}