using System;
using System.IO;
using System.Security.Cryptography;


/*var p = new ParseXML();
p.GetCommentedCodeSectionFromPomFile("C:\\pomfile.xml");
Console.ReadKey();

string filePath = "C:\\pythontest.tar.gz";
string hashString = string.Empty;
if (File.Exists(filePath))
{
    using var fileStream = File.OpenRead(filePath);
    var hashBytes = ComputeSha215Hash(fileStream);
    hashString = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
}
Console.WriteLine(hashString);
byte[] ComputeSha215Hash(Stream stream)
{
    using SHA512 sha = new SHA512Managed();
    return sha.ComputeHash(stream);
}*/