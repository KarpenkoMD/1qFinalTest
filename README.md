# Описание программы
>*задание описано в файле [Task](Task.md)*

>*блок-схема находится в файле [Block-scheme](diagram.drawio.png)*

## Константы
В программе используются следующие константы:

| ИМЯ | ЗНАЧЕНИЕ | ОПИСАНИЕ |
-----|--------| ------
 `MaxRandomStringLength` | 8 | определяет максимальную длину строки при случайном создании массива строк
`StringLength` | 3 | отбираем строки, количество символов в которой меньше либо равно этому значению 
`MaxArraySize` | 15 | определяет максимальное количество элементов при создании массива строк
`MinChar` | 97 | для английского алфавита, начальный символ `a` для генерации случайных строк 
 ||1072| начальный символ `a` для русского алфавита
`MaxChar` | 122 | для английского алфавита, конечный символ `z` для генерации случайных строк 
||1103 | конечный символ `я` для русского алфавита

## Функции
* `string[] FillArray()` - отвечает за создание массива строк. Пользователю предлагается выбор - создание случайного количества строк и случайных строк, либо ввести вручную. Цикл _do while_ позволяет дождаться от пользователя ввода только букв `"y"` или `"n"`, что определит дальнейшее заполнение массива строк по средствам вызова функций `ManualCreateStrArray` или `CreateRandomStrArray`.   
Функция не принимает никаких аргументов и возвращает заполненный массив строк.
```
Перед вызовом функции, которая генерирует массив случайных строк, размер этого массива определяется случайным образом в пределах от 3 до числа, определенного константой `MaxArraySize`.   
```
____
* `string CreateRandomString(int, int)` - Функция принимает в качестве аргументов минимальное и максимальное значение для символов, из которых будет сгенерирована строка, и возвращает случайно сгенерированную строку.
```
 Алфавит определяется в начале программы константами `MinChar` и `MaxChar`.
 ```
____
* `string[] CreateRandomStrArray( int )` - функция в цикле формирует массив случайных срок. На вход принимает число, которое определяет размер формируемого массива. Возвращает функция сформированный массив строк.
____
* `string[] ManualCreateStrArray()` - функция отвечает за ручной ввод массива строк. В начале пользователь вводит размер массива. Проверяется и допускается  ввести размер в пределах от 1 до числа, определенного константой `MaxArraySize`.
Далее в цикле пользователь вводит строки.   
Функция возвращает заполненный массив строк.
____
* `string[] PickElementsFromArray( string[], int )` - функция выбирает из переданного массива строк те строки, длина которых меньше либо равна второму передаваемому значению. В данной программе ограничение длины строк определяется константой `StringLength`.   
Возвращает функция новый массив из строк заданной длины. 
____
* `string AssembleStringFromArray( string[] )` - 
Функция принимает сформированный массив строк определенной длины и возвращает строку, которая сформирована из этого массива. 

