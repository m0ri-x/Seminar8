// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintMatrix (int[,,] ThreeDMatrix)
{
  for (int i = 0; i < ThreeDMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < ThreeDMatrix.GetLength(1); j++)
    {
      for (int k = 0; k < ThreeDMatrix.GetLength(2); k++)
      {
        Console.Write( $"[{i},{j},{k}] = {ThreeDMatrix[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void FillMatrix(int[,,] ThreeDMatrix)
{
  int[] temp = new int[ThreeDMatrix.GetLength(0) * ThreeDMatrix.GetLength(1) * ThreeDMatrix.GetLength(2)];
  int  number;

  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  
  int count = 0; 
  
  for (int x = 0; x < ThreeDMatrix.GetLength(0); x++)
  {
    for (int y = 0; y < ThreeDMatrix.GetLength(1); y++)
    {
      for (int z = 0; z < ThreeDMatrix.GetLength(2); z++)
      {
        ThreeDMatrix[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

Console.WriteLine("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] ThreeDMatrix = new int[x, y, z];
FillMatrix(ThreeDMatrix);
PrintMatrix(ThreeDMatrix);
