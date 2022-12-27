Console.WriteLine("Введите число, большее 1:");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 1) Console.WriteLine("Число меньше 1");
else
 {
int cube = 1;
for (cube = 1; cube < n; cube++) {
Console.Write(Math.Pow(cube, 3) + ", ");
}
Console.WriteLine(Math.Pow(cube, 3));
}
Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
