namespace Client
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_session = new MaterialSkin.Controls.MaterialButton();
            this.txt_nw_password_re = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_change_password = new MaterialSkin.Controls.MaterialButton();
            this.txt_nw_password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_cr_password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Firstname = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Lastname = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_change_name = new MaterialSkin.Controls.MaterialButton();
            this.btn_gen_profile = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_gen_profile);
            this.materialCard1.Controls.Add(this.btn_session);
            this.materialCard1.Controls.Add(this.txt_nw_password_re);
            this.materialCard1.Controls.Add(this.btn_change_password);
            this.materialCard1.Controls.Add(this.txt_nw_password);
            this.materialCard1.Controls.Add(this.txt_cr_password);
            this.materialCard1.Controls.Add(this.txt_Firstname);
            this.materialCard1.Controls.Add(this.txt_Lastname);
            this.materialCard1.Controls.Add(this.btn_change_name);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(607, 450);
            this.materialCard1.TabIndex = 0;
            // 
            // btn_session
            // 
            this.btn_session.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_session.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_session.Depth = 0;
            this.btn_session.HighEmphasis = true;
            this.btn_session.Icon = null;
            this.btn_session.Location = new System.Drawing.Point(18, 399);
            this.btn_session.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_session.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_session.Name = "btn_session";
            this.btn_session.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_session.Size = new System.Drawing.Size(111, 36);
            this.btn_session.TabIndex = 7;
            this.btn_session.Text = "See Session ";
            this.btn_session.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_session.UseAccentColor = false;
            this.btn_session.UseVisualStyleBackColor = true;
            this.btn_session.Click += new System.EventHandler(this.btn_session_Click);
            // 
            // txt_nw_password_re
            // 
            this.txt_nw_password_re.AnimateReadOnly = false;
            this.txt_nw_password_re.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nw_password_re.Depth = 0;
            this.txt_nw_password_re.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nw_password_re.Hint = "New Password re";
            this.txt_nw_password_re.LeadingIcon = null;
            this.txt_nw_password_re.Location = new System.Drawing.Point(235, 260);
            this.txt_nw_password_re.MaxLength = 50;
            this.txt_nw_password_re.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nw_password_re.Multiline = false;
            this.txt_nw_password_re.Name = "txt_nw_password_re";
            this.txt_nw_password_re.Password = true;
            this.txt_nw_password_re.Size = new System.Drawing.Size(211, 50);
            this.txt_nw_password_re.TabIndex = 6;
            this.txt_nw_password_re.Text = "";
            this.txt_nw_password_re.TrailingIcon = null;
            // 
            // btn_change_password
            // 
            this.btn_change_password.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_change_password.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_change_password.Depth = 0;
            this.btn_change_password.HighEmphasis = true;
            this.btn_change_password.Icon = null;
            this.btn_change_password.Location = new System.Drawing.Point(18, 319);
            this.btn_change_password.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_change_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_change_password.Size = new System.Drawing.Size(163, 36);
            this.btn_change_password.TabIndex = 5;
            this.btn_change_password.Text = "Change Password";
            this.btn_change_password.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_change_password.UseAccentColor = false;
            this.btn_change_password.UseVisualStyleBackColor = true;
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            // 
            // txt_nw_password
            // 
            this.txt_nw_password.AnimateReadOnly = false;
            this.txt_nw_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nw_password.Depth = 0;
            this.txt_nw_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nw_password.Hint = "New Password";
            this.txt_nw_password.LeadingIcon = null;
            this.txt_nw_password.Location = new System.Drawing.Point(18, 260);
            this.txt_nw_password.MaxLength = 50;
            this.txt_nw_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nw_password.Multiline = false;
            this.txt_nw_password.Name = "txt_nw_password";
            this.txt_nw_password.Password = true;
            this.txt_nw_password.Size = new System.Drawing.Size(211, 50);
            this.txt_nw_password.TabIndex = 4;
            this.txt_nw_password.Text = "";
            this.txt_nw_password.TrailingIcon = null;
            // 
            // txt_cr_password
            // 
            this.txt_cr_password.AnimateReadOnly = false;
            this.txt_cr_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cr_password.Depth = 0;
            this.txt_cr_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cr_password.Hint = "Current Password";
            this.txt_cr_password.LeadingIcon = null;
            this.txt_cr_password.Location = new System.Drawing.Point(18, 204);
            this.txt_cr_password.MaxLength = 50;
            this.txt_cr_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_cr_password.Multiline = false;
            this.txt_cr_password.Name = "txt_cr_password";
            this.txt_cr_password.Password = true;
            this.txt_cr_password.Size = new System.Drawing.Size(211, 50);
            this.txt_cr_password.TabIndex = 3;
            this.txt_cr_password.Text = "";
            this.txt_cr_password.TrailingIcon = null;
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.AnimateReadOnly = false;
            this.txt_Firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Firstname.Depth = 0;
            this.txt_Firstname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Firstname.Hint = "Firstname";
            this.txt_Firstname.LeadingIcon = null;
            this.txt_Firstname.Location = new System.Drawing.Point(18, 17);
            this.txt_Firstname.MaxLength = 50;
            this.txt_Firstname.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Firstname.Multiline = false;
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(211, 50);
            this.txt_Firstname.TabIndex = 2;
            this.txt_Firstname.Text = "";
            this.txt_Firstname.TrailingIcon = null;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.AnimateReadOnly = false;
            this.txt_Lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Lastname.Depth = 0;
            this.txt_Lastname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Lastname.Hint = "Lastname";
            this.txt_Lastname.LeadingIcon = null;
            this.txt_Lastname.Location = new System.Drawing.Point(18, 73);
            this.txt_Lastname.MaxLength = 50;
            this.txt_Lastname.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Lastname.Multiline = false;
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(211, 50);
            this.txt_Lastname.TabIndex = 1;
            this.txt_Lastname.Text = "";
            this.txt_Lastname.TrailingIcon = null;
            // 
            // btn_change_name
            // 
            this.btn_change_name.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_change_name.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_change_name.Depth = 0;
            this.btn_change_name.HighEmphasis = true;
            this.btn_change_name.Icon = null;
            this.btn_change_name.Location = new System.Drawing.Point(18, 132);
            this.btn_change_name.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_change_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_change_name.Name = "btn_change_name";
            this.btn_change_name.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_change_name.Size = new System.Drawing.Size(125, 36);
            this.btn_change_name.TabIndex = 0;
            this.btn_change_name.Text = "Change Name";
            this.btn_change_name.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_change_name.UseAccentColor = false;
            this.btn_change_name.UseVisualStyleBackColor = true;
            this.btn_change_name.Click += new System.EventHandler(this.btn_change_name_Click);
            // 
            // btn_gen_profile
            // 
            this.btn_gen_profile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_gen_profile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_gen_profile.Depth = 0;
            this.btn_gen_profile.HighEmphasis = true;
            this.btn_gen_profile.Icon = null;
            this.btn_gen_profile.Location = new System.Drawing.Point(137, 399);
            this.btn_gen_profile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_gen_profile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_gen_profile.Name = "btn_gen_profile";
            this.btn_gen_profile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_gen_profile.Size = new System.Drawing.Size(189, 36);
            this.btn_gen_profile.TabIndex = 8;
            this.btn_gen_profile.Text = "Generate VPN Profile";
            this.btn_gen_profile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_gen_profile.UseAccentColor = false;
            this.btn_gen_profile.UseVisualStyleBackColor = true;
            this.btn_gen_profile.Click += new System.EventHandler(this.btn_gen_profile_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txt_Firstname;
        private MaterialSkin.Controls.MaterialTextBox txt_Lastname;
        private MaterialSkin.Controls.MaterialButton btn_change_name;
        private MaterialSkin.Controls.MaterialTextBox txt_cr_password;
        private MaterialSkin.Controls.MaterialTextBox txt_nw_password;
        private MaterialSkin.Controls.MaterialButton btn_change_password;
        private MaterialSkin.Controls.MaterialTextBox txt_nw_password_re;
        private MaterialSkin.Controls.MaterialButton btn_session;
        private MaterialSkin.Controls.MaterialButton btn_gen_profile;
    }
}