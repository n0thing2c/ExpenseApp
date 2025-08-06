using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Login.Operation.UserLog;
using System.Windows.Forms;

namespace Login.Operation.Interface
{
    /// Interface for file service operations (path, delete...)
    public interface IFileService
    {
        IList<string> GetFilePaths(string fileType);
        void DeleteFile(string path);
    }
    public class FileService : IFileService
    {

        public IList<string> GetFilePaths(string fileType)
        {
            string baseFolder = Account.GetCurrentAcc().GetUserFolder().GetFolderPath();
            string type = fileType == "FM" ? "FMFiles" : "MDFiles";
            string folder = Path.Combine(baseFolder, type);
            
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            return Directory.GetFiles(folder, "*.csv").ToList();
        }

        public void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
