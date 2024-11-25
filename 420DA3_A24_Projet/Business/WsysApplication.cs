using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System.Diagnostics;
using System.Text;

namespace _420DA3_A24_Projet.Business;
internal class WsysApplication {

    private WsysDbContext context;
    public PasswordService PasswordService { get; private set; }
    public TrackingNumberFactory TrackingNumberFactory { get; private set; }
    public UserService UserService { get; private set; }
    public RoleService RoleService { get; private set; }
    public LoginService LoginService { get; private set; }

    public WsysApplication() {
        this.context = new WsysDbContext();
        this.PasswordService = PasswordService.GetInstance();
        this.TrackingNumberFactory = TrackingNumberFactory.GetInstance();
        this.UserService = new UserService(this, this.context);
        this.RoleService = new RoleService(this, this.context);
        this.LoginService = new LoginService(this);
    }


    /// <summary>
    /// Gestion générale d'une exception.
    /// </summary>
    /// <remarks>
    /// Affiche les détails de l'exception dans la console, dans la fenêtre de débogage et dans une boîte de dialogue.
    /// </remarks>
    /// <param name="ex">L'exception à gérer.</param>
    public void HandleException(Exception ex) {
        string? stack = ex.StackTrace;
        StringBuilder messageBuilder = new StringBuilder();
        Console.Error.WriteLine(ex.Message);
        Debug.WriteLine(ex.Message);
        _ = messageBuilder.Append(ex.Message);
        while (ex.InnerException != null) {
            ex = ex.InnerException;
            Console.Error.WriteLine(ex.Message);
            Debug.WriteLine(ex.Message);
            _ = messageBuilder.Append(Environment.NewLine + "Caused By: " + ex.Message);
        }
        Console.Error.WriteLine("Stack trace:");
        Console.Error.WriteLine(stack);
        Debug.WriteLine("Stack trace:");
        Debug.WriteLine(stack);
        _ = MessageBox.Show(messageBuilder.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }
}
