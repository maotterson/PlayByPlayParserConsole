// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;

using (TextFieldParser parser = new TextFieldParser(@".\Sample Data\GameDataFBRef.csv"))
{
    parser.TextFieldType = FieldType.Delimited;
    parser.SetDelimiters(",");
    while (!parser.EndOfData)
    {
        //Processing row
        string[] fields = parser.ReadFields();
        foreach (string field in fields)
        {
            Console.WriteLine(field);
            //TODO: Process field
        }
        Console.ReadLine();
    }
}