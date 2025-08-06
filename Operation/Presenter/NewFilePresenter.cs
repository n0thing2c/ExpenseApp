using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Operation.Interface;

namespace Login.Operation.Presenter
{
    public class NewFilePresenter
    {
        private readonly INewFileView view;
        public NewFilePresenter(INewFileView Fileview)
        {
            view = Fileview;
            view.MakeFileRequested += HandleMakeFile;
        }
        public void HandleMakeFile(object sender, EventArgs e)
        {
            string FileType = view.type == "FM" ? "FMFiles" : "MDFiles";
            string folder = Path.Combine(view.userFolderPath, FileType);

            string month = new System.Globalization.CultureInfo("en-US").DateTimeFormat.GetMonthName(view.selectedMonth);
            string tail = view.type == "FM" ? "_Expenses.csv" : "_Group_Expenses.csv";
            string name = $"{month}_{view.selectedYear}{tail}";
            string path = Path.Combine(folder, name);

            if(!File.Exists(path) || view.OverWriteExistFile(name))
            {
                IFileCreator fileCreator = FileCreatorFactory.Get(view.type);
                fileCreator.CreateFile(path);
                view.NotifyFileCreated(path, view.type);
            }
        }
    }
}
