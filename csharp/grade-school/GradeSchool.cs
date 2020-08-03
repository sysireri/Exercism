using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private Dictionary<string,int> dicStudents = new Dictionary<string,int>();
    public void Add(string student, int grade)
    {
        if(! dicStudents.ContainsKey(student))
        {
            dicStudents.Add(student, grade);
        }
    }

    public IEnumerable<string> Roster()
    {
        return from CurrentStudient in dicStudents 
               orderby CurrentStudient.Value ascending, CurrentStudient.Key ascending
               select CurrentStudient.Key;

    }

    public IEnumerable<string> Grade(int grade)
    {
        return from CurrentStudient in dicStudents
               where CurrentStudient.Value == grade
               orderby CurrentStudient.Key ascending
              select CurrentStudient.Key;
    }
}
//submit C:\Users\eric\Exercism\csharp\grade-school\GradeSchool.cs