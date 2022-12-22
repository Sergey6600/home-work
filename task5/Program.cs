 Console.Write("Введите число: ");
 int num = Convert.ToInt32(Console.ReadLine());
 int res = num;
 int i = 0;

 if (num > 99 || num < -99) {
     while (num != 0)
     {
         num /= 10;
         i++;
     }
     while (i > 3)
     {
         res /= 10;
         i--;
     }
     res %= 10;
     Console.WriteLine(res);
 }
 