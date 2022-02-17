# NameSorter
### Sorting a list of strings and saving to a file
**Language:** C# (.NET Core)  
**Author:** Kelly Green (morkel3b)  
**Date:** 17/02/2022 

**Description**: This is a small console application written in C# which takes a text file as a command line argument. The program sorts the list of names, prints the sorted list to the console and saves the list to a file in the directory. By default the program sorts the names in ascending order, but it can also sort in descending order if "desc" is included as an additional argument.

## Instructions

1.  Clone or download the Github repository to a local location.

2. Navigate to the NameSorter folder which contains the name-sorter.exe file in the console (eg. command prompt)

3. Using the name-sorter command in the console followed by the name of the text file will start the program. The text file must be in the same directory as the name-sorter.exe file.
    - If successful, the names in the file will be sorted, printed to the console, and saved in the “sorted-names-list.txt” in the same directory. This file will be overwritten when the program is next run.
    - To sort in descending order, add "desc" as an argument after the filename
    - Examples: 
        - name-sorter unsorted-names-list.txt  (sorts the list in ascending order)
        - name-sorter unsorted-names-list.txt desc   (sorts the list in descending order)


5. The program self terminates with either an error message or a successful save message. Pressing any key will close the program and return to the command prompt.
