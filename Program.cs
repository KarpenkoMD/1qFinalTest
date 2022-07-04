/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.  */

string [] FillArray()
{
    string [] StringArrayToFill;

    return StringArrayToFill;
}

string AssembleStringFromArray(string [] arrayToCollect)
{
    string resultString = string.Empty;

    return resultString;
}

string [] PickElementsFromArray(string [] StringToSeek, int strLength)
{
    string [] resultArray;
    
    return resultArray;
}

string CreateRandomString()
{
    string newSrting = string.Empty;

    return newSrting;
}

string [] CreateRandomStrArray (int ElementsNumber)
{
    string [] newStringArray;

    return newStringArray;
}


int CountOutputElements = 0;
int CountInputElements = 0;
string [] inputArray = new string [] {"привет","я","это","смотрю","ТВ"};
string [] outputArray;
string outputString = string.Empty;
const int stringLength = 3; // отбираем строки, количество символов в которой меньше либо равно этому значению 

Console.Clear();

// inputArray = FillArray();
outputArray = PickElementsFromArray (inputArray, stringLength);
outputString = AssembleStringFromArray(outputArray);
Console.WriteLine("Результатом выборки из массива строк, является новый массив, '\n' строки в котором меньше либо равны {0}", stringLength);
Console.WriteLine(outputString);
