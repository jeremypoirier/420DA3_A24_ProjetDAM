using _420DA3_A24_Projet.Business;

namespace _420DA3_A24_Projet.Presentation;
internal partial class LoginWindow : Form {

    private readonly WsysApplication parentApp;

    public LoginWindow(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    private void ButtonCancel_Click(object sender, EventArgs e) {
        DialogResult result = MessageBox.Show("Il est nécessaire de se connecter pour utiliser l'application; voulez-vous vraiment quitter l'application?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes) {
            Application.Exit();
        }
    }

    private void ButtonConnection_Click(object sender, EventArgs e) {

    }
}
