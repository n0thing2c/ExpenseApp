using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Operation.Interface
{
    public interface IAuthView
    {
        string Username { get; }
        string Password { get; }
        void ShowError(string message);
        void ClearFields();
        void NavigateToMenu(string username);
    }
}
