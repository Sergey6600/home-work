Console.WriteLine("Введите число, большее 1:");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n <= 1) Console.WriteLine("Число меньше 1");
    else {
        int evenNumber = 2;
        while (evenNumber <= n-2) {
            Console.Write(evenNumber + ", ");
            evenNumber += 2;
        }
        Console.WriteLine(evenNumber);
    }

    Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();