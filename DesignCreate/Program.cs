// See https://aka.ms/new-console-template for more information
//创建型设计模式 简单来说就是用来创建对象的
using System.Reflection;
Console.WriteLine("你好,github我来了！！！flyhk90");
Console.WriteLine("vs2022,真香！");


Cat cat = new();
Person person = new Person();
Mouse mouse = new Mouse();

cat.tz += person.getUp;
cat.tz += mouse.runHouse;
cat.startSoud();

#region 观察者模型
/// <summary>
/// 猫叫
/// </summary>
public class Cat
{
    public Action tz;
    public void startSoud()
    {
        Console.WriteLine("猫叫了！");
        //通知事件
        if (tz != null) tz();
    }
}

public class Person
{
    public void getUp()
    {
        Console.WriteLine("主人起床了");
    }
}
public class Mouse
{
    public void runHouse()
    {
        Console.WriteLine("老鼠跑了！");
    }
}
#endregion




#region .NET6入门 语法
//var CurrentMethod = MethodBase.GetCurrentMethod();
//Console.WriteLine($"Method Name:{CurrentMethod?.Name}");
//Console.WriteLine($"Class Name:{CurrentMethod?.DeclaringType?.Name}");
//Console.WriteLine($"Namespace Name:{CurrentMethod?.DeclaringType?.Namespace}");
//Console.WriteLine($"Assembly Name:{CurrentMethod?.DeclaringType?.Assembly.FullName}");
//Console.WriteLine($"Module Name:{CurrentMethod?.DeclaringType?.Module.Name}");

//Console.WriteLine(getName());
//Console.WriteLine(TestA.getName());
//Console.WriteLine(new TestB().getName());

//public static string getName()
//{
//    return "何康";
//}
public class TestA
{
    public static string getName()
    {
        return "Class_Static何康1";
    }
}
public class TestB
{
    public  string getName()
    {
        return "Class_Static何康2";
    }
}
#endregion

