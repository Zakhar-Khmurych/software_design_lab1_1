using System;
using System.Collections.Generic;
using System.IO;

namespace StepByStep
{
    public interface IFileAction
    {
        void Act();
    }
    
    
    public class FileActions
    {
        List<MyFile> MyFiles = new List<MyFile>();
        
        public void AddFile(string filePath, MyFile myfile)
        {
            string[] parts = filePath.Split('\\');
            string shortcut = parts[parts.Length - 1];
            MyFiles.Add(new MyFile(filePath, shortcut));
            Console.WriteLine("File added! "+ shortcut);
        }

        public void RemoveFile(string shortcut, MyFile myfile)
        {
            MyFile fileToRemove = MyFiles.Find(file => file.Name == shortcut);
            if (fileToRemove != null)
            {
                MyFiles.Remove(fileToRemove);
                Console.WriteLine("File removed! "+ shortcut);
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