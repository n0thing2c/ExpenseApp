using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Login.Operation.Interface;
using System.Windows.Forms;

namespace Login.Operation.Presenter
{
    public class PickFilePresenter
    {
        private readonly IPickFileView view;
        private readonly IFileService service;
        private string[] paths;
        public PickFilePresenter(IPickFileView fileView, IFileService fileService)
        {
            view = fileView;
            service = fileService;
            view.LoadFilesRequested += HandleLoadFiles;
            view.OpenFileRequested += HandleOpenFile;
            view.DeleteFileRequested += HandleDeleteFile;
           
        }

        private void HandleLoadFiles(object sender, EventArgs e)
        {
            paths = service.GetFilePaths(view.type).ToArray();
            if (paths.Length == 0)
            {
                view.ShowMessage("No files found.", "Information");
                view.ShowFiles(Array.Empty<string>());
            }
            else
            {
                var names = paths.Select(Path.GetFileName).ToArray();
                view.ShowFiles(names);
            }
        }

        private void HandleOpenFile(int index)
        {
            string path = paths[index];
            view.NotifyFileOpened(path, view.type);
        }

        private void HandleDeleteFile(int index)
        {
            string path = paths[index];
            string filename = Path.GetFileName(path);

            if(view.ConfirmDelete(filename))
            {
                service.DeleteFile(path);
                HandleLoadFiles(this, EventArgs.Empty);
            }
        }
    }
}
