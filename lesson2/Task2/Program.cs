﻿//Задача №1 Создать массив и заполнить его целыми числами от 1 до N (N - произвольное натуральное число). Вывести элементы массива на экран.


int N = 10;
int[] arr = new int[N];
int i = 0;

while (i < N)
{
    arr[i] = i + 1;
    //Console.WriteLine(arr[i]);
    //Console.Write(arr[' ']);
    Console.Write($"{arr[i]} ");
    i = i + 1;
}