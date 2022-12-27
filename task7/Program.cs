System.Console.WriteLine(" введите пятизначное число...");
string number = Console.ReadLine();
Palindrom(number);

void Palindrom(string count)
{
if ((count[0] == count[4] && (count[1] == count[3])))
{
 System.Console.WriteLine( " число является палиндромом" );
}

else{
 System.Console.WriteLine( " число НЕ является палиндромом ");
    }

}