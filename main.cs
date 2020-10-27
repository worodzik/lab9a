using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    Employee johan = new Employee("Johan" , "Smith" , "1234", 45);
    johan.Intro();
  }
}