System.Console.WriteLine(" введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxNumber = number1;
if( number2 > maxNumber){
 maxNumber = number2;
}
if( number3 > maxNumber){
 maxNumber = number3;
}
System.Console.WriteLine(" MAX:" + maxNumber);