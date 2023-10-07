// Создать стек, содержащий 7 слов.
// Вывести элементы стека.
// Реализовать основные операции над стеком, и процедуру/функцию, которая вставляет слово, которое начинается с гласной.
// Основные действия:
// Инициализация Стека
// Добавление/удаление элемента
// удаление всего стека
// Вывод элемента
// Проверка наличия элемента
// Проверка непустоты списка
// Взаимообмен двух элементов


using System;
using System.Collections.Generic;
namespace Стек {
    class Program {
        static void Main()
        {

            Stack<string> stroka = new Stack<string>();
            int a, b, c;
            string s;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1 - добавить элемент в стек");
                Console.WriteLine("2 - извлечь элемент из вершины стека");
                Console.WriteLine("3 - проверка на непустоту");
                Console.WriteLine("4 - вывести на экран последний занесённый элемент");
                Console.WriteLine("5 - проверить наличие элемента в стеке");
                Console.WriteLine("6 - удалить стек");
                Console.WriteLine("7 - поменять элементы местами");
                Console.WriteLine("8 - выход.");
                int.TryParse(Console.ReadLine(), out a);
                switch (a)
                {
                    case 1: //Добавление элемента в стек
                        Console.Clear();
                        Console.WriteLine("Введите слово:");
                        s = Console.ReadLine();
                        if (s.All(char.IsLetter) & s.Length!=0){
                            stroka.Push(s);
                            Console.WriteLine($"Слово {s} добавлено в стек");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода!\nДоступно использование только букв!\nНажмите Enter для продолжения.\n");
                            Console.ReadLine();
                            goto case 1;
                        }
                        break;
                        case 2: // Извлечение элемента из вершины стека
                        Console.Clear();
                        if (stroka.Count != 0)
                        {
                            Console.WriteLine($"Слово {stroka.Pop()} извлечено успешно");
                        }
                        else
                        {
                            Console.WriteLine("Стек пуст!");
                        }
                        break;
                        case 3: //Проверка на непустоту/длину стека
                        Console.Clear();
                        if(stroka.Count != 0)
                        {
                            Console.WriteLine($"Длина стека = {stroka.Count}");
                        }
                        else
                        {
                            Console.WriteLine("Стек пуст!");
                        }
                        break;
                        case 4: // Последнее введеное слово
                        Console.Clear();
                        if (stroka.Count != 0)
                        {
                            Console.WriteLine($"Последнее введенное слово: {stroka.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("Стек пуст!");
                        }
                        break;
                        case 5: //Проверить наличие слова в стеке
                        Console.Clear();
                        Console.WriteLine("Введите слово, которое нужно найти:");
                        s = Console.ReadLine();
                        
                        if (stroka.Contains(s))
                        {
                            Console.Clear();
                            Console.WriteLine($"Слово {s} есть в стеке");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"В стеке нет слова {s}, хотите его добавить?\n1 - да\n0 - нет");
                            int.TryParse(Console.ReadLine(), out b);
                            switch(b)
                            {
                                case 0:
                                    Console.Clear();
                                    Console.WriteLine($"Слово {s} не будет добавлено в стек.\nНажмите Enter для продолжения.");
                                break;
                                    case 1:
                                    if (s.All(char.IsLetter))
                                    {
                                        Console.Clear();   
                                        stroka.Push(s);
                                        Console.WriteLine($"Слово {s} добавлено в стек");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ошибка ввода!\nДоступно использование только букв!\nНажмите Enter для продолжения.\n");
                                    }
                                    break;
                            }

                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Вы действительно хотите очистить стек?\n1 - да\n0 - нет");
                        int.TryParse(Console.ReadLine(), out b);
                        switch (b)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine("Отмена очистки стека.\nДля продолжения нажмите Enter");
                                break;
                                case 1:
                                Console.Clear();
                                stroka.Clear();
                                Console.WriteLine("Стек очищен!\nДля продолжения нажмите Enter");
                                break;


                        }
                        break;

                }
            }
            while(Console.ReadKey(true).Key != ConsoleKey.Escape);
        }  
    }
}