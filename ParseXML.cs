using System;

public class Class1
{
	public Class1()
	{
        var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xml");
        var comments = "";
        try
        {
            File.WriteAllText(tempFile, pomContent);
            var document = XDocument.Load(tempFile);
            comments = string.Concat(document.Nodes().OfType<XComment>().Select(_ => _.Value));
        }
        catch (Exception exception)
        {
            Logger.Error("Failed to get the commented content from the Pom file", exception, pomContent);
        }
        finally
        {
            if (File.Exists(tempFile))
            {
                File.Delete(tempFile);
            }
        }
    }
}
