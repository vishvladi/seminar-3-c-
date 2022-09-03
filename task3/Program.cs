//Написать программу замены элементов массива на противоположные
Console.Write ( "Enter size of array: ");
int size = int.Parse(Console.ReadLine()??"0");
int []array = new int  [size];
int i = 0;
while(i<array.Length)
{
    array[i]= new Random().Next(1, 10);
    i++;
}
i=0;
while(i<array.Length)
{
  Console.Write($"{array[i]}"+" ");
  i++;  
}
 


