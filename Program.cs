


//---------------------------------------------------------------------------

// // .NET5 uses this structure, to set up a new project,
// using System;
// public class Test
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("testing text");
//     }
// }

// // .NET6 can now directly write lines like below, compiler automatically creates the program class, and Main method, and below would be
// // equivilent of what would be put inside the Main method =>
// Console.Write("testing text");

// simple programs you can directly start writing, but more complicated ones, one should still write out classes and methods and such...

//---------------------------------------------------------------------------
// assigning variables:
// // can add const before variable type
// const int a = 1;
// const double b = 12.3456;
// const char c = 'Z';
// const string d = "hello";
// const bool e = true;
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(d);
// Console.WriteLine(e);

//number variables: (int, double, float, decimal)
//you can use "e+number" to move decimal places
// "_" can be used as digit separator, but isn't necessary
// int f = 123_456;
// double g = 12.34;
// float h = 12.34f;
// decimal i = 1.234m;
// h = 12.34e3f;
// i = 1.234e-3m;
// Console.WriteLine(f);
// Console.WriteLine(g);
// Console.WriteLine(h);
// Console.WriteLine(i);

// public class MyFirstApp
// {
//     static int test = 100;
//     public static void Main()
//     {
//         int age = 26;
//         string name = "Calvin";
//         Console.WriteLine(name +" is " + age + " years old.");
//     }
// }


// int t1 = 4;
// int t2 = 5;
// Console.WriteLine("============" + (t1 == t2));

//pretty similar to JS, but jesus christ -__-
// var num = 3;
// string test;
// if (num > 2) {
//     Console.WriteLine("success");
//     test = Console.ReadLine();
// } else {
//     Console.WriteLine("failed");
// }


// Console.WriteLine("this is the new test: {0}", test)


public class MyFirstApp
{
    public static void Main()
    {
        var num = 3;
        string test;
        if (num > 2)
        {
            Console.WriteLine("success");
            string newTest = Console.ReadLine();
            if (newTest == "")
            {
                test = "you did not enter anything in";
            }
            else
            {
                test = newTest;
            }

            Console.WriteLine("this is new text: {0}", test);
        }
        else
        {
            Console.WriteLine("failed");
        }
        Console.ReadKey();
        Console.WriteLine("TESTING AFTER READKEY");
    }

}
