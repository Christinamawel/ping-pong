using System;
using System.Collections.Generic;
// using PingPong.Models;

namespace PingPong
{

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Enter a number");
      string userInput = Console.ReadLine();
      int userNumber = int.Parse(userInput);
      
      List<int> numberList = new List<int> {};

      for( int num = 1; num <= userNumber; num ++) 
      {
        numberList.Add(num);
      }
      foreach (int num in numberList) 
      {
        Console.WriteLine(num);
      }
    }
  }


/*using System;

class LeapYear
{
  static void Main()
  {
    Console.WriteLine("What year were you born in?");
    string birthYear = Console.ReadLine();
    int intBirthYear = int.Parse(birthYear);

    Console.WriteLine("You were alive during these leap years:");
    for (int year = intBirthYear; year <= 2020; year ++)
    {
    if (year % 4 == 0)
      {
        Console.WriteLine(year);
      }
    }
  }
}*/



}