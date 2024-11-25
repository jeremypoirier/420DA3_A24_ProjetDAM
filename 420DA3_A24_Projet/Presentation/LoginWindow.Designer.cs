namespace _420DA3_A24_Projet.Presentation;

partial class LoginWindow {
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
        this.mainTableLayoutPanel = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.usernameTextBox = new TextBox();
        this.passwordTextBox = new TextBox();
        this.buttonConnection = new Button();
        this.buttonCancel = new Button();
        this.mainTableLayoutPanel.SuspendLayout();
        this.centerPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // mainTableLayoutPanel
        // 
        this.mainTableLayoutPanel.ColumnCount = 3;
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTableLayoutPanel.Controls.Add(this.centerPanel, 1, 0);
        this.mainTableLayoutPanel.Dock = DockStyle.Fill;
        this.mainTableLayoutPanel.Location = new Point(0, 0);
        this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        this.mainTableLayoutPanel.RowCount = 1;
        this.mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.mainTableLayoutPanel.Size = new Size(284, 261);
        this.mainTableLayoutPanel.TabIndex = 0;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.buttonCancel);
        this.centerPanel.Controls.Add(this.buttonConnection);
        this.centerPanel.Controls.Add(this.passwordTextBox);
        this.centerPanel.Controls.Add(this.usernameTextBox);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(45, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(194, 255);
        this.centerPanel.TabIndex = 0;
        // 
        // usernameTextBox
        // 
        this.usernameTextBox.Location = new Point(3, 57);
        this.usernameTextBox.Name = "usernameTextBox";
        this.usernameTextBox.PlaceholderText = "Nom d'utilisateur";
        this.usernameTextBox.Size = new Size(188, 23);
        this.usernameTextBox.TabIndex = 0;
        this.usernameTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // passwordTextBox
        // 
        this.passwordTextBox.Location = new Point(3, 86);
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.PlaceholderText = "Mot de passe";
        this.passwordTextBox.Size = new Size(188, 23);
        this.passwordTextBox.TabIndex = 1;
        this.passwordTextBox.TextAlign = HorizontalAlignment.Center;
        this.passwordTextBox.UseSystemPasswordChar = true;
        // 
        // buttonConnection
        // 
        this.buttonConnection.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonConnection.Location = new Point(3, 138);
        this.buttonConnection.Name = "buttonConnection";
        this.buttonConnection.Size = new Size(188, 37);
        this.buttonConnection.TabIndex = 2;
        this.buttonConnection.Text = "Connexion!";
        this.buttonConnection.UseVisualStyleBackColor = true;
        this.buttonConnection.Click += this.ButtonConnection_Click;
        // 
        // buttonCancel
        // 
        this.buttonCancel.Location = new Point(3, 181);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(188, 23);
        this.buttonCancel.TabIndex = 3;
        this.buttonCancel.Text = "Annuler";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += this.ButtonCancel_Click;
        // 
        // LoginWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(284, 261);
        this.Controls.Add(this.mainTableLayoutPanel);
        this.MinimumSize = new Size(250, 300);
        this.Name = "LoginWindow";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Connexion";
        this.mainTableLayoutPanel.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel mainTableLayoutPanel;
    private Panel centerPanel;
    private Button buttonConnection;
    private TextBox passwordTextBox;
    private TextBox usernameTextBox;
    private Button buttonCancel;
}