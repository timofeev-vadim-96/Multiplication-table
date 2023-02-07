System.Console.WriteLine("Введите число , таблицу умн. которого вы хотите увидеть");
int Numb = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < Numb; i++)
{
    for (int j = 1; j < Numb; j++)
    {
        System.Console.Write(i*j + "\t");
    }
    System.Console.WriteLine();
}

