using System.IO;
using System.Collections.Generic;

List<string> list = new List<string>();

//Feladat 1
StreamReader sr = new StreamReader("Data/balkezesek.csv");

while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    list.Add(sor);
}

sr.Close();


//Feladat 2
