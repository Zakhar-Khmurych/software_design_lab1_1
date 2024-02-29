using System;
using System.Collections.Generic;
using System.IO;

namespace StepByStep
{
    public class FileActions_old //create an interface from employees
    {
        List<MyFile> MyFiles = new List<MyFile>();
        public void AddFile(string filePath)
        {
            string[] parts = filePath.Split('\\');
            string shortcut = parts[parts.Length - 1];
            //File.Create(@filePath); 
            MyFiles.Add(new MyFile(filePath, shortcut));
            Console.WriteLine("File added! "+ shortcut);
          
        }

        public void RemoveFile(string shortcut)
        {
            MyFile fileToRemove = MyFiles.Find(file => file.Name == shortcut);
            if (fileToRemove != null)
            {
                //File.Delete(fileToRemove.Path);
                MyFiles.Remove(fileToRemove);
            }
        }

        public void ListFiles()
        {
            foreach (var myFile in MyFiles)
            {
                Console.WriteLine("file name: " + myFile.Name);
            }
        }

        public void Options(string shortcut)
        {
            if (shortcut.Length >= 3 && shortcut.Substring(shortcut.Length - 3).Equals("txt", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("summarizing");
            }
            if (shortcut.Length >= 3 && shortcut.Substring(shortcut.Length - 3).Equals("csv", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("printing & validating");
            }
            if (shortcut.Length >= 4 && shortcut.Substring(shortcut.Length - 4).Equals("json", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("printing & validating");
            }

        }   
        public void Login(string shortcut)
        {
            
        }
        
    }
}