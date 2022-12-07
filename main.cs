using System;

class Program {
  public static void Main (string[] args) {

Double C,F;
String entrada;
Console.WriteLine("digite a temperatura em fahrenhert");
entrada=Console.ReadLine();
F = Double.Parse(entrada);
C = (F-32.0)*(5.0/9.0);
{Console.WriteLine ("a temperatura em celsius é " + C +  " celsius");}    
  }
}
