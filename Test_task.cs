/* Задача. Написать прграмму, которая из имеющегосся массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не  рекомендуется пользоваться колекциями,
лучше обойтись исключительно массивами.
 */

string[] array1 = new string[5] {"Leo", "Leo+Neo", "hi", "Digest", "m"};
string[] array2 = new string[array1.Length];

void ArrayThreeSym(string[] array1, string[] array2)    //Функция созхдания массива, из массива строк в массив строк длиной <3 
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
/* void PrintArray(string[] array)  //Функция вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} */
System.Console.WriteLine("Начальный массив строк");
Console.WriteLine("[" + string.Join(", ", array1) + "]");
//PrintArray(array1);
ArrayThreeSym(array1, array2);
System.Console.WriteLine("Конечный массив строк");
Console.WriteLine("[" + string.Join(", ", array2) + "]");
//PrintArray(array2);