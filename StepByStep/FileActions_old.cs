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
            
            File.Create(@filePath); 
            MyFiles.Add(new MyFile(filePath, shortcut));
            Console.WriteLine("File added! "+ shortcut);
            /*
             
             "C:\Users\HP\RiderProjects\software_design_lab1_1\Files\file1.txt"
             "C:\Users\HP\RiderProjects\software_design_lab1_1\Files\file2.txt"
             "C:\Users\HP\RiderProjects\software_design_lab1_1\Files\file3.txt"
             
             */
        }

        public void RemoveFile(string shortcut)
        {
            MyFile fileToRemove = MyFiles.Find(file => file.Name == shortcut);
            if (fileToRemove != null)
            {
                File.Delete(fileToRemove.Path);
                MyFiles.Remove(fileToRemove);
            }
        }

        public void ListFiles()
        {
            foreach (var myFile in MyFiles)
            {
                Console.WriteLine(myFile.Name);
            }
        }
        
    }
}