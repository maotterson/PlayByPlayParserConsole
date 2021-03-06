using PlayByPlayParserConsole;
using PlayByPlayParserConsole.Models;
using PlayByPlayParserConsole.PlayEvent;

string filePath = @".\Sample Data\GameDataFBRef.csv";
IEnumerable<Play> playList = linqMapping(filePath);
outputPlayList(playList);

/// <summary>
/// Extract plays from csv using linq syntax
/// </summary>
IEnumerable<Play> linqMapping(string filePath)
{
    IEnumerable<Play> playData = File.ReadAllLines(filePath)
                   .Skip(1)
                   .Select(x => x.Split(','))
                   .Select((x, index) => new Play
                   {
                       PlayIndex = index + 1,
                       Quarter = x[0],
                       Time = x[1],
                       Down = x[2],
                       ToGo = x[3],
                       Location = x[4],
                       Summary = x[5],
                       PlayEvent = PlayEventFactory.ExtractPlayEvent(x[5])
                   });
    return playData;
}

/// <summary>
/// Sample method to output some data for each play (for testing purposes)
/// </summary>
void outputPlayList(IEnumerable<Play> playList)
{
    foreach (Play play in playList)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{play.Quarter} {play.Time}");

        // check to see if play type was successfully parsed
        if(play.PlayEvent == null)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" Not Detected... {play.Summary}\n");
            continue;
        }

        // make scoring plays stand out
        if (play.PlayEvent.isScoringPlay())
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        // play type successfully parsed
        Console.Write($" {play.PlayEvent}\n");
    }
}