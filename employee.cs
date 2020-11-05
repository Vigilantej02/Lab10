using System;

class Employee{
  //fields
 private string firstName;
  private string lastName;
  private string id;
  private int age;
  private string address;
  private string phoneNumber;
  private string title;
  private double yearlySalary;
  private string employmentStatus;
//properties
public string FirstName {
  get;
  set;
}
public string LastName {
  get;
  set;
}
public int Age {
  get { return age; }
  set {
    if (value >= 18)
    age = value;
    else age = 18;
  }
}
public double YearlySalary {
  get { return yearlySalary; }
  set {
    if (value < 1000)
    yearlySalary = 1000;
    else yearlySalary = value;
  }
}
public string Id {
  get;
  set;
}
public string EmploymentStatus {
  get;
  set;
}
public Employee()
{
string FirstName = "Unknown";
string LastName = "Unknown";
string Id = "Unknown";
int Age = 0;
string EmploymentStatus = "active";
}

public Employee(string firstName, string lastName, string id, int age)
{
string fn1 = FirstName;
string ln1 = LastName;
string id1 = Id;
int age1 = Age;
}
public void Intro()
{
Console.WriteLine("First Name: " + FirstName);
Console.WriteLine("Last Name: " + LastName);
Console.WriteLine("ID: " + Id);
Console.WriteLine("Age: " + Convert.ToString(Age));
Console.WriteLine("Employment Status: " + EmploymentStatus);
}
public void IncreaseSalary(double percent)
{
  double percent = Convert.ToDouble(Console.ReadLine());
  if (percent > 0)
  {
    yearlySalary * percent = tempNum;
    yearlySalary + tempNum = yearlySalary;
    Console.WriteLine("Yearly Salary updated to: " + yearlySalary);
  }
  else
  {
    Console.WriteLine("Invalid Input. Yearly Salary not updated.");
  }
}
public void RemoveEmployee()
{
  if (employmentStatus = "inactive")
  {
    Console.WriteLine("Employee already inactive.");
  }
  else
  {
    employmentStatus = "inactive";
    Console.WriteLine("Employee removed.");
  }
}
}