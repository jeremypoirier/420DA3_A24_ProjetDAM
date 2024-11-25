using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class RoleView : Form {

    private readonly WsysApplication parentApp;

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    public Role CurrentInstance { get; private set; } = null!;
    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }

    public RoleView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="emptyUser"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Role emptyRole) {
        this.PreOpenSetup(ViewActionsEnum.Creation, emptyRole, "Création d'un rôle", "CRÉER");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Role role) {
        this.PreOpenSetup(ViewActionsEnum.Visualization, role, "Détails d'un rôle", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public DialogResult OpenForEdition(Role role) {
        this.PreOpenSetup(ViewActionsEnum.Edition, role, "Modification d'un rôle", "ENREGISTRER");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Role role) {
        this.PreOpenSetup(ViewActionsEnum.Deletion, role, "Suppression d'un rôle", "SUPPRIMER");
        return this.ShowDialog();
    }


    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="action"></param>
    /// <param name="instance"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(ViewActionsEnum action, Role instance, string windowTitle, string actionButtonText) {
        this.CurrentAction = action;
        this.CurrentInstance = instance;
        this.Text = windowTitle;
        this.modeFenetreValue.Text = action.ToString();
        this.btnAction.Text = actionButtonText;
        this.LoadDataInControls(instance);
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateEditableControls();
        } else {
            this.DeactivateEditableControls();
        }
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="role"></param>
    private void LoadDataInControls(Role role) {
        this.idValue.Value = role.Id;
        this.nameValue.Text = role.Name;
        this.descriptionValue.Text = role.Description;
        this.dateCreatedValue.Value = role.DateCreated;
        this.dateModifiedValue.Value = role.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = role.DateDeleted ?? DateTime.Now;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="role"></param>
    private void UpdateInstanceFromControls(Role role) {
        try {
            this.ValidateControlValues();
            role.Name = this.nameValue.Text.Trim();
            role.Description = this.descriptionValue.Text.Trim();

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
        if (this.nameValue.Text.Length > Role.NAME_MAX_LENGTH) {
            throw new Exception($"Le nom du rôle ne doit pas contenir plus de {Role.NAME_MAX_LENGTH} caractères.");
        }
        if (this.descriptionValue.Text.Length > Role.DESCRIPTION_MAX_LENGTH) {
            throw new Exception($"La description du rôle ne doit pas contenir plus {Role.DESCRIPTION_MAX_LENGTH} caractères.");
        }
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    private void ActivateEditableControls() {
        this.nameValue.Enabled = true;
        this.descriptionValue.Enabled = true;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    private void DeactivateEditableControls() {
        this.nameValue.Enabled = false;
        this.descriptionValue.Enabled = false;
    }


    private void ButtonCancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ButtonAction_Click(object sender, EventArgs e) {
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
                this.UpdateInstanceFromControls(this.CurrentInstance);
                this.CurrentInstance = this.parentApp.RoleService.Create(this.CurrentInstance);
                break;
            case ViewActionsEnum.Edition:
                this.UpdateInstanceFromControls(this.CurrentInstance);
                this.CurrentInstance = this.parentApp.RoleService.Update(this.CurrentInstance);
                break;
            case ViewActionsEnum.Deletion:
                this.CurrentInstance = this.parentApp.RoleService.Delete(this.CurrentInstance);
                break;
            case ViewActionsEnum.Visualization:
                break;
            default:
                throw new Exception($"Action [{Enum.GetName<ViewActionsEnum>(this.CurrentAction)}] non reconnue.");
        }
    }
}
