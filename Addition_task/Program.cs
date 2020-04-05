/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс MyClass<T>, содержащий статический фабричный метод -  T FacrotyMethod(), 
который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т). 
*/
using System;

namespace Addition_task
{
    class MyClass <T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = MyClass<int>.FactoryMethod();
            Console.WriteLine(a.GetType().Name);
        }
    }
}
