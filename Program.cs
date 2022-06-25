//Программа на входе принимает 2 числаи выдает, какое число большее, какое число меньшее.

Console.WriteLine("Введите первое число:");
int number1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 =Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
      Console.WriteLine("Максимальное число"+ number1);
      Console.WriteLine("Минимальное число"+ number2);      
}
else
{
      Console.WriteLine("Максимальное число"+ number2);
      Console.WriteLine("Минимальное число"+ number1);       
}