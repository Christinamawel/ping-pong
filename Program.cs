using System;
using System.Collections.Generic;

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
        if (num % 3 == 0 && num % 5 == 0)
        {
          Console.WriteLine("ping-pong");
        } 
          else if (num % 3 == 0)
        {
          Console.WriteLine("ping");
        } 
          else if (num % 5 == 0)
        {
          Console.WriteLine("pong");
        }
          else
        {
          Console.WriteLine(num);
        }
      }
    }
  }
}