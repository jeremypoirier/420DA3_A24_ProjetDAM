using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;

/// <summary>
/// TODO @PROF: documenter
/// </summary>
internal partial class UserView : Form {

    private readonly WsysApplication parentApp;
    private static readonly object warehouseNullValue = "Aucun";

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    public User CurrentInstance { get; private set; } = null!;
    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="parentApp"></param>
    public UserView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="emptyUser"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(User emptyUser) {
        this.PreOpenSetup(ViewActionsEnum.Creation, emptyUser, "Création d'un utilisateur", "CRÉER");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(User user) {
        this.PreOpenSetup(ViewActionsEnum.Visualization, user, "Détails d'un utilisateur", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public DialogResult OpenForEdition(User user) {
        this.PreOpenSetup(ViewActionsEnum.Edition, user, "Modification d'un utilisateur", "ENREGISTRER");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(User user) {
        this.PreOpenSetup(ViewActionsEnum.Deletion, user, "Suppression d'un utilisateur", "SUPPRIMER");
        return this.ShowDialog();
    }


    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="action"></param>
    /// <param name="instance"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(ViewActionsEnum action, User instance, string windowTitle, string actionButtonText) {
        this.ReloadWarehouseSelector();
        this.ReloadRolesSelector();
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

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    private void ReloadWarehouseSelector() {
        this.whEmployeeWarehouseValue.Items.Clear();
        _ = this.whEmployeeWarehouseValue.Items.Add(warehouseNullValue);
        this.whEmployeeWarehouseValue.Items.AddRange(this.parentApp.WarehouseService.GetAll().ToArray());
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    private void ReloadRolesSelector() {
        this.userRolesValues.Items.Clear();
        this.userRolesValues.Items.AddRange(this.parentApp.RoleService.GetAll().ToArray());
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="user"></param>
    private void LoadUserDataInControls(User user) {
        this.idValue.Value = user.Id;
        this.usernameValue.Text = user.Username;
        this.pwHashValue.Text = user.PasswordHash;
        if (user.EmployeeWarehouse is not null) {
            this.whEmployeeWarehouseValue.SelectedItem = user.EmployeeWarehouse;
        } else {
            this.whEmployeeWarehouseValue.SelectedItem = warehouseNullValue;
        }
        this.dateCreatedValue.Value = user.DateCreated;
        this.dateModifiedValue.Value = user.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = user.DateDeleted ?? DateTime.Now;
        this.userRolesValues.SelectedItems.Clear();
        foreach (Role role in user.Roles) {
            this.userRolesValues.SelectedItems.Add(role);
        }
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="user"></param>
    private void UpdateUserInstanceFromControls(User user) {
        try {
            this.ValidateControlValues();
            user.Username = this.usernameValue.Text;
            user.PasswordHash = this.parentApp.PasswordService.HashPassword(this.passwordValue.Text);
            user.EmployeeWarehouse = this.whEmployeeWarehouseValue.SelectedItem as Entrepot;
            user.Roles.Clear();
            foreach (Role role in this.userRolesValues.SelectedItems.Cast<Role>().ToList()) {
                user.Roles.Add(role);
            }
            //user.Roles = this.userRolesValues.SelectedItems.Cast<Role>().ToList();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
            return;
        }
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <exception cref="Exception"></exception>
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

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    private void ActivateEditableControls() {
        this.usernameValue.Enabled = true;
        this.passwordValue.Enabled = true;
        this.whEmployeeWarehouseValue.Enabled = true;
        this.userRolesValues.Enabled = true;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    private void DeactivateEditableControls() {
        this.usernameValue.Enabled = false;
        this.passwordValue.Enabled = false;
        this.whEmployeeWarehouseValue.Enabled = false;
        this.userRolesValues.Enabled = false;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnCancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnAction_Click(object sender, EventArgs e) {
        try {
            this.ProcessAction();
            this.DialogResult = DialogResult.OK;
        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <exception cref="Exception"></exception>
    private void ProcessAction() {
        switch (this.CurrentAction) {
            case ViewActionsEnum.Creation:
                this.UpdateUserInstanceFromControls(this.CurrentInstance);
                this.CurrentInstance = this.parentApp.UserService.CreateNewUser(this.CurrentInstance);
                break;
            case ViewActionsEnum.Edition:
                this.UpdateUserInstanceFromControls(this.CurrentInstance);
                this.CurrentInstance = this.parentApp.UserService.UpdateUser(this.CurrentInstance);
                break;
            case ViewActionsEnum.Deletion:
                this.CurrentInstance = this.parentApp.UserService.DeleteUser(this.CurrentInstance);
                break;
            case ViewActionsEnum.Visualization:
                break;
            default:
                throw new Exception($"Action [{Enum.GetName<ViewActionsEnum>(this.CurrentAction)}] non reconnue.");
        }
    }
}
