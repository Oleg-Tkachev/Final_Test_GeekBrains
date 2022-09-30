
/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


string[] arrayString = { "Hello", "world", "GB", "HTML", "123", "VSC", "Print", "WEB", "Kotik", "WWW", "Geek" };
string[] newArray = new string[arrayString.Length];


string[] СreatingArrayNoMoreThreeChar(string[] oldArray, string[] newArray)  // метод создания массива с элементами не более 3х символов
{
    int count = 0;
    for (int i = 0; i < oldArray.Length; i++)                             // проходим циклом по массиву

        if (oldArray[i].Length <= 3)
        {
            newArray[count] = oldArray[i];                                // создаем новый массив по индексу с длиной <= 3 символа
            count++;
        }
    return newArray;                                                       // возврат, т.к. метод не VOID 
}



void PrintArray(string[] array)                                            // метод печати в консоль
{
    Console.Write(" Элементы массива в которых менее трех символов: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

СreatingArrayNoMoreThreeChar(arrayString, newArray);                       // вызов метода + передача двух аргументов
PrintArray(newArray);

