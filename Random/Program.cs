﻿//Библиотеки:
using System;
using System.ComponentModel;


//Всё просто этот код создаёт случайное число и букву английскую в конце.

    int Randchislo = 2147483647;// Тут укажи диапазон если что 2147483647 это максимум у int_32 можно больше, но тут уже на
                                // твоё усмотрение по мне так этого достаточно 
    int quantity = 26; //Это количество букв замени на 33 если хочешь с русским алфавитом 
    string[] Angl = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

//string[] Angl = { "А","Б","В","Г","Д","Е","Ё","Ж","З","И","Й","К","Л","М","Н","О","П","Р","С","Т","У","Ф","Х","Ц","Ч","Ш","Щ","Ъ","Ы","Ь","Э","Ю","Я" };

//Вот тебе русский алфавит просто замени это с английским и всё только не забудь что в русском алфавите 33 буквы ;)

//Тут и происходит компеляция случайного числа и буквы)
    var rand = new Random();
    int Chislo = Convert.ToInt32(rand.NextInt64(Randchislo)); 
    int i = Convert.ToInt32(rand.NextInt64(quantity));
    string Bukva = Angl[i];


Console.WriteLine(Chislo + Bukva);//Вывод на консоль 
Console.ReadLine();//Чтобы консоль не закрывалась 