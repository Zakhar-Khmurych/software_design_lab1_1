namespace StepByStep
{
    public class MyFile //separate class for new files
    {
        public string Path { get; }
        public string Name { get; }

        public MyFile(string path, string name)
        {
            Path = path;
            Name = name;
        }
    }
    
    public class FileSystem
    {
        
    }
}