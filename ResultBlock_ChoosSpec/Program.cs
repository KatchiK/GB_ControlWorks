/*Задача: Написать программу, которая из имеющегося массива
 строк формирует массив из строк, 
 длина которых меньше либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.
*/

string[] sourceArray = { "home", "0", "geek", "so", "0306", ":->", "No", "04", "351" };

string[] FilteredArray(string[] arr, int numChar)//фильтруем принятый строковый массив по количеству указанных символов
{
    int lengthArr = arr.Length;
    string[] resultArray = new string[lengthArr];
    int countResultArray = 0;

    for (int i = 0; i < lengthArr; i++)
    {
        
        if (arr[i].Length <= numChar)// сравниваем кол-во символов элемента массива с заданным
        {
            resultArray[countResultArray] = arr[i];
            countResultArray++;
        }

    }
    Array.Resize(ref resultArray, countResultArray);
    return resultArray;
}


Console.WriteLine($"Исходный массив:  [{String.Join("; ", sourceArray)}]");
Console.WriteLine($"Полученный массив:  [{String.Join("; ", FilteredArray(sourceArray, 3))}]");

