﻿
//void Method1()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method1 - " + i);
//    }
//}


//void Method2()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method2 - " + i);
//    }
//}

//void Method3()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method3 - " + i);
//    }
//}

//void Method4()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method4 - " + i);
//    }
//}

//Thread thread1 = new Thread(Method1);

//Thread thread2 = new Thread(Method2);

//thread1.Start();

//Method3();

//thread2.Start();

//Method4();



//Method1();
//Method2();

using System.Threading.Channels;
using Thread_Files;
using Thread_Files.Controllers;

ExampleFile file = new ExampleFile();

//file.WriteToExistFile("C:\\Workspace Code Academy\\Thread-Files\\file2.txt", "Salam Xacker bey");

//file.WriteToExistFile("C:\\Workspace Code Academy\\Thread-Files\\file3.txt", "Salam Xacker bey");

//file.ReadFromFile("C:\\Workspace Code Academy\\Thread-Files\\file2.txt");

//file.WriteToNewFile("C:\\Workspace Code Academy\\Thread-Files\\file7.txt", "Necesiz Nesir bey ?");

FileController fileController = new FileController();

//await fileController.ReadDataAsync();

//await fileController.CreateFileWithContentAsync();

//await fileController.DeleteFileAsync();


