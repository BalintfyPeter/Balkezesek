using System.IO;
using System.Collections.Generic;

List<string> list = new List<string>();

StreamReader sr = new StreamReader("Data/balkezesek.csv");

while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    list.Add(sor);
}

sr.Close();
