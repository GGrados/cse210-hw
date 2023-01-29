using System;


public class FileManager
{

    public string _filename = "Temp%%File%%.txt"; // Name of the temporal file


    public void WriteFile(string currentDate, string prompt, string answer) // Write to a file
    {

        using (StreamWriter textfile = new StreamWriter(_filename, true))
        {
            textfile.WriteLine($"Date: {currentDate}: - Prompt: {prompt}"); // Write date and prompt
            textfile.WriteLine($"{answer}"); // Write answer
            textfile.WriteLine(); // White Line
            textfile.Flush(); // This enable push all the text to the file
        }

    }

    public void SaveFile(string newName) // Saving file
    {

        // Setting the location and new name of the file, this create another file with the
        // information from the temporal file
        string newFileLocation = String.Format("C:\\Users\\cesar\\OneDrive\\Escritorio\\ProgramingWithClasses\\cse210-hw\\prove\\Develop02\\{0}", newName);

        // Moving the data from the temporal file to the new file,
        // If the new file doesn't exists it will be created automatically
        File.Move(_filename, newFileLocation);

        // Deleting the temporal file
        File.Delete(_filename);
    }


}