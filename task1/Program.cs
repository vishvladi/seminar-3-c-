// Задать массив из 8 элементов, заполненных нулями и единицами и вывести их на экран
void FillArray(int [] eightnumbers)
{
    int i = 0;
    while(i < eightnumbers.Length)
    {
        eightnumbers[i] = new Random().Next(0, 2);
        i++;
    }
}
void PrintArray(int [] eightnumbers)
{
    int i = 0;
    while (i<eightnumbers.Length)
    {
      Console.Write(eightnumbers[i] );
      i++;  
    }
}
  int [] array = new int[8];
  FillArray(array);
  PrintArray(array);