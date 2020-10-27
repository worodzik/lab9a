using System;

class Employee{

  string FirstName;
  string LastName;
  string id;
  int age;
  string adress;
  string PhoneNum;
  string title;
  double YearlySal;
  string EmploymentStatus;

  public Employee(){
    FirstName = "Unknown";
    LastName = "Unknown";
    id = "Unknown";
    age = 0;
    EmploymentStatus = "active";

    Console.WriteLine(" A new Employee object has been created");
  }

  public Employee( string first, string last, string empid, int empage){
    FirstName = first;
    LastName = last;
    id = empid;
    age = empage;
    EmploymentStatus = "active";
    Console.WriteLine(" A new Employee object has been created");
  }
  
  public void Intro(){
    Console.WriteLine("The first name of the Employee is " + FirstName);
    Console.WriteLine("The last name of the Employee is " + LastName);
    Console.WriteLine("The age of the Employee is " + age);
    Console.WriteLine("The id of the Employee is " + id);
    Console.WriteLine("The Employment Status of the Employee is " + EmploymentStatus);

  }


}