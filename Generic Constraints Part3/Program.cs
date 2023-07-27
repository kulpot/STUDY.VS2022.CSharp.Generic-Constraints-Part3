using System;
using System.Collections;

//ref link:https://www.youtube.com/watch?v=sTuwxO2R3yQ&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=13
// C# doesnt support multiple inheritance but C++ do

//class ClassOne { }
struct ClassOne { } // required knowledge between the behavior of class and struct

class MainClass
{
    //static T ProduceA<T>() where T : class, new()
    //static T ProduceA<T>() where T : struct
    //static T ProduceA<T>()
    static T ProduceA<T, U, V>() where T: U where U : V
    {
        //T returnValue = new T();
        //T returnValue = null;
        T returnValue = default(T); // means go 0 for everything ex. value type = 0(int) and reference type = null
        return returnValue;
    }
    static void Main()
    {
        //int i = null;
        //ProduceA<ClassOne>();
        //ProduceA<ClassOne, int , char>();
    }
}