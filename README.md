# Play-by-Play  (from PFReference) Details

Based on verbiage in a play's detail category, contents such as involved player names, yardage gained, direction, etc. can be extracted and instantiated into different play types. Sentences are structured consistently once type is determined, but there are idiosyncrasies between different types. 

Regular expressions would thus be an intuitive option for categorization. Examples of the different types are demonstrated below:

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


### Run
- [x] Key phrases: __up the middle__, __right/left guard__, __right/left end__, __right/left tackle__
```
Aaron Jones up the middle for 4 yards (tackle by D.J. Jones)
```

Attribute  | Value | Regex Pattern
| :---: | :---: | :---:
Carrier | "Aaron Jones" | ^.*?(?= up the middle)
RushingYards | 4 | (?<=for )(.*?)(?= yards)
RushDirection | Direction.Middle | 
Tacklers | "D.J. Jones" | (?<=tackle by )(.*)(?=\))


### Pass (Complete)
- [x] Key phrase: __pass complete__
```
Aaron Rodgers pass complete short right to Davante Adams for 14 yards (tackle by Dontae Johnson)
```

Attribute  | Value | Regex Pattern
| :---: | :---: | :---:
Passer | "Aaron Rodgers" | ^.*?(?= pass)
Receiver | "Davante Adams" | (?<=to )(.*?)(?= for)
PassYards | 14 | (?<=for )(.*?)(?= yards)
PassDirection | Direction.ShortRight | 
Tacklers | "Dontae Johnson" | (?<=tackle by )(.*)(?=\))


### Pass (Incomplete)
- [x] Key phrase: __pass incomplete__
```
Aaron Rodgers pass incomplete short middle intended for Aaron Jones
```

Attribute  | Value | Regex Pattern
| :---: | :---: | :---:
Passer | "Aaron Rodgers" | ^.*?(?= pass)
Receiver | "Aaron Jones" | (?<=intended for )(.*?)
PassDirection | Direction.ShortMiddle | 

### Kicks Field Goal

### Kicks Extra Point
```
Mason Crosby kicks extra point good
```

Attribute  | Value | Regex Pattern
| :---: | :---: | :---:
Kicker | "Mason Crosby" | ^.*?(?= kicks extra)
KickOutcome | Kick.Good | 

### Punt

### Penalty

### Sack

### Spike

### Kneel
