# Play-by-Play  (from PFReference) Details

Console application used to help derive classes from play-by-play data to be implemented in a .NET web application.

Based on verbiage in a play's detail category, contents such as involved player names, yardage gained, direction, etc. can be extracted and instantiated into different play types. Sentences are structured consistently once type is determined, but there are idiosyncrasies between different types. 

Regular expressions would thus be an intuitive option for categorization. Examples of how different types might be demonstrated below:

### Kickoff

- [x] Key phrase: __kicks off__
```
Robbie Gould kicks off 49 yards returned by Amari Rodgers for 15 yards (tackle by Demetrius Flannigan-Fowles)
```

Attribute  | Value | Regex Pattern
| :---: | :---: | :---:
Kicker | "Robbie Gould" | ^.*?(?= kicks off)
KickYards | 49 | (?<=kicks off )(.*?)(?= yards)
Returner | "Amari Rodgers" | (?<=returned by )(.*?)(?= for)
ReturnYards | 15 | (?<=for )(.*?)(?= yards)
Tacklers | "Demetrius Flannigan-Fowles" | (?<=tackle by )(.*)(?=\))
