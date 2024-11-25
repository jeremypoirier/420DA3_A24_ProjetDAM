using _420DA3_A24_Projet.Business;

namespace _420DA3_A24_Projet.Presentation;
internal partial class RoleSelectionWindow : Form {

    private readonly WsysApplication parentApp;

    public RoleSelectionWindow(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }
}
