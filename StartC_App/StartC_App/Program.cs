Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0) Console.WriteLine("Четное число");
else Console.WriteLine("Нечетное число");
Console.ReadKey();



Console.WriteLine("Добро пожаловать в Blackjack!");
Console.WriteLine("Для «картинок» следует принять обозначения латинскими буквами: \nВалет = J \nДама = Q \nКороль = К \nТуз = Т");
Console.WriteLine("Сколько карт у вас на руках?");
int karta = int.Parse(Console.ReadLine());
int sums = 0;
for (int i = 0; i < karta; i++)
{
    Console.WriteLine("Введите номинал следующей карты: ");
    string kartas = Console.ReadLine();
    switch (kartas)
    {
        case "J":
        case "Q":
        case "K":
        case "T":
            sums = sums + 10;
            break;
        default:
            int num = int.Parse(kartas);
            sums = sums + num;
            break;
    }
}
Console.WriteLine($"Сумма всех карт >>> {sums}");
Console.ReadKey();




Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int j = 1;
bool b = false;
while (j < n - 1)
{
    j++;
    if (n % j == 0)
    {
        Console.WriteLine("Не простое");
        b = true;
        break;
    }
}   
if (b == false) Console.WriteLine("Простое");
if (n == 1) Console.WriteLine("Либо это 1");
Console.ReadKey();






