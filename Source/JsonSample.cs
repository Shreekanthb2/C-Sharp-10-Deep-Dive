// File-Scoped namespace Declaration
namespace C_Sharp_10_Deep_Dive.Source;

internal class JsonSample
{
    public void SerializeJSON()
    {
        var myData = new
        {
            Host = @"sftp.myhost.gr",
            UserName = "my_username",
            Password = "my_password",
            SourceDir = "/export/zip/mypath/",
            FileName = "my_file.zip"
        };

        //Tranform it to Json object
        string jsonData = JsonConvert.SerializeObject(myData);

        Console.WriteLine(jsonData);
    }
    

}
