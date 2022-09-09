// Найти сумму всех чисел стоящих на нечетной позиции
int [] array = new int [10];
 int i = 0;
 int sum = 0;
  
 while (i<array.Length)
 {
 array [i] = new Random().Next(1, 100);
     if (i !=0)
     sum = sum + array[i];

i++;
 }
 Console.Write(" Сумма чисел на нечетной позиции: " + sum);
