using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResult : Attribute {}

class CachingSystem
{
    private static Dictionary<string, object> cache = new Dictionary<string, object>();

    public static object InvokeCached(MethodInfo method, object obj, params object[] args)
    {
        string key = method.Name + string.Join("_", args);
        if (cache.ContainsKey(key))
            return cache[key];
        object result = method.Invoke(obj, args);
        cache[key] = result;
        return result;
    }
}

class Calculator
{
    [CacheResult]
    public int ExpensiveOperation(int x)
    {
        System.Threading.Thread.Sleep(2000);
        return x * x;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        MethodInfo method = typeof(Calculator).GetMethod("ExpensiveOperation");
        Console.WriteLine(CachingSystem.InvokeCached(method, calc, 5));
        Console.WriteLine(CachingSystem.InvokeCached(method, calc, 5));
    }
}
