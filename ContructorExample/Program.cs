// See https://aka.ms/new-console-template for more information
using ContructorExample;

Console.WriteLine("Hello, World!");


User user = new User();

// usul 1
string name1; int age1;
user.Deconstruct(out name1, out age1);

// usul 2
(string name, int age) = user;

// param kere bo'lmasa
(_, int age3) = user;
