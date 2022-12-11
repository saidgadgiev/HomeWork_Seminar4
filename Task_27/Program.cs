/*
Задача 27: Напишите программу, которая 
принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int CorectNumbers(string messege)
{
    bool isCorrect = false;
    int result = 0;
    while (! isCorrect)
    {
        Console.Write(messege);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Enter correct numbers.");
        }
    }
    return result;
}

int SummNumbers(int num)
{
    int result = 0;
    while (num != 0)
    {
        result = result + (num%10);
        num = num / 10;
    }
    return result;
}
int num = CorectNumbers("Enter a numbers -> ");
int summ = SummNumbers(num);
Console.WriteLine($"{num} -> {summ}");