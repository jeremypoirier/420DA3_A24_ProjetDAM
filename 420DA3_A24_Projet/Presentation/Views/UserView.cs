using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class UserView : Form {

    private readonly WsysApplication parentApp;

    public User CurrentInstance { get; private set; }
    public ViewActionsEnum CurrentAction { get; private set; }

    public UserView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(User emptyUser) {
        this.PreOpenSetup(ViewActionsEnum.Creation, emptyUser, "Création d'un utilisateur", "CRÉER");
        return this.ShowDialog();
    }

    public DialogResult OpenForDetailsView(User user) {
        this.PreOpenSetup(ViewActionsEnum.Visualization, user, "Détails d'un utilisateur", "OK");
        return this.ShowDialog();
    }

    public DialogResult OpenForEdition(User user) {
        this.PreOpenSetup(ViewActionsEnum.Edition, user, "Modification d'un utilisateur", "ENREGISTRER");
        return this.ShowDialog();
    }

    public DialogResult OpenForDeletion(User user) {
        this.PreOpenSetup(ViewActionsEnum.Deletion, user, "Suppression d'un utilisateur", "SUPPRIMER");
        return this.ShowDialog();
    }



    private void PreOpenSetup(ViewActionsEnum action, User instance, string windowTitle, string actionButtonText) {
        this.CurrentAction = action;
        this.CurrentInstance = instance;
        this.Text = windowTitle;
        this.modeFenetreValue.Text = action.ToString();
        this.btnAction.Text = actionButtonText;
        this.LoadUserDataInControls(instance);
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateEditableControls();
        } else {
            this.DeactivateEditableControls();
        }
    }

    private void LoadUserDataInControls(User user) {
        // TODO @PROF: charger les données de l'utilisateur dans les contrôles
    }

    private void UpdateUserInstanceFromControls(User user) {
        try {
            this.ValidateControlValues();
            user.Username = this.usernameValue.Text;
            user.PasswordHash = this.parentApp.PasswordService.HashPassword(this.passwordValue.Text);
            // TODO @PROF: revoir sélecteur pour avoir une valeu 'null' sélectionnable.
            user.EmployeeWarehouse = this.whEmployeeWarehouseValue.SelectedItem as Entrepot;
            user.Roles = this.userRolesValues.SelectedItems.Cast<Role>().ToList();

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message,
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void ValidateControlValues() {
        if (this.usernameValue.Text.Length < User.USERNAME_MIN_LENGTH) {
            throw new Exception($"Le nom d'utilisateur doit contenir au moins {User.USERNAME_MIN_LENGTH} caractères.");
        }
        if (this.usernameValue.Text.Length > User.USERNAME_MAX_LENGTH) {
            throw new Exception($"Le nom d'utilisateur ne doit pas contenir plus de {User.USERNAME_MAX_LENGTH} caractères.");
        }
        if (this.passwordValue.Text.Length < User.PASSWORD_MIN_LENGTH) {
            throw new Exception($"Le mot de passe doit contenir au moins {User.PASSWORD_MIN_LENGTH} caractères.");
        }
        if (this.passwordValue.Text.Length > User.PASSWORD_MAX_LENGTH) {
            throw new Exception($"Le mot de passe ne doit pas contenir plus {User.PASSWORD_MAX_LENGTH} caractères.");
        }
        if (this.userRolesValues.SelectedItems.Count <= 0) {
            throw new Exception($"Au moins un rôle doit être sélectionné.");
        }
    }

    private void ActivateEditableControls() {
        this.usernameValue.Enabled = true;
        this.passwordValue.Enabled = true;
        this.whEmployeeWarehouseValue.Enabled = true;
        this.userRolesValues.Enabled = true;
    }

    private void DeactivateEditableControls() {
        this.usernameValue.Enabled = false;
        this.passwordValue.Enabled = false;
        this.whEmployeeWarehouseValue.Enabled = false;
        this.userRolesValues.Enabled = false;
    }


    private void BtnCancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void BtnAction_Click(object sender, EventArgs e) {
        try {
            this.ProcessAction();
            this.DialogResult = DialogResult.OK;
        } catch (Exception ex) {
            // TODO @PROF: afficher erreur
        }
    }

    private void ProcessAction() {

    }
}
