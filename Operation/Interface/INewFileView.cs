using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Operation.Interface
{
    public interface INewFileView
    {
        string userFolderPath { get; }
        string type { get; }
        int selectedMonth { get; }
        int selectedYear { get; }

        //Event view raise to presenter
        event EventHandler ExitClicked;
        event EventHandler MakeFileRequested;

        //Event view raise after file is created
        event Action<string, string> MakeFileClicked;
        bool OverWriteExistFile(string name);

        //Presenter notify to view that file is created, relay to menu to do MakeFileClicked event
        void NotifyFileCreated(string path, string type);
    }
}
