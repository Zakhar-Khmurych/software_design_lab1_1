using System.Collections.Generic;

namespace FromScratch
{
    public interface ICommand
    {
        void Execute(string[] arguments, List<MyFile> fileSystem);
    }
    
    //add 
    //remove
    //list
    
    
    
    
    
    
    
}