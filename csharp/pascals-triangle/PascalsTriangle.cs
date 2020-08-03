using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        int[][] intPascalTriangle = new int[rows][];
        for (int intCurrentRow = 0; intCurrentRow < rows; ++intCurrentRow)
        {
            intPascalTriangle[intCurrentRow] = new int[intCurrentRow + 1];
            for (int intCurrentColumn = 0; intCurrentColumn <= intCurrentRow; ++intCurrentColumn)
            {
                if (intCurrentColumn == 0 || intCurrentColumn == intCurrentRow)
                {
                    intPascalTriangle[intCurrentRow][intCurrentColumn] = 1; //First and Last position on the row
                }
                else
                {
                    //Add the number on the same index on the previous row with the number on its left side
                    intPascalTriangle[intCurrentRow][intCurrentColumn] = intPascalTriangle[intCurrentRow - 1][intCurrentColumn] + intPascalTriangle[intCurrentRow - 1][intCurrentColumn - 1];
                }
            }
        }
        return intPascalTriangle;
    }

}
//submit C:\Users\eric\Exercism\csharp\pascals-triangle\PascalsTriangle.cs