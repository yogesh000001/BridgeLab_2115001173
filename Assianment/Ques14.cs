using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
}

class Program
{
    static void Main()
    {
        string jsonFilePath = "students.json";
        string csvFilePath = "students.csv";

        ConvertJsonToCsv(jsonFilePath, csvFilePath);
        ConvertCsvToJson(csvFilePath, "students_output.json");
    }

    static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
    {
        var students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(jsonFilePath));
        using (var writer = new StreamWriter(csvFilePath))
        using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
        {
            csv.WriteRecords(students);
        }
    }

    static void ConvertCsvToJson(string csvFilePath, string jsonFilePath)
    {
        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
        {
            var students = csv.GetRecords<Student>();
            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(students, Formatting.Indented));
        }
    }
}
