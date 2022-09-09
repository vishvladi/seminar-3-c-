// Задать массив из 8 элементов, заполненных нулями и единицами и вывести их на экран
int [] array = new int [8];
int i = 0;
 while (i< array.Length)
 {
  array [i] = new Random().Next(0, 2);
  Console.Write(array [i] + " ");
  i++;
 }
