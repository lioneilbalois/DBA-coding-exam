///1
/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int[] numlist = {5, 1, 4, 6, 7, 3, 5, 7, 3};
    
      Console.Write("[");
      for (int i = 0; i < numlist.Length; i++) { 
        int dupli = 0;

        for (int v = 0; v < numlist.Length; v++) { 
          if (numlist[v] == numlist[i]) {
            dupli++;
          }
        }

        if(dupli != 1) { 
          Console.Write(numlist[i]);
          
          if(i + 1 != numlist.Length) { Console.Write(", "); }
        }
      }
      Console.Write("]");
  }
}