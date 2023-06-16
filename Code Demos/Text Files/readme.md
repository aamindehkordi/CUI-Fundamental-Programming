# Text Files
This folder contains a small variety of different ways to interact and use text files algorithmically.

## ContactBook
The 'ContactBook' project demonstrates how to read a text file and search for contacts. The program prompts the user to enter a search term and then reads a file named 'Contacts.txt'. For each line in the file, it splits the line into fields using the pipe character as the separator. It expects four fields: name, office, phone, and email. If the name field contains the search term (case-insensitive), it prints the contact's details. If the line does not have four fields, it prints an error message. The program continues to prompt the user for search terms until the user enters 'quit'.

## SimpleFileStreams
The 'SimpleFileStreams' project demonstrates how to read from and write to text files. The program reads a file named 'HelloFundamentals.txt' line by line, printing each line to the console and counting the number of lines. After reading the file, it then creates three strings, each containing a line of text. It opens a StreamWriter to a file named 'Romans5_8.txt'. If the file already exists, the program overwrites it; otherwise, it creates a new file. It writes each string to the file as a separate line, then closes the StreamWriter.

## WritingWoes
The 'WritingWoes' project demonstrates how to read a text file and parse its contents. The program reads a file named 'periodic table.txt' and splits it into parts using ':' and ',' as separators. It then reads a formula (in this case, "HNa2O") and splits it into elements and their counts. For each element in the formula, it searches the periodic table for the element's mass and adds it to the total mass. The program prints the total mass at the end.

