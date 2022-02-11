namespace DinartApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.RecapVentesButton = new FontAwesome.Sharp.IconButton();
            this.CommandesButton = new FontAwesome.Sharp.IconButton();
            this.ComptesButton = new FontAwesome.Sharp.IconButton();
            this.ChiffresVentesButton = new FontAwesome.Sharp.IconButton();
            this.InventaireButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.panelMenu.Controls.Add(this.RecapVentesButton);
            this.panelMenu.Controls.Add(this.CommandesButton);
            this.panelMenu.Controls.Add(this.ComptesButton);
            this.panelMenu.Controls.Add(this.ChiffresVentesButton);
            this.panelMenu.Controls.Add(this.InventaireButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // RecapVentesButton
            // 
            this.RecapVentesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RecapVentesButton.FlatAppearance.BorderSize = 0;
            this.RecapVentesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecapVentesButton.ForeColor = System.Drawing.Color.White;
            this.RecapVentesButton.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.RecapVentesButton.IconColor = System.Drawing.Color.White;
            this.RecapVentesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RecapVentesButton.IconSize = 32;
            this.RecapVentesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecapVentesButton.Location = new System.Drawing.Point(0, 380);
            this.RecapVentesButton.Name = "RecapVentesButton";
            this.RecapVentesButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RecapVentesButton.Size = new System.Drawing.Size(220, 60);
            this.RecapVentesButton.TabIndex = 4;
            this.RecapVentesButton.Text = "Récap Ventes";
            this.RecapVentesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecapVentesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RecapVentesButton.UseVisualStyleBackColor = true;
            this.RecapVentesButton.Click += new System.EventHandler(this.RecapVentesButton_Click);
            // 
            // CommandesButton
            // 
            this.CommandesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommandesButton.FlatAppearance.BorderSize = 0;
            this.CommandesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandesButton.ForeColor = System.Drawing.Color.White;
            this.CommandesButton.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.CommandesButton.IconColor = System.Drawing.Color.White;
            this.CommandesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CommandesButton.IconSize = 32;
            this.CommandesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommandesButton.Location = new System.Drawing.Point(0, 320);
            this.CommandesButton.Name = "CommandesButton";
            this.CommandesButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CommandesButton.Size = new System.Drawing.Size(220, 60);
            this.CommandesButton.TabIndex = 3;
            this.CommandesButton.Text = "Commandes";
            this.CommandesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommandesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CommandesButton.UseVisualStyleBackColor = true;
            this.CommandesButton.Click += new System.EventHandler(this.CommandesButton_Click);
            // 
            // ComptesButton
            // 
            this.ComptesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComptesButton.FlatAppearance.BorderSize = 0;
            this.ComptesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComptesButton.ForeColor = System.Drawing.Color.White;
            this.ComptesButton.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.ComptesButton.IconColor = System.Drawing.Color.White;
            this.ComptesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ComptesButton.IconSize = 32;
            this.ComptesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComptesButton.Location = new System.Drawing.Point(0, 260);
            this.ComptesButton.Name = "ComptesButton";
            this.ComptesButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ComptesButton.Size = new System.Drawing.Size(220, 60);
            this.ComptesButton.TabIndex = 2;
            this.ComptesButton.Text = "Comptes";
            this.ComptesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComptesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ComptesButton.UseVisualStyleBackColor = true;
            this.ComptesButton.Click += new System.EventHandler(this.ComptesButton_Click);
            // 
            // ChiffresVentesButton
            // 
            this.ChiffresVentesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChiffresVentesButton.FlatAppearance.BorderSize = 0;
            this.ChiffresVentesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChiffresVentesButton.ForeColor = System.Drawing.Color.White;
            this.ChiffresVentesButton.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.ChiffresVentesButton.IconColor = System.Drawing.Color.White;
            this.ChiffresVentesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChiffresVentesButton.IconSize = 32;
            this.ChiffresVentesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChiffresVentesButton.Location = new System.Drawing.Point(0, 200);
            this.ChiffresVentesButton.Name = "ChiffresVentesButton";
            this.ChiffresVentesButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ChiffresVentesButton.Size = new System.Drawing.Size(220, 60);
            this.ChiffresVentesButton.TabIndex = 1;
            this.ChiffresVentesButton.Text = "Chiffres Ventes";
            this.ChiffresVentesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChiffresVentesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChiffresVentesButton.UseVisualStyleBackColor = true;
            this.ChiffresVentesButton.Click += new System.EventHandler(this.ChiffresVentesButton_Click);
            // 
            // InventaireButton
            // 
            this.InventaireButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventaireButton.FlatAppearance.BorderSize = 0;
            this.InventaireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventaireButton.ForeColor = System.Drawing.Color.White;
            this.InventaireButton.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.InventaireButton.IconColor = System.Drawing.Color.White;
            this.InventaireButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InventaireButton.IconSize = 32;
            this.InventaireButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventaireButton.Location = new System.Drawing.Point(0, 140);
            this.InventaireButton.Name = "InventaireButton";
            this.InventaireButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.InventaireButton.Size = new System.Drawing.Size(220, 60);
            this.InventaireButton.TabIndex = 0;
            this.InventaireButton.Text = "Inventaire";
            this.InventaireButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventaireButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InventaireButton.UseVisualStyleBackColor = true;
            this.InventaireButton.Click += new System.EventHandler(this.InventaireButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.panelTitleBar.Controls.Add(this.iconMinimize);
            this.panelTitleBar.Controls.Add(this.iconMaximize);
            this.panelTitleBar.Controls.Add(this.iconClose);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(580, 75);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.iconMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(111)))), ((int)(((byte)(217)))));
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(111)))), ((int)(((byte)(217)))));
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.Location = new System.Drawing.Point(460, 12);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(32, 32);
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.iconMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(111)))), ((int)(((byte)(217)))));
            this.iconMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(111)))), ((int)(((byte)(217)))));
            this.iconMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximize.Location = new System.Drawing.Point(498, 12);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(32, 32);
            this.iconMaximize.TabIndex = 3;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.iconClose.ForeColor = System.Drawing.Color.IndianRed;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconClose.IconColor = System.Drawing.Color.IndianRed;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.Location = new System.Drawing.Point(536, 12);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(32, 32);
            this.iconClose.TabIndex = 2;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleChildForm.Location = new System.Drawing.Point(58, 38);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(46, 15);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Accueil";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(84)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 30);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(56)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(580, 9);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(580, 366);
            this.panelDesktop.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Menu";
            this.Text = "Dinart";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton RecapVentesButton;
        private FontAwesome.Sharp.IconButton CommandesButton;
        private FontAwesome.Sharp.IconButton ComptesButton;
        private FontAwesome.Sharp.IconButton ChiffresVentesButton;
        private FontAwesome.Sharp.IconButton InventaireButton;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelTitleBar;
        private Label labelTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconMinimize;
        private FontAwesome.Sharp.IconPictureBox iconMaximize;
        private FontAwesome.Sharp.IconPictureBox iconClose;
    }
}