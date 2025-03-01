using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
class JsonField : Attribute
{
    public string Name { get; }
    public JsonField(string name) { Name = name; }
}

class User
{
    [JsonField(Name = "user_name")]
    public string Name;
    
    [JsonField(Name = "user_age")]
    public int Age;
}

class Program
{
    static string SerializeToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields();
        StringBuilder json = new StringBuilder("{");
        
        foreach (var field in fields)
        {
            var attribute = (JsonField)Attribute.GetCustomAttribute(field, typeof(JsonField));
            if (attribute != null)
            {
                string key = attribute.Name;
                object value = field.GetValue(obj);
                json.Append($"\"{key}\": \"{value}\", ");
            }
        }
        
        if (json.Length > 1) json.Length -= 2;
        json.Append("}");
        return json.ToString();
    }
    
    static void Main()
    {
        User user = new User { Name = "Alice", Age = 25 };
        string json = SerializeToJson(user);
        Console.WriteLine(json);
    }
}