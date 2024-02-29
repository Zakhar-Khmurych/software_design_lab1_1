using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IFileManager<T>
    {
        void Add(string path, string shortcut, T content, string name = null);        
        void Remove(string shortcut);
        List<T> ListFiles(string path);
        void Summarize(string path);
    }
}