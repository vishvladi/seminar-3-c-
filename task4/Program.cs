// Определить присутствует ли в заданном массиве  некоторое число
Console.WriteLine("Введите число: ");
 int [] array = new int [10];
 int i = 0;
 int n = int.Parse(Console.ReadLine()??"0");
 while (i<array.Length)
 {
 array [i] = new Random().Next(1, 100);
 Console.Write(array[i]+" ");
 
     if (array [i]==n)
     {
       Console.WriteLine("Это число есть в массиве");
     }
     
i++; 
}

Console.WriteLine("Этого числа нет в массиве");
 




