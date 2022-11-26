namespace My_Contact
{
    partial class frmAddorEdite
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddorEdite));
            this.pn_addoredite = new System.Windows.Forms.Panel();
            this.lbladoredite = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.txtMobile = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnsubmit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtAddres = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtemail = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtfamily = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtname = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.picprof = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pn_addoredite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picprof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_addoredite
            // 
            this.pn_addoredite.BackColor = System.Drawing.Color.Black;
            this.pn_addoredite.Controls.Add(this.lbladoredite);
            this.pn_addoredite.Controls.Add(this.bunifuImageButton1);
            this.pn_addoredite.Location = new System.Drawing.Point(0, 0);
            this.pn_addoredite.Name = "pn_addoredite";
            this.pn_addoredite.Size = new System.Drawing.Size(670, 45);
            this.pn_addoredite.TabIndex = 0;
            // 
            // lbladoredite
            // 
            this.lbladoredite.AutoSize = true;
            this.lbladoredite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladoredite.Location = new System.Drawing.Point(36, 9);
            this.lbladoredite.Name = "lbladoredite";
            this.lbladoredite.Size = new System.Drawing.Size(53, 20);
            this.lbladoredite.TabIndex = 2;
            this.lbladoredite.Text = "label1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_addoredite;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarForeColor = System.Drawing.Color.Coral;
            this.dtPicker.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtPicker.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.dtPicker.CalendarTrailingForeColor = System.Drawing.Color.HotPink;
            this.dtPicker.Location = new System.Drawing.Point(333, 241);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(284, 22);
            this.dtPicker.TabIndex = 7;
            this.dtPicker.Value = new System.DateTime(1996, 10, 26, 18, 44, 0, 0);
            // 
            // txtMobile
            // 
            this.txtMobile.AcceptsReturn = false;
            this.txtMobile.AcceptsTab = false;
            this.txtMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMobile.BackColor = System.Drawing.Color.Transparent;
            this.txtMobile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMobile.BackgroundImage")));
            this.txtMobile.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtMobile.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtMobile.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtMobile.BorderColorIdle = System.Drawing.Color.Lime;
            this.txtMobile.BorderRadius = 25;
            this.txtMobile.BorderThickness = 2;
            this.txtMobile.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMobile.DefaultFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.DefaultText = "";
            this.txtMobile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.txtMobile.HideSelection = true;
            this.txtMobile.IconLeft = null;
            this.txtMobile.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtMobile.IconPadding = 10;
            this.txtMobile.IconRight = null;
            this.txtMobile.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtMobile.Location = new System.Drawing.Point(325, 187);
            this.txtMobile.MaxLength = 32767;
            this.txtMobile.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtMobile.Modified = false;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.ReadOnly = false;
            this.txtMobile.SelectedText = "";
            this.txtMobile.SelectionLength = 0;
            this.txtMobile.SelectionStart = 0;
            this.txtMobile.ShortcutsEnabled = true;
            this.txtMobile.Size = new System.Drawing.Size(309, 37);
            this.txtMobile.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMobile.TabIndex = 8;
            this.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMobile.TextMarginLeft = 5;
            this.txtMobile.TextPlaceholder = "Mobile";
            this.txtMobile.UseSystemPasswordChar = false;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnsubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsubmit.BackgroundImage")));
            this.btnsubmit.ButtonText = "Submit";
            this.btnsubmit.ButtonTextMarginLeft = 0;
            this.btnsubmit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnsubmit.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnsubmit.DisabledForecolor = System.Drawing.Color.White;
            this.btnsubmit.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnsubmit.IconPadding = 10;
            this.btnsubmit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnsubmit.IdleBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnsubmit.IdleBorderRadius = 1;
            this.btnsubmit.IdleBorderThickness = 0;
            this.btnsubmit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnsubmit.IdleIconLeftImage = null;
            this.btnsubmit.IdleIconRightImage = null;
            this.btnsubmit.Location = new System.Drawing.Point(21, 276);
            this.btnsubmit.Name = "btnsubmit";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnsubmit.onHoverState = stateProperties1;
            this.btnsubmit.Size = new System.Drawing.Size(210, 45);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtAddres
            // 
            this.txtAddres.AcceptsReturn = false;
            this.txtAddres.AcceptsTab = false;
            this.txtAddres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddres.BackColor = System.Drawing.Color.Transparent;
            this.txtAddres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAddres.BackgroundImage")));
            this.txtAddres.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtAddres.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAddres.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtAddres.BorderColorIdle = System.Drawing.Color.Lime;
            this.txtAddres.BorderRadius = 25;
            this.txtAddres.BorderThickness = 2;
            this.txtAddres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddres.DefaultFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddres.DefaultText = "";
            this.txtAddres.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.txtAddres.HideSelection = true;
            this.txtAddres.IconLeft = null;
            this.txtAddres.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddres.IconPadding = 10;
            this.txtAddres.IconRight = null;
            this.txtAddres.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddres.Location = new System.Drawing.Point(325, 332);
            this.txtAddres.MaxLength = 32767;
            this.txtAddres.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtAddres.Modified = false;
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.PasswordChar = '\0';
            this.txtAddres.ReadOnly = false;
            this.txtAddres.SelectedText = "";
            this.txtAddres.SelectionLength = 0;
            this.txtAddres.SelectionStart = 0;
            this.txtAddres.ShortcutsEnabled = true;
            this.txtAddres.Size = new System.Drawing.Size(309, 39);
            this.txtAddres.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAddres.TabIndex = 5;
            this.txtAddres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddres.TextMarginLeft = 5;
            this.txtAddres.TextPlaceholder = "Addres";
            this.txtAddres.UseSystemPasswordChar = false;
            // 
            // txtemail
            // 
            this.txtemail.AcceptsReturn = false;
            this.txtemail.AcceptsTab = false;
            this.txtemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtemail.BackColor = System.Drawing.Color.Transparent;
            this.txtemail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtemail.BackgroundImage")));
            this.txtemail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtemail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtemail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtemail.BorderColorIdle = System.Drawing.Color.Lime;
            this.txtemail.BorderRadius = 25;
            this.txtemail.BorderThickness = 2;
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtemail.DefaultFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.DefaultText = "";
            this.txtemail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.txtemail.HideSelection = true;
            this.txtemail.IconLeft = null;
            this.txtemail.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtemail.IconPadding = 10;
            this.txtemail.IconRight = null;
            this.txtemail.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtemail.Location = new System.Drawing.Point(325, 278);
            this.txtemail.MaxLength = 32767;
            this.txtemail.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtemail.Modified = false;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.ReadOnly = false;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(309, 37);
            this.txtemail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtemail.TabIndex = 4;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtemail.TextMarginLeft = 5;
            this.txtemail.TextPlaceholder = "Email";
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // txtfamily
            // 
            this.txtfamily.AcceptsReturn = false;
            this.txtfamily.AcceptsTab = false;
            this.txtfamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtfamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtfamily.BackColor = System.Drawing.Color.Transparent;
            this.txtfamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtfamily.BackgroundImage")));
            this.txtfamily.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtfamily.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtfamily.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtfamily.BorderColorIdle = System.Drawing.Color.Lime;
            this.txtfamily.BorderRadius = 25;
            this.txtfamily.BorderThickness = 2;
            this.txtfamily.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtfamily.DefaultFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfamily.DefaultText = "";
            this.txtfamily.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.txtfamily.HideSelection = true;
            this.txtfamily.IconLeft = null;
            this.txtfamily.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtfamily.IconPadding = 10;
            this.txtfamily.IconRight = null;
            this.txtfamily.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtfamily.Location = new System.Drawing.Point(325, 126);
            this.txtfamily.MaxLength = 32767;
            this.txtfamily.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtfamily.Modified = false;
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.PasswordChar = '\0';
            this.txtfamily.ReadOnly = false;
            this.txtfamily.SelectedText = "";
            this.txtfamily.SelectionLength = 0;
            this.txtfamily.SelectionStart = 0;
            this.txtfamily.ShortcutsEnabled = true;
            this.txtfamily.Size = new System.Drawing.Size(309, 44);
            this.txtfamily.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtfamily.TabIndex = 3;
            this.txtfamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfamily.TextMarginLeft = 5;
            this.txtfamily.TextPlaceholder = "Family";
            this.txtfamily.UseSystemPasswordChar = false;
            // 
            // txtname
            // 
            this.txtname.AcceptsReturn = false;
            this.txtname.AcceptsTab = false;
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtname.BackColor = System.Drawing.Color.Transparent;
            this.txtname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtname.BackgroundImage")));
            this.txtname.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtname.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtname.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtname.BorderRadius = 25;
            this.txtname.BorderThickness = 2;
            this.txtname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtname.DefaultFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.DefaultText = "";
            this.txtname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.txtname.HideSelection = true;
            this.txtname.IconLeft = null;
            this.txtname.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtname.IconPadding = 10;
            this.txtname.IconRight = null;
            this.txtname.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtname.Location = new System.Drawing.Point(325, 75);
            this.txtname.MaxLength = 32767;
            this.txtname.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtname.Modified = false;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ReadOnly = false;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(309, 42);
            this.txtname.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtname.TabIndex = 2;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtname.TextMarginLeft = 5;
            this.txtname.TextPlaceholder = "Name";
            this.txtname.UseSystemPasswordChar = false;
            // 
            // picprof
            // 
            this.picprof.AllowFocused = false;
            this.picprof.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picprof.BorderRadius = 83;
            this.picprof.Image = global::My_Contact.Properties.Resources._50d429ea5c9afe0ef9cb3c96f784bea4;
            this.picprof.IsCircle = true;
            this.picprof.Location = new System.Drawing.Point(40, 87);
            this.picprof.Name = "picprof";
            this.picprof.Size = new System.Drawing.Size(166, 166);
            this.picprof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picprof.TabIndex = 1;
            this.picprof.TabStop = false;
            this.picprof.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(623, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frmAddorEdite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(669, 407);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtAddres);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.picprof);
            this.Controls.Add(this.pn_addoredite);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddorEdite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmAddorEdite_Load);
            this.pn_addoredite.ResumeLayout(false);
            this.pn_addoredite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picprof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_addoredite;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lbladoredite;
        private Bunifu.UI.WinForms.BunifuPictureBox picprof;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtname;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtfamily;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtemail;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAddres;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnsubmit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtMobile;
    }
}