// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10, 99]
int [] array = new int [123];
 int i = 0;
 int count = 0;
  
 while (i<array.Length)
 {
 array [i] = new Random().Next(1, 1000);
  
     if (array[i]>=10 && array[i]<=99)
     count++;

i++;
 }
 Console.Write(" Количество элементов массива из отрезка [10,99]: " + count);
