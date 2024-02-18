using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IFileManager
    {
        void Add(string path, string shortcut, string name = null);        
        void Remove(string shortcut);
        List<File> ListFiles(string path);
        void Summarize(string path);
    }
}