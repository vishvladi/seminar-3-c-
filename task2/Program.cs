// Задать массив из 12 элементов, заполненных числами из  [0,9].
//Найти сумму положительных элементов массива
 int [] array = new int [12];
int i = 0;
int sum = 0;
 while (i< array.Length)
 {
  array [i] = new Random().Next(0, 10);
  Console.Write(array[i]+" ");
  if (array [i]>0)
       sum = sum + array[i];
  
   
  i++;
 }
 Console.WriteLine(" Cумма положительных чисел: " + sum);
