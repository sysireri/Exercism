using System;
using System.Collections.Generic;
using System.Linq;

public static class Minesweeper
{
    public static string[] Annotate(string[] input)
    {
        List<char[]> lstResult = input.Select(r => r.ToCharArray()).ToList();
        for (int intCurrentRow = 0; intCurrentRow < lstResult.Count; intCurrentRow++)
        {
            for (int intCurrentCol = 0; intCurrentCol < lstResult[intCurrentRow].Length; intCurrentCol++)
            {
                if (lstResult[intCurrentRow][intCurrentCol] == '*')
                {
                    lstResult = IncreaseSquare(lstResult, intCurrentRow, intCurrentCol);
                }
            }
        }

        return lstResult.Select(ch => new string(ch)).ToArray();
    }

    private static List<char[]> IncreaseSquare(List<char[]> vlstSquare, int vintRow, int vintCol)
    {
        if (vintRow > 0)
        {
            vlstSquare[vintRow - 1] = IncreaseRow(vlstSquare[vintRow - 1], vintCol);
        }

        vlstSquare[vintRow] = IncreaseRow(vlstSquare[vintRow], vintCol);

        if (vintRow < vlstSquare.Count - 1)
        {
            vlstSquare[vintRow + 1] = IncreaseRow(vlstSquare[vintRow + 1], vintCol);
        }

        return vlstSquare;
    }

    private static char[] IncreaseRow(char[] vchrRow, int vintCol)
    {
        if (vintCol > 0)
        {
            vchrRow[vintCol - 1] = IncreasCellValue(vchrRow[vintCol - 1]);
        }

        vchrRow[vintCol] = IncreasCellValue(vchrRow[vintCol]);

        if (vintCol < vchrRow.Length - 1)
        {
            vchrRow[vintCol + 1] = IncreasCellValue(vchrRow[vintCol + 1]);
        }

        return vchrRow;
    }

    private static char IncreasCellValue(char vchrCellValue)
    {
        char chrRet = '\0';

        switch (vchrCellValue)
        {
            case ' ':
                chrRet = '1';
                break;

            case '*':
                chrRet = '*';
                break;
        
            default:
                chrRet = ++vchrCellValue;
                break;
        }

        return chrRet;
    }
}

//submit C:\Users\eric\Exercism\csharp\minesweeper\Minesweeper.cs