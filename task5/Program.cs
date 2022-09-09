// Задать массив, заполнить случайными положительными трехзначными числами, 
//показать количество четных чисел
int [] array = new int [10];
 int i = 0;
 int count = 0;
  
 while (i<array.Length)
 {
 array [i] = new Random().Next(100, 1000);
 Console.Write(array[i]+" ");
     if (array[i]%2==0)
     count++;

i++;
 }
 Console.Write("Четных чисел: " + count);
 
