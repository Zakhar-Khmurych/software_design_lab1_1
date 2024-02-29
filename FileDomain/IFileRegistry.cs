using  System.Collections.Generic;
using System.Linq;
using FileDomain;

namespace StepByStep
{
 
    public interface IFileRegistry
    {
        MyFile Add(string path, string name);

        void Remove(string name);

        List<MyFile> GetAll();
    }

    public class FileRegistry : IFileRegistry
    {
        private readonly List<MyFile> files = new List<MyFile>();

        public MyFile Add(string path, string name)
        {
            var myFile = new MyFile(path, name);
            files.Add(myFile);
            return myFile;
        }

        public void Remove(string name)
        {
            
            var myFile = files.FirstOrDefault(e => e.Name == name);
            if (myFile != null)
            {
                files.Remove(myFile);
            }
        }

        public List<MyFile> GetAll()
        {
            return files;
        }
    }
}