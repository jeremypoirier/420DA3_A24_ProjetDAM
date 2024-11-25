namespace _420DA3_A24_Projet.Presentation.Views;

partial class RoleView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.topBarPanel = new Panel();
        this.modeFenetreValue = new Label();
        this.modeFenetreLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.buttonAction = new Button();
        this.buttonCancel = new Button();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.centerTblLayoutPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.descriptionValue = new TextBox();
        this.descriptionLabel = new Label();
        this.nameValue = new TextBox();
        this.nameLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.centerTblLayoutPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.modeFenetreValue);
        this.topBarPanel.Controls.Add(this.modeFenetreLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(800, 50);
        this.topBarPanel.TabIndex = 1;
        // 
        // modeFenetreValue
        // 
        this.modeFenetreValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.modeFenetreValue.Location = new Point(103, 9);
        this.modeFenetreValue.Name = "modeFenetreValue";
        this.modeFenetreValue.Size = new Size(192, 20);
        this.modeFenetreValue.TabIndex = 1;
        this.modeFenetreValue.Text = "PLACEHOLDER";
        this.modeFenetreValue.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // modeFenetreLabel
        // 
        this.modeFenetreLabel.Location = new Point(12, 9);
        this.modeFenetreLabel.Name = "modeFenetreLabel";
        this.modeFenetreLabel.Size = new Size(85, 20);
        this.modeFenetreLabel.TabIndex = 0;
        this.modeFenetreLabel.Text = "Mode fenêtre :";
        this.modeFenetreLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.buttonAction);
        this.bottomBarPanel.Controls.Add(this.buttonCancel);
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 341);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(800, 50);
        this.bottomBarPanel.TabIndex = 2;
        // 
        // buttonAction
        // 
        this.buttonAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonAction.Location = new Point(585, 15);
        this.buttonAction.Name = "buttonAction";
        this.buttonAction.Size = new Size(122, 23);
        this.buttonAction.TabIndex = 3;
        this.buttonAction.Text = "ACTION";
        this.buttonAction.UseVisualStyleBackColor = true;
        this.buttonAction.Click += this.ButtonAction_Click;
        // 
        // buttonCancel
        // 
        this.buttonCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonCancel.Location = new Point(713, 15);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(75, 23);
        this.buttonCancel.TabIndex = 2;
        this.buttonCancel.Text = "Annuler";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += this.ButtonCancel_Click;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(1185, -35);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(122, 23);
        this.btnAction.TabIndex = 1;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(1313, -35);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(75, 23);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // centerTblLayoutPanel
        // 
        this.centerTblLayoutPanel.ColumnCount = 3;
        this.centerTblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.centerTblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTblLayoutPanel.Controls.Add(this.centerPanel, 1, 0);
        this.centerTblLayoutPanel.Dock = DockStyle.Fill;
        this.centerTblLayoutPanel.Location = new Point(0, 50);
        this.centerTblLayoutPanel.Name = "centerTblLayoutPanel";
        this.centerTblLayoutPanel.RowCount = 1;
        this.centerTblLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTblLayoutPanel.Size = new Size(800, 291);
        this.centerTblLayoutPanel.TabIndex = 3;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.descriptionValue);
        this.centerPanel.Controls.Add(this.descriptionLabel);
        this.centerPanel.Controls.Add(this.nameValue);
        this.centerPanel.Controls.Add(this.nameLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(203, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(394, 285);
        this.centerPanel.TabIndex = 0;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(189, 250);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(202, 23);
        this.dateDeletedValue.TabIndex = 31;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(189, 217);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(202, 23);
        this.dateModifiedValue.TabIndex = 30;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(189, 184);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(202, 23);
        this.dateCreatedValue.TabIndex = 29;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(3, 250);
        this.dateDeletedLabel.Margin = new Padding(3, 10, 3, 0);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(180, 23);
        this.dateDeletedLabel.TabIndex = 28;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(3, 217);
        this.dateModifiedLabel.Margin = new Padding(3, 10, 3, 0);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(180, 23);
        this.dateModifiedLabel.TabIndex = 27;
        this.dateModifiedLabel.Text = "Date de dernière modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(3, 184);
        this.dateCreatedLabel.Margin = new Padding(3, 10, 3, 0);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(180, 23);
        this.dateCreatedLabel.TabIndex = 26;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // descriptionValue
        // 
        this.descriptionValue.Location = new Point(189, 83);
        this.descriptionValue.Multiline = true;
        this.descriptionValue.Name = "descriptionValue";
        this.descriptionValue.PlaceholderText = "Description";
        this.descriptionValue.Size = new Size(202, 95);
        this.descriptionValue.TabIndex = 23;
        // 
        // descriptionLabel
        // 
        this.descriptionLabel.Location = new Point(3, 82);
        this.descriptionLabel.Margin = new Padding(3, 10, 3, 0);
        this.descriptionLabel.Name = "descriptionLabel";
        this.descriptionLabel.Size = new Size(180, 23);
        this.descriptionLabel.TabIndex = 22;
        this.descriptionLabel.Text = "Description du rôle :";
        this.descriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nameValue
        // 
        this.nameValue.Location = new Point(189, 50);
        this.nameValue.Name = "nameValue";
        this.nameValue.PlaceholderText = "Nom d'utilisateur";
        this.nameValue.Size = new Size(202, 23);
        this.nameValue.TabIndex = 19;
        // 
        // nameLabel
        // 
        this.nameLabel.Location = new Point(3, 49);
        this.nameLabel.Margin = new Padding(3, 10, 3, 0);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new Size(180, 23);
        this.nameLabel.TabIndex = 18;
        this.nameLabel.Text = "Nom du rôle :";
        this.nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(189, 18);
        this.idValue.Maximum = new decimal(new int[] { -1539607552, 11, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(202, 23);
        this.idValue.TabIndex = 17;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(3, 16);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(180, 23);
        this.idLabel.TabIndex = 16;
        this.idLabel.Text = "ID :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // RoleView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 391);
        this.Controls.Add(this.centerTblLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.MinimumSize = new Size(450, 430);
        this.Name = "RoleView";
        this.Text = "RoleView";
        this.topBarPanel.ResumeLayout(false);
        this.bottomBarPanel.ResumeLayout(false);
        this.centerTblLayoutPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Label modeFenetreValue;
    private Label modeFenetreLabel;
    private Panel bottomBarPanel;
    private Button btnAction;
    private Button btnCancel;
    private TableLayoutPanel centerTblLayoutPanel;
    private Button buttonAction;
    private Button buttonCancel;
    private Panel centerPanel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private TextBox descriptionValue;
    private Label descriptionLabel;
    private TextBox nameValue;
    private Label nameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
}