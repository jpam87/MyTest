using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

public class ParseXML
{
    public string GetCommentedCodeSectionFromPomFile(string pomContent)
    {
        var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xml");
        var comments = "";
        try
        {
            var settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Ignore;
            //File.WriteAllText(tempFile, pomContent);
            XmlReader reader = XmlReader.Create(pomContent,settings);
            var document = XDocument.Load(reader);
            comments = string.Concat(document.Nodes().OfType<XComment>().Select(_ => _.Value));
        }
        catch (Exception exception)
        {
            Console.WriteLine("Failed to get the commented content from the Pom file", exception, pomContent);
        }
        finally
        {
            if (File.Exists(tempFile))
            {
                File.Delete(tempFile);
            }
        }

        return comments;

    }
}
