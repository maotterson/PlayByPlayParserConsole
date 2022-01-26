# Play-by-Play  (from PFReference) Details

Based on verbiage in a play's detail category, contents such as involved player names, yardage gained, direction, etc. can be extracted and instantiated into different play types. Sentences are structured consistently once type is determined, but there are idiosyncrasies between different types. 

Regular expressions would thus be an intuitive option for categorization. Examples of the different types are demonstrated below:

### Kickoff

- [x] Key phrase: __kicks off__
```
Robbie Gould kicks off 49 yards returned by Amari Rodgers for 15 yards (tackle by Demetrius Flannigan-Fowles)
```

Attribute  | Value
| :---: | :---:
Kicker | "Robbie Gould"
KickYards | 49
Returner | "Amari Rodgers"
ReturnYards | 15
Tacklers | "Demetrius Flannigan-Fowles"
