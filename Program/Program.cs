Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

string [] Array1 = new string [m];

void FillArray()
{
  for (int i = 0; i<Array1.Length; i++)
  {
    Console.WriteLine($"Введите {i+1} элемент массива");
    Array1[i] = Console.ReadLine();
  }
}

string [] Array2 = new string [Array1.Length];
int count=0;

void NewArray()
{
    for (int i = 0; i<Array1.Length; i++)
    {
        if (Array1[i].Length<=3)
        {
            Array2[count]=Array1[i];
            count++;
        }
    }
}

void PrintArray2()
{
    Console.Write("Новый массив строк: [");
    for (int i = 0; i<count; i++)
    {
        Console.Write(Array2[i] + ", ");
    }
    Console.Write("]");
}

FillArray();
Console.WriteLine($"Начальный массив: [{string.Join(", ", Array1)}]");
NewArray();
PrintArray2();
