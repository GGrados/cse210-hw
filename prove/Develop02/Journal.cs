using System;
using System.IO;

public class Journal
{
    // string _date;  I didn't use this attribute 

    public List<String> _entries = new List<String>(); // List of entries
    string _filename; // Filename Attribute

    DateTime theCurrentTime = DateTime.Now; // Date Object

    public void AddingEntry(string prompt, string entry)
    //This Method add a formatted version of the string to the _entries attribute
    // Parameters:
    //          prompt: The random Prompt showed to the user as a string
    //          entry: the user answer as a string
    {

        string dateText = theCurrentTime.ToShortDateString(); // getting the date as a string

        string formattedEntryString = ($"Date: {dateText} - Prompt: {prompt} {entry}"); // Formatting the string with the parameters

        _entries.Add(formattedEntryString); // Adding the string to the _entries attribute
    }

    public void DisplayEntries()
    // This method loop the _entries list and print each line
    {
        foreach (string line in _entries)
        {

            Console.WriteLine(line); // printing the current line
            Console.WriteLine(); // White line

        }
    }

    public void SaveToFile()
    // This method write in a new file the lines in the _entries list
    {
        Console.WriteLine("What is the name of the new file: ");
        _filename = Console.ReadLine(); // Setting the new file name as the _filename attribute of this class


        // I copied this from the example, i think this create a WriterObject. I just added the "TRUE"...
        // ... to anable the appending mode in case i need to append more lines to an existing file  
        using (StreamWriter textfile = new StreamWriter(_filename, true))
        {
            foreach (string line in _entries)
                textfile.WriteLine(line);

            textfile.Flush(); // Clears buffers for this stream and causes any buffered data to be written to the file.
        }

    }

    public void LoadFromFile()
    {
        Console.WriteLine("Name of the new file: ");
        string newFileName = Console.ReadLine();
        _filename = newFileName; // setting the _filename to the name of a existing file


        _entries.Clear(); // Clearing the _entries list 


        string[] lines = System.IO.File.ReadAllLines(_filename); // This create a list with all the lines from the loaded file
        foreach (string line in lines) // looping
        {

            _entries.Add(line); // adding the current line from the loaded file to the _entries list

        }

    }




}