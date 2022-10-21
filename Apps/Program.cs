// See https://aka.ms/new-console-template for more information

using Apps;
using System.Collections;
using System.Net.WebSockets;

Examples.Examples2();
Console.WriteLine("-------------------------");

var arr = new DataStructures
    .Array
    .Array<int>();
arr.Add(21);
arr.Add(22);
arr.Add(23);
arr.Add(24); 
arr.Add(25);
arr.Add(26);
arr.Add(27);
arr.Add(28);
arr.Add(29);
arr.Add(30);
arr.Add(31);


Console.WriteLine($"{arr.Count} / {arr.Capasity}");
arr.DiziyiListele();
arr.Remove();
arr.Remove();
arr.Remove();
arr.Remove(); 
arr.Remove();
arr.Remove();
arr.Remove();
arr.Remove();

Console.WriteLine($"{arr.Count} / {arr.Capasity}");
arr.DiziyiListele();
