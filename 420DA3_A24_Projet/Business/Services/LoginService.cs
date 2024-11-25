using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Presentation;

namespace _420DA3_A24_Projet.Business.Services;
internal class LoginService {

    private readonly WsysApplication parentApp;
    private readonly LoginWindow loginWindow;
    private readonly RoleSelectionWindow roleSelectionWindow;

    public User? LoggedInUser { get; private set; }
    public Role? LoggedInUserRole { get; private set; }
    public bool IsUserLoggedIn { get; private set; }

    public LoginService(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.loginWindow = new LoginWindow(parentApp);
        this.roleSelectionWindow = new RoleSelectionWindow(parentApp);
        this.IsUserLoggedIn = false;
    }

    public bool RequireLoggedInUser() {
        // TODO @PROF: compléter
    }

    public void OpenLoginWindow() {
        // TODO @PROF: compléter
    }

    public void TryLogin(string username, string password) {
        // TODO @PROF: compléter
    }

    public void LogOut() {
        // TODO @PROF: compléter
    }
}
