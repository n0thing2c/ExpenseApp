using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Operation.Interface
{
    public interface IPickFileView
    {
        string type { get; }

        event Action<string, string> OpenFileClicked;
        event EventHandler ExitButtonClicked;

        event EventHandler LoadFilesRequested;
        event Action<int> OpenFileRequested;
        event Action<int> DeleteFileRequested;

        void ShowFiles(IList<string> fileNames);
        bool ConfirmDelete(string fileName);
        void ShowMessage(string message, string caption);
        void NotifyFileOpened(string path, string type);
    }
}
