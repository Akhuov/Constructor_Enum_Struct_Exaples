// See https://aka.ms/new-console-template for more information
using StrucExample;

Console.WriteLine("Hello, World!");

User ali = new User();
User ali1 = new();
User ali2;         // contsructersiz
// maydonlarga qitmay berish
ali.name = "Sam";
ali.age = 37;


///---
User tom = new User { name = "Ali", age = 22 };
User bob = tom with { name = "Bob" };
bob.Print();
tom.Print();

