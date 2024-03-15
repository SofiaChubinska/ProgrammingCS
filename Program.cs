using System;
/*Створіть клас Matrix, який представляє цілочисельну матрицю. В цьому класі створіть:
Зубчастий двовимірний масив цілих чисел.
Індексатор для доступу до елементів матриці за допомогою індексів row та column.
Напишіть метод FillMatrixRandom(int rows, int columns, int min, int max), який заповнює матрицю випадковими числами в діапазоні від min до max.
Створіть об'єкт класу Matrix, заповніть його випадковими значеннями та виведіть матрицю на консоль. 
Потім, за допомогою індексатора, знайдіть та виведіть значення певного елемента матриці
*/

class Matrix
{
    private int[][] matrix;
    public int this[int row, int column]
    {
        get { return matrix[row][column]; }
        set { matrix[row][column] = value; }
    }

    public Matrix(int rows, int columns)
    {
        matrix = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            matrix[i] = new int[columns];
        }
    }
    public void FillMatrixRandom(int rows, int columns, int min, int max)
    {
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j<columns; j++)
            {
                matrix[i][j] = random.Next(min, max + 1);
            }
        }
    }

    public void PrintMatrix()
    {
        foreach (var row in matrix)
        {
            foreach (var element in row)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

}

class Program
{
 
    static void Main(string[] args)
    {
        Matrix matrix = new Matrix(3,4);
        matrix.FillMatrixRandom(1, 3, 1, 7);

            Console.WriteLine("Матриця:");
            matrix.PrintMatrix();

            int value = matrix[1, 2];
            Console.WriteLine($"Значення елемента у другому рядку та третьому стовпці: {value}");
    }
  
}



