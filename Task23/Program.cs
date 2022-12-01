//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


void TablePOW3(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        int pow = count * count * count;
        Console.Write(pow + " ");
        count++;
    }
    Console.WriteLine();
}


TablePOW3("Insert number : ");