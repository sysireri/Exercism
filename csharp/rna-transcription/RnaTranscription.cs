using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        System.Text.StringBuilder objStringBuilder = new System.Text.StringBuilder();

        foreach (char chrCurrent in nucleotide.ToUpper())
        {
            switch(chrCurrent)
            {
                case 'G':
                    objStringBuilder.Append('C');
                    break;

                case 'C':
                    objStringBuilder.Append('G');
                    break;

                case 'T':
                    objStringBuilder.Append('A');
                    break;

                case 'A':
                    objStringBuilder.Append('U');
                    break;
            }
        }

        return objStringBuilder.ToString();
    }
}

//submit C:\Users\eric\Exercism\csharp\rna-transcription\RnaTranscription.cs