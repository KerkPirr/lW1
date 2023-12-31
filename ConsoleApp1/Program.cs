﻿// Создать стек, содержащий 7 слов.
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
            int b;
            string s;
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y', 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю', 'У', 'Е', 'Ы', 'А', 'О', 'Э', 'Я', 'И', 'Ю' };
            
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
                Console.WriteLine("8 - Вставить слово, которое начинается с гласной");
                Console.WriteLine("9 - выход.");
                int.TryParse(Console.ReadLine(), out int a);
                switch (a)
                {
                    case 1: //Добавление элемента в стек
                        Console.Clear();
                        Console.WriteLine("Введите слово:");
                        s = Console.ReadLine();
                        if (s.All(char.IsLetter) && s.Length!=0){
                            stroka.Push(s);
                            Console.WriteLine($"Слово {s} добавлено в стек\nНажмите Enter для продолжения.");
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
                            Console.WriteLine($"Слово {stroka.Pop()} извлечено успешно\nНажмите Enter для продолжения.");
                        }
                        else
                        {
                            Console.WriteLine("Стек пуст!\nНажмите Enter для продолжения.");
                        }
                        break;
                        case 3: //Проверка на непустоту/длину стека
                        Console.Clear();
                        if(stroka.Count != 0)
                        {
                            foreach(string tempS in stroka)
                            {
                                Console.WriteLine(tempS + " ");
                            }
                            Console.WriteLine("Нажмите Enter для продолжения.");
                        }
                        else
                        {
                            Console.WriteLine("Стек пуст!\nНажмите Enter для продолжения.");
                        }
                        break;
                        case 4: // Последнее введеное слово
                        Console.Clear();
                        if (stroka.Count != 0)
                        {
                            Console.WriteLine($"Последнее введенное слово: {stroka.Peek()}\nНажмите Enter для продолжения.");
                        }
                        else
                        {
                            Console.WriteLine("Стек пуст!\nНажмите Enter для продолжения.");
                        }
                        break;
                        case 5: //Проверить наличие слова в стеке
                        Console.Clear();
                        Console.WriteLine("Введите слово, которое нужно найти:");
                        s = Console.ReadLine();
                        
                        if (stroka.Contains(s))
                        {
                            Console.Clear();
                            Console.WriteLine($"Слово {s} есть в стеке\nНажмите Enter для продолжения.");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"В стеке нет слова {s}, хотите его добавить?\n1 - да\nЛюбая другая клавиша для отмены");
                            int.TryParse(Console.ReadLine(), out b);
                            switch(b)
                            {
                                default:
                                    Console.Clear();
                                    Console.WriteLine($"Слово {s} не будет добавлено в стек.\nНажмите Enter для продолжения.");
                                break;
                                    case 1:
                                    if (s.All(char.IsLetter))
                                    {
                                        Console.Clear();   
                                        stroka.Push(s);
                                        Console.WriteLine($"Слово {s} добавлено в стек\nНажмите Enter для продолжения.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ошибка ввода!\nДоступно использование только букв!\nНажмите Enter для продолжения.\n");
                                    }
                                    break;
                                
                            }

                        }
                        break;
                    case 6:// очистка стека
                        Console.Clear();
                        Console.WriteLine("Вы действительно хотите очистить стек?\n1 - да\nЛюбая другая клавиша для отмены");
                        int.TryParse(Console.ReadLine(), out b);
                        switch (b)
                        {
                            default:
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
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Введите слова, которые нужно поменять местами");
                        Console.WriteLine("Введите первое слово:");
                        string s1 = Console.ReadLine();
                        Console.WriteLine("Введите второе слово:");
                        string s2 = Console.ReadLine();
                        if(stroka.Contains(s1) && stroka.Contains(s2) && s1!=s2)
                        {
                            SwapElementsInStack(stroka, s1, s2);
                            Console.WriteLine($"Элементы {s1} и {s2} успешно поменялись местами\nНажмите Enter для продолжения");
                        }
                        else
                        {
                            Console.WriteLine("Невозможно поменять элементы местами!\nНажмите Enter для продолжения");
                        }
                        break;
                        case 8:
                        Console.Clear();
                        Console.WriteLine("Введите слово, которое начинается с гласной");
                        s = Console.ReadLine();
                        char firstChar = s[0];
                        if(vowels.Contains(firstChar) && s.All(char.IsLetter) && s.Length != 0)
                        {
                            stroka.Push(s);
                            Console.WriteLine($"Слово {s} добавлено в стек\nНажмите Enter для продолжения.");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода!\nСлово должно начинаться с гласной и содержать только буквы!\nНажмите Enter для продолжения.\n");
                            Console.ReadLine();
                            goto case 8;
                        }
                        break;
                        case 9:
                        Console.Clear();
                        Console.WriteLine("Для выхода нажмите Esc");
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода!\nДля продолжения нажмите Enter");
                        break;



                }
            }
            while(Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        static void SwapElementsInStack(Stack<string> stack, string s1, string s2)
        {
            bool f1 = true;
            bool f2 = true;

            Stack<string> tempStack = new Stack<string>();
            while(f1 || f2)
            {
                if (stack.Peek() == s1 && f1) { 
                    f1 = false;
                    tempStack.Push(s2);
                    if (stack.Count>0)
                    {
                        stack.Pop();
                    }
                }
                else if(stack.Peek() == s2 && f2) { 
                    f2 = false;
                    tempStack.Push(s1);
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    tempStack.Push(stack.Pop());
                }
            }
            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }

        }
    }
}