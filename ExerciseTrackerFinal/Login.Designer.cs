namespace ExerciseTracker
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            username = new Label();
            userTextBox = new TextBox();
            label2 = new Label();
            passwordTextBox = new TextBox();
            submitLogin = new Button();
            ErrorLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(username, 0, 1);
            tableLayoutPanel1.Controls.Add(userTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(submitLogin, 0, 5);
            tableLayoutPanel1.Controls.Add(ErrorLabel, 0, 6);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.9783974F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6578093F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5722609F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6578093F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5722609F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5722609F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9891987F));
            tableLayoutPanel1.Size = new Size(1338, 536);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 0);
            label1.Name = "label1";
            label1.Size = new Size(713, 117);
            label1.TabIndex = 0;
            label1.Text = "Exercise Tracker";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.None;
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(601, 125);
            username.Name = "username";
            username.Size = new Size(135, 45);
            username.TabIndex = 1;
            username.Text = "Usuario";
            // 
            // userTextBox
            // 
            userTextBox.Anchor = AnchorStyles.None;
            userTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTextBox.Location = new Point(357, 199);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(624, 37);
            userTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(575, 265);
            label2.Name = "label2";
            label2.Size = new Size(188, 45);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(343, 342);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(651, 31);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // submitLogin
            // 
            submitLogin.Anchor = AnchorStyles.None;
            submitLogin.Cursor = Cursors.Hand;
            submitLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitLogin.Location = new Point(476, 409);
            submitLogin.Name = "submitLogin";
            submitLogin.Size = new Size(385, 54);
            submitLogin.TabIndex = 5;
            submitLogin.Text = "Ingresar";
            submitLogin.UseVisualStyleBackColor = true;
            submitLogin.Click += submitLogin_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Anchor = AnchorStyles.None;
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(669, 489);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 32);
            ErrorLabel.TabIndex = 6;
            // 
            // Login
            // 
            ClientSize = new Size(1339, 530);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label username;
        private TextBox userTextBox;
        private Label label2;
        private TextBox passwordTextBox;
        private Button submitLogin;

        #endregion

        private Label ErrorLabel;
    }
}