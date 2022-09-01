// Задать массив из 12 элементов, заполненных числами из  [0,9].Найти сумму положительных элементов массива
void FillArray(int [] twelvenumbers)
{
    int i = 0;
    while(i < twelvenumbers.Length)
    {
        twelvenumbers[i] = new Random().Next(0, 10);
        i++;
    }
}
void PrintArray(int [] twelvenumbers)
{
    int i = 0;
    while (i<twelvenumbers.Length)
    {
      Console.Write(twelvenumbers[i] + " ");
      i++;  
    }
}
  int [] array = new int[12];
  
  FillArray(array);
  PrintArray(array);
  int size = 12
int sum  = 0;
int i = 0;
while (i<12)
{
      array[i]= sum;
       sum = sum + array[i];
       i++;
      }
  Console.WriteLine(sum);
   
 