using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Page;

namespace Login.Operation.Interface
{
    public interface IFileCreator
    {
        void CreateFile(string path);
    }
    public static class FileCreatorFactory
    {
        public static IFileCreator Get(string type)
        {
            return type == "FM" ? (IFileCreator) new FMFileCreator() : new MDFileCreator();
        }
    }
    public class FMFileCreator : IFileCreator
    {
        public void CreateFile(string path) => new FMFile().Create(path);
    }

    public class MDFileCreator : IFileCreator
    {
        public void CreateFile(string path) => new MDFile().Create(path);
    }
}
