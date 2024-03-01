using KursachFileSaving.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachFileSaving.Models.Interfaces
{
    public interface ILoginFormView
    {
        event EventHandler LoginAttempt;
        event EventHandler LoginFailure;
        event EventHandler InitializeFile;
        string GetLogin();
        string GetPassword();

        // Метод для отображения сообщения об ошибке при входе
        void ShowLoginFailureMessage(string message);
        void LoginSuccess(object sender, EventArgs e);
    }
}
