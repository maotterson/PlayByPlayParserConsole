﻿string filePath = @".\Sample Data\GameDataFBRef.csv";
linqMapping(filePath);

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

        // extract data from summary by type

    }
}