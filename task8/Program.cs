//Найти произведение пар чисел в одномерном массиве. Парой считается первый и последний,
// второй и предпоследний и т.д
int [] array = {3, 2, 3, 5, 4 ,6, 1, 8 , 9, 8};
  int result = 0;
  for (int i = 0; i < array.Length/2; i++){
     result = array [i] * array[array.Length - 1 - i];
     Console.WriteLine ("Произведение противоположных элементов = " + result);
  }
  
 
   