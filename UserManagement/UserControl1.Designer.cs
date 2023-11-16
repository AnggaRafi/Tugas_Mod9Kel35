namespace UserManagement
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernameComponent = new Label();
            EditButtonUser = new Button();
            DeleteButtonUser = new Button();
            SuspendLayout();
            // 
            // UsernameComponent
            // 
            UsernameComponent.AutoSize = true;
            UsernameComponent.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameComponent.Location = new Point(54, 38);
            UsernameComponent.Name = "UsernameComponent";
            UsernameComponent.Size = new Size(55, 24);
            UsernameComponent.TabIndex = 0;
            UsernameComponent.Text = "label1";
            // 
            // EditButtonUser
            // 
            EditButtonUser.Location = new Point(30, 94);
            EditButtonUser.Margin = new Padding(3, 4, 3, 4);
            EditButtonUser.Name = "EditButtonUser";
            EditButtonUser.Size = new Size(107, 31);
            EditButtonUser.TabIndex = 1;
            EditButtonUser.Text = "Edit User";
            EditButtonUser.UseVisualStyleBackColor = true;
            EditButtonUser.Click += EditButtonUser_Click;
            // 
            // DeleteButtonUser
            // 
            DeleteButtonUser.Location = new Point(30, 149);
            DeleteButtonUser.Margin = new Padding(3, 4, 3, 4);
            DeleteButtonUser.Name = "DeleteButtonUser";
            DeleteButtonUser.Size = new Size(107, 31);
            DeleteButtonUser.TabIndex = 2;
            DeleteButtonUser.Text = "Delete User";
            DeleteButtonUser.UseVisualStyleBackColor = true;
            DeleteButtonUser.Click += DeleteButtonUser_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(DeleteButtonUser);
            Controls.Add(EditButtonUser);
            Controls.Add(UsernameComponent);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControl1";
            Size = new Size(171, 200);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameComponent;
        private Button EditButtonUser;
        private Button DeleteButtonUser;
    }
}
