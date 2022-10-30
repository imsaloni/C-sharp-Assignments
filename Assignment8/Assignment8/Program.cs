using System;
using System.Reflection;
namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dynamically load assembly from file User.dll
            Assembly assembly = Assembly.LoadFile(@"D:\sql\hello world\hello world\bin\Debug\net6.0\hello world.dll");

            // Get type of class 'User' from the loaded assembly  
            Type type = assembly.GetType("Reflection.User");

            // Create instance of 'User' class
            object instance = Activator.CreateInstance(type);

            // Call method: public string GetName()
            MethodInfo method = type.GetMethod("GetName");

            // Invoke method: 
            string name = Convert.ToString(method.Invoke(instance, null));
            //Call public field
            FieldInfo field = type.GetField("userId");
            int userId = (int)field.GetValue(instance);

            Console.WriteLine(userId);
            Console.WriteLine(name);
            Console.ReadLine();

        }
    }
}