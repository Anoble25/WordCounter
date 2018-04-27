# WordCounter

#### _Word Counter, 4/27/18_

#### By _**Alex Noble**_

## Description
_A website in MVC that uses a method to return how frequently a word appears in a given string. The user inputs both the word and the string of words to check_

## Setup/Installation Requirements

* _Clone or download the repository._
* _Install C# with the .NET framework_
* _Locate and change to the WordCounter folder in the WordCounter directory using the terminal_
* _Run Dotnet Restore then Dotnet Run commands in the terminal_

## Specifications
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **User enters a single character string. User enters a second matching single character string. The value 0 is returned.** | "A", "B" | "0"|
| **User enters a single character string. User enters a second matching single character string. The value 1 is returned.** | "A", "A" | "1"|
| **User enters a multiple character string. User enters a second non-matching string. The value 0 is returned.** | "Ab", "C" | "0"|
| **User enters a multiple character string. User enters a second matching string. The value 1 is returned.** | "Happy", "Happy" | "1"|
| **User enters a multiple word string. User enters a second word that appears in the first string. The value 1 is returned.** | "Happy Birthday", "Happy" | "1"|
| **User enters a multiple word string. User enters a second word that appears in the first string multiple times. The number of times it appears is returned.** | "Happy Happy Birthday", "Happy" | "3"|
| **User enters a multiple word string with punctuation other than spaces. User enters a second word that appears in the first string multiple times. The number of times it appears is returned.** | "Happy! Happy! Birthday", "Happy" | "3"|

## Known Bugs

_No known bugs_


## Technologies Used
* HTML5/CSS
* C#/.NET

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Alex Noble_**
