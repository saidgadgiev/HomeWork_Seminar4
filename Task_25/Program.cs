/*
Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A 
в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int CorectNumbers(string messege)
{
    bool isCorrect = true;
    int result = 0;
    while (isCorrect)
    {
        Console.Write(messege);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = false;
        }
        else
        {
            Console.WriteLine("Enter correct numbers");
        }
    }
    return result;
}

int numA = CorectNumbers("Enter a number A -> ");
int numB = CorectNumbers("Enter a number B -> ");
double result = Math.Pow(numA, numB);

Console.WriteLine(result);