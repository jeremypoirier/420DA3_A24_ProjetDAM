using _420DA3_A24_Projet.Business;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class UserView : Form {

    private readonly WsysApplication parentApp;

    public UserView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

}
