Console.WriteLine("Введите первое число:"); 
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int maxNumber = 0; 
int minNumber = 0;
if (number1 > number2)
{
   maxNumber = number1; 
   minNumber = number2;
   Console.Write("Максимальное число : " + maxNumber, minNumber); 
}
else if (number1 == number2)
{
   Console.WriteLine("Числа равны");
}
else
{ 
   maxNumber = number2;
   minNumber = number1;
   Console.WriteLine("Максимальное число : " + maxNumber, minNumber);
}