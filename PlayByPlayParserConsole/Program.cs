// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;

string filePath = @".\Sample Data\GameDataFBRef.csv";

//outputFileIO(filePath);
linqMapping(filePath);

void outputFileIO(string filePath)
{
    using (TextFieldParser parser = new TextFieldParser(filePath))
    {
        parser.TextFieldType = FieldType.Delimited;
        parser.SetDelimiters(",");
        while (!parser.EndOfData)
        {
            //Processing row
            string[] fields = parser.ReadFields();
            foreach (string field in fields)
            {
                Console.Write(field + " ");
            }
        }
        Console.ReadLine();
    }
}

void linqMapping(string filePath)
{
    var playData = File.ReadAllLines(filePath)
                   .Skip(1)
                   .Select(x => x.Split(','))
                   .Select((x,index) => new
                    {
                        PlayIndex = index+1,
                        Quarter = x[0],
                        Time = x[1],
                        Down = x[2],
                        ToGo = x[3],
                        Location = x[4],
                        Summary = x[5]
                   });
    foreach(var play in playData)
    {
        Console.WriteLine(play.Summary);
    }
}