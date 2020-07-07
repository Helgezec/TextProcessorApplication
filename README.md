# TextProcessorApplication
Application forms dictionary of "common words" in a database and then this dictionary can be used for word autocomplete. 

It can be launched with 3 command prompt arguments: 

1)"create" - for creating a new dictionary from text file.

2)"update" - for updating dictionary from text file.

3)"delete" - for dictionary deletion.


If it is launched without arguments, then you can write the beginning of a word, and the program will give you 5 most frequent words for autocomplete (if frequencies  are the same, words sorted alphabetically).

Text file - UTF-8 file with words (letter sequence) separated by whitespace. Word should occur at least 3 times in file for it to be added to dictionary. If it is already added, it will update the frequency of word in dictionary. Word length should also be no more then 15 symbols.

Application using MS SQL and it can initialize database if it is not already created.
