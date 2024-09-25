// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Text;

Console.WriteLine("Hello, World!");
File.WriteAllText("D:\\other\\myFile.txt", "Hello");

List<string> sentences = new List<string>();
sentences.Add("Hello");
sentences.Add("this is second line");
sentences.Remove("Hello");
File.AppendAllLines("D:\\other\\myFile.txt", sentences);

string fileContents = File.ReadAllText("D:\\other\\myFile.txt", Encoding.UTF8);
Console.WriteLine(fileContents);