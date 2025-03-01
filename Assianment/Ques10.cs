using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var students1 = File.ReadAllLines("students1.csv").Skip(1)
                            .Select(line => line.Split(','))
                            .ToDictionary(cols => cols[0], cols => new { Name = cols[1], Age = cols[2] });

        var students2 = File.ReadAllLines("students2.csv").Skip(1)
                            .Select(line => line.Split(','))
                            .ToDictionary(cols => cols[0], cols => new { Marks = cols[1], Grade = cols[2] });

        var mergedData = students1.Join(students2, s1 => s1.Key, s2 => s2.Key, 
                                        (s1, s2) => new { ID = s1.Key, Name = s1.Value.Name, Age = s1.Value.Age, Marks = s2.Value.Marks, Grade = s2.Value.Grade })
                                  .Select(x => $"{x.ID},{x.Name},{x.Age},{x.Marks},{x.Grade}");

        File.WriteAllLines("merged.csv", new[] { "ID,Name,Age,Marks,Grade" }.Concat(mergedData));
    }
}
