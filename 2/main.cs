/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
      for (int i = 1; i <= 6; i++) { 
        for (int v = i; v > 0; v--) {
           Console.Write(i);
           Console.Write(" ");
        }
        Console.WriteLine("");
      }
  }
}