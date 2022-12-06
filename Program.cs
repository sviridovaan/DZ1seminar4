//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int LenNumber(int number)
{
    int i = 0;
    for (i = 0; number > 0; i ++)
    {
        number = number /= 10;
    }
    return i;
}

int SumNumbers(int n)
{
    int sum = 0;
    for (int index = 1; n > 0; index ++)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}


int a = DataEntry("Введите число от 0 до n: ");
int result = SumNumbers(a);
Console.WriteLine(result);