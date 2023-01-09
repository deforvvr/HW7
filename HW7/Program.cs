int programm;
Boolean begin = true;

int[] arrayInt = { };

while (begin)
{
    Console.WriteLine("Введите номер задачи >>> ");

    programm = int.Parse(Console.ReadLine());

    switch (programm)
    {
        case 47:
            Task47();
            break;

        case 50:
            Task50();
            break;

        case 52:
            Task52();
            break;

        default:
            begin = false;
            break;
    }
}

void Task47()
{   
    Console.Write("Введите количество строк >>> ");
    int arrRow = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов >>> ");
    int arrCol = int.Parse(Console.ReadLine());

    int max = 100;
    int min = 1;

    double[,] array = new double[arrRow, arrCol];

    for (int i = 0; i < arrRow; i++)
    {
        for (int j = 0; j < arrCol; j++)
        {
            array[i, j] = new Random().NextDouble();
            array[i, j] = array[i, j] * (max - min) + min;
            array[i, j] = Math.Round(array[i, j], 2);

            Console.Write(array[i, j] + "\t");
        }

        Console.WriteLine();
    }
}


void Task50()
{
    Console.Write("Введите количество строк >>> ");
    int arrRow = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов >>> ");
    int arrCol = int.Parse(Console.ReadLine());

    int max = 100;
    int min = 1;

    int[,] array = createArr(arrRow, arrCol, max, min);


    Console.Write("Введите искомое число >>> ");
    int findNum = Convert.ToInt32(Console.ReadLine());
    bool numFound = false;

    for (int i = 0; i < arrRow; i++)
    {
        for (int j = 0; j < arrCol; j++)
        {
            if (array[i, j] == findNum)
            {
                Console.WriteLine($"Число найдено: Строка {i + 1} ; Столбец {j + 1}");
                numFound = true;
            }
        }
    }
    if (numFound != true) Console.WriteLine("Число не найдено");
}


void Task52()
{
    Console.Write("Введите количество строк >>> ");
    int arrRow = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов >>> ");
    int arrCol = int.Parse(Console.ReadLine());
    
    int max = 10;
    int min = 1;

    int[,] array = createArr(arrRow, arrCol, max, min);

    Console.WriteLine("Среднее арифметическое столбцов >>> ");

    double srZnach = 0;

    for (int j = 0; j < arrCol; j++)
    {
        for (int i = 0; i < arrRow; i++)
        {
            srZnach += array[i, j];
        }
        srZnach = Math.Round(srZnach / arrRow, 3);
        Console.Write(srZnach + "\t");
        srZnach = 0;
    }
    Console.WriteLine();
}


int[,] createArr(int lenRow, int lenCol, int max, int min) //
{
    int[,] array = new int[lenRow, lenCol];
    for (int i = 0; i < lenRow; i++)
    {
        for (int j = 0; j < lenCol; j++)
        {
            array[i, j] = new Random().Next(min, max);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}