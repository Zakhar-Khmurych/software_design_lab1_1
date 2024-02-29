namespace FromScratch
{
    public class MyFile
    {
        public string Path { get; }
        public string Name { get; }
        

        public MyFile(string path, string name)
        {
            Path = path;
            Name = name;
        }
    }
}