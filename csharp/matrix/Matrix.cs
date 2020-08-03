
using System;
using System.Linq;

public class Matrix
{
    private int[][] intMatrix;
    public Matrix(string input)
    {
        string[] strRows;
        string[] strCells;
        strRows = input.Split("\n");
        intMatrix = new int[strRows.Length][];
        for (int intCurrentRow = 0; intCurrentRow < strRows.Length; intCurrentRow++)
        {
            strCells = strRows[intCurrentRow].Split(" ");
            intMatrix[intCurrentRow] = new int[strCells.Length];
            for (int intCurrentCol = 0; intCurrentCol < strCells.Length; intCurrentCol++)
            {
                intMatrix[intCurrentRow][intCurrentCol] = int.Parse(strCells[intCurrentCol]);
            }
        }
    }

    public int Rows => intMatrix[0].Length;

    public int Cols => intMatrix.Length;

    public int[] Row(int row) => intMatrix[row -1];

    public int[] Column(int col)
    {
        int[] inColumn;

        inColumn = new int[Cols];
        for (int intCurrentColumn = 0; intCurrentColumn < Cols; intCurrentColumn++)
        {
            inColumn[intCurrentColumn] = intMatrix[intCurrentColumn][col - 1];
        }

        return inColumn;
    }
}
//submit C:\Users\eric\Exercism\csharp\matrix\Matrix.cs
