// написать программу, которая из имеющегося массива строк формирует массив из строк,
// содержащих меньше либо 3 символа

// Создаем метод, который на вход принимает 2 массива с переменными в виде строки
// далее проходимяс по элементам первого массива
// в случае если элемент содержит 3 и менее символов, записываем их во второй массив

void GetArrayStringLength3 (string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        }
    }
}

// Создаем метод, который выведет в консоль все элементы получившегося массива, кроме пустых

void PrintFinishArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {  
        if (array[i] != null)
        {
        Console.WriteLine($"Элемент массива с тремя и менее символами: {array[i]}");
        }

    }
}

// Пользователь вводит элементы массива в консоль и мы их записываем в массив

Console.WriteLine("Введите первый элемент массива: ");
string str1 = Console.ReadLine();

Console.WriteLine("Введите второй элемент массива: ");
string str2 = Console.ReadLine();

Console.WriteLine("Введите третий элемент массива: ");
string str3 = Console.ReadLine();

Console.WriteLine("Введите четвертый элемент массива: ");
string str4 = Console.ReadLine();

Console.WriteLine("Введите пятый элемент массива: ");
string str5 = Console.ReadLine();

string[] array1 = new string [5] { str1, str2, str3, str4, str5};
string[] array2 = new string [5];

// Вызываем созданные методы и выводим результат

GetArrayStringLength3(array1, array2);

Console.WriteLine(string.Empty);

Console.WriteLine($"Был массив: "+ String.Join(", ", (array1)));

// Если все введеные пользователем строки будут содержать больше 3 символов

if ( str1.Length > 3 && str2.Length > 3 && str3.Length > 3 && str4.Length > 3 && str5.Length > 3)
{
    Console.WriteLine($"Все элементы массива имеют более трех символов");
}

Console.WriteLine(string.Empty);

PrintFinishArray(array2);