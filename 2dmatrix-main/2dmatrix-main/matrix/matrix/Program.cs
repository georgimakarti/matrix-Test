int[,] MatrixA = new int[8,10];

int[,] MatrixB = new int[9, 11];

FillMatrix(MatrixA);
Console.WriteLine("Random Matrix");
PrintMatrix(MatrixA);
ChangeMatrixA(MatrixA);
Console.WriteLine("Changed Matrix");
fillMatrixB(MatrixA, MatrixB);
SumRows(MatrixB, 11, 9);
PrintMatrix(MatrixA);
Console.WriteLine();
Console.WriteLine("MatrixB");
PrintMatrix(MatrixB);


void FillMatrix(int[,] matrix)
{
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 29);
        }
    }
}

void ChangeMatrixA(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == 6)
            {
                matrix[i, j] = 0;
            }
        }
    }
}

void fillMatrixB(int[,] matrixa, int[,] matrixb)
{
    for(int k = 0; k < matrixa.GetLength(0); k++)
    {
        for( int j = 0; j < matrixa.GetLength(1); j++)
        {
            matrixb[k, j] = matrixa[k, j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 5}",matrix[i , j] + " ");

        }
        Console.WriteLine();
    }
}

void SumRows(int[,] matrixb, int r, int c)
{
    r -= 1;
    c -= 1;
    for(var i = 0; i < matrixb.GetLength(0) - 1; i++)
    {
        for(var j = 0; j < matrixb.GetLength(1) - 1; j++)
        {
            matrixb[i, r] += matrixb[i, j];
            matrixb[c, j] += matrixb[i, j];
        }
    }
}
