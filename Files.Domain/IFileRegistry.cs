using System.Collections.Generic;
using System.Linq;


namespace RemakeAndRefactor
{
    public interface IFileRegistry
    {
        MyFile Add(string path, string name);

        void Remove(string name);

        List<MyFile> GetAll();
    }

    public class FileRegistry : IFileRegistry
    {
        private readonly List<MyFile> my_files = new List<MyFile>();

        public MyFile Add(string path, string name)
        {
            var myFile = new MyFile(path, name);
            my_files.Add(myFile);
            return myFile;
        }

        public void Remove(string name)
        {
            var myFile = my_files.FirstOrDefault(e => e.Name == name);
            if (myFile != null)
            {
                my_files.Remove(myFile);
            }
        }

        public List<MyFile> GetAll()
        {
            return my_files;
        }
    }
}