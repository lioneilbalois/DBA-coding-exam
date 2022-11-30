/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      Console.Write("Enter the number of newly hired males:");
      int new_males = Convert.ToInt32(Console.ReadLine());
    
      Console.Write("Enter the number of newly hired females:");
      int new_females = Convert.ToInt32(Console.ReadLine());
    
      Console.Write("Enter the number of permanent position males:");
      int perm_males = Convert.ToInt32(Console.ReadLine());
    
      Console.Write("Enter the number of permanent position females:");
      int perm_females = Convert.ToInt32(Console.ReadLine());
      
      Console.Write("Enter the number of resigned males:");
      int res_males = Convert.ToInt32(Console.ReadLine());
    
      Console.Write("Enter the number of resigned females:");
      int res_females = Convert.ToInt32(Console.ReadLine());
    
      Console.WriteLine("");
      Console.WriteLine("===");
      Console.WriteLine("Thank you for the information");
      Console.WriteLine("===");
      Console.WriteLine("Here is the Summary !!!");
    
      // Results
      Console.Write("Number of hired employee = ");
      Console.WriteLine(new_males + new_females);
      Console.Write("Male = ");
      Console.Write(Math.Round(((Decimal.Divide(new_males, (new_males + new_females))) * 100), 2));
      Console.WriteLine("%");
      Console.Write("Male = ");
      Console.Write(Math.Round(((Decimal.Divide(new_females, (new_males + new_females))) * 100), 2));
      Console.WriteLine("%");
    
      Console.WriteLine("");
      Console.Write("Number of Permanent employee = ");
      Console.WriteLine(perm_males + perm_females);
      Console.Write("Male = ");
      Console.Write(Math.Round(((Decimal.Divide(perm_males, (perm_males + perm_females))) * 100), 2));
      Console.WriteLine("%");
      Console.Write("Male = ");
      Console.Write(Math.Round(((Decimal.Divide(perm_females, (perm_males + perm_females))) * 100), 2));
      Console.WriteLine("%");
    
      Console.WriteLine("");
      Console.Write("Number of Resigned employee = ");
      Console.WriteLine(res_males + res_females);
      Console.Write("Male = ");
      Console.Write(Math.Round(((Decimal.Divide(res_males, (res_males + res_females))) * 100), 2));
      Console.WriteLine("%");
      Console.Write("Male = ");
      Console.Write(Math.Round(((Decimal.Divide(res_females, (res_males + res_females))) * 100), 2));
      Console.WriteLine("%");
  }
}