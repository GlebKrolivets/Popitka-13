
//Напишіть програму, яка знаходить мінімальний і максимальний елементи у масиві.//
{
    Console.WriteLine("1 zadacha");
    int[] array = { 11, 2, 3, 4, 7, 6, 7, 8, 29, 10 };

    int max = array[0], min = array[0];
    for (int i = 0; i<array.Length; i++)
    {

        if (array[i]>max)
        {
            max=array[i];
        }
        else if (array[i]<min)
        {
            min=array[i];
        }

    }
    Console.WriteLine("Maximum " +max);
    Console.WriteLine("Minimum " +min);
    Console.WriteLine();
}
//Напишіть програму, яка знаходить всі елементи у двовимірному масиві, які потрапляють у заданий діапазон.//
{
    Console.WriteLine("2 zadacha");
    int[,] Array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    int min = 3;
    int max = 7;

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            int dia = Array[i, j];
            if (dia >= min && dia <= max)
            {
                Console.WriteLine("Diapozon: " + dia);

            }
        }
    }
}