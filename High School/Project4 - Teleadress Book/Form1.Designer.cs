namespace Zadanie_6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujKontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńKontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inforamcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.otwórzToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zapiszToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dodajToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.edytujToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.usuńToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderImię = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumertelefonu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajKontaktContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujKontaktContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńKontaktContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.dodajButton = new System.Windows.Forms.Button();
            this.edytujButton = new System.Windows.Forms.Button();
            this.usuńButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.kontaktToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.toolStripSeparator1,
            this.wyjścieToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.otwórzToolStripMenuItem.Text = "&Otwórz";
            this.otwórzToolStripMenuItem.ToolTipText = "Otwórz plik z dysku";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripButton_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Enabled = false;
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zapiszToolStripMenuItem.Text = "&Zapisz";
            this.zapiszToolStripMenuItem.ToolTipText = "Zapisz plik na dysku";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.wyjścieToolStripMenuItem.Text = "&Wyjście";
            this.wyjścieToolStripMenuItem.ToolTipText = "Zamknij plik";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKontaktToolStripMenuItem,
            this.edytujKontaktToolStripMenuItem,
            this.usuńKontaktToolStripMenuItem});
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kontaktToolStripMenuItem.Text = "&Kontakt";
            // 
            // dodajKontaktToolStripMenuItem
            // 
            this.dodajKontaktToolStripMenuItem.Name = "dodajKontaktToolStripMenuItem";
            this.dodajKontaktToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.dodajKontaktToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.dodajKontaktToolStripMenuItem.Text = "&Dodaj kontakt";
            this.dodajKontaktToolStripMenuItem.ToolTipText = "Dodaj kontakt";
            this.dodajKontaktToolStripMenuItem.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // edytujKontaktToolStripMenuItem
            // 
            this.edytujKontaktToolStripMenuItem.Enabled = false;
            this.edytujKontaktToolStripMenuItem.Name = "edytujKontaktToolStripMenuItem";
            this.edytujKontaktToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.edytujKontaktToolStripMenuItem.Text = "&Edytuj kontakt";
            this.edytujKontaktToolStripMenuItem.ToolTipText = "Edytuj kontakt";
            this.edytujKontaktToolStripMenuItem.Click += new System.EventHandler(this.edytujButton_Click);
            // 
            // usuńKontaktToolStripMenuItem
            // 
            this.usuńKontaktToolStripMenuItem.Enabled = false;
            this.usuńKontaktToolStripMenuItem.Name = "usuńKontaktToolStripMenuItem";
            this.usuńKontaktToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.usuńKontaktToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.usuńKontaktToolStripMenuItem.Text = "&Usuń kontakt";
            this.usuńKontaktToolStripMenuItem.ToolTipText = "Usuń kontakt";
            this.usuńKontaktToolStripMenuItem.Click += new System.EventHandler(this.usuńButton_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inforamcjeToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "&O programie";
            // 
            // inforamcjeToolStripMenuItem
            // 
            this.inforamcjeToolStripMenuItem.Name = "inforamcjeToolStripMenuItem";
            this.inforamcjeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.inforamcjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inforamcjeToolStripMenuItem.Text = "Inforamcje";
            this.inforamcjeToolStripMenuItem.ToolTipText = "Wyświetl informacje  o programie";
            this.inforamcjeToolStripMenuItem.Click += new System.EventHandler(this.inforamcjeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripButton,
            this.zapiszToolStripButton,
            this.toolStripSeparator2,
            this.dodajToolStripButton,
            this.edytujToolStripButton,
            this.usuńToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // otwórzToolStripButton
            // 
            this.otwórzToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otwórzToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("otwórzToolStripButton.Image")));
            this.otwórzToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otwórzToolStripButton.Name = "otwórzToolStripButton";
            this.otwórzToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.otwórzToolStripButton.Text = "toolStripButton1";
            this.otwórzToolStripButton.ToolTipText = "Otwórz plik z dysku";
            this.otwórzToolStripButton.Click += new System.EventHandler(this.otwórzToolStripButton_Click);
            // 
            // zapiszToolStripButton
            // 
            this.zapiszToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zapiszToolStripButton.Enabled = false;
            this.zapiszToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zapiszToolStripButton.Image")));
            this.zapiszToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zapiszToolStripButton.Name = "zapiszToolStripButton";
            this.zapiszToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zapiszToolStripButton.Text = "toolStripButton2";
            this.zapiszToolStripButton.ToolTipText = "Zapisz plik na dysku";
            this.zapiszToolStripButton.Click += new System.EventHandler(this.zapiszToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dodajToolStripButton
            // 
            this.dodajToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dodajToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("dodajToolStripButton.Image")));
            this.dodajToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dodajToolStripButton.Name = "dodajToolStripButton";
            this.dodajToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.dodajToolStripButton.Text = "toolStripButton3";
            this.dodajToolStripButton.ToolTipText = "Dodaj kontakt";
            this.dodajToolStripButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // edytujToolStripButton
            // 
            this.edytujToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edytujToolStripButton.Enabled = false;
            this.edytujToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("edytujToolStripButton.Image")));
            this.edytujToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edytujToolStripButton.Name = "edytujToolStripButton";
            this.edytujToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.edytujToolStripButton.Text = "toolStripButton4";
            this.edytujToolStripButton.ToolTipText = "Edytuj kontakt";
            this.edytujToolStripButton.Click += new System.EventHandler(this.edytujButton_Click);
            // 
            // usuńToolStripButton
            // 
            this.usuńToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuńToolStripButton.Enabled = false;
            this.usuńToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("usuńToolStripButton.Image")));
            this.usuńToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usuńToolStripButton.Name = "usuńToolStripButton";
            this.usuńToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.usuńToolStripButton.Text = "toolStripButton5";
            this.usuńToolStripButton.ToolTipText = "Usuń kontakt";
            this.usuńToolStripButton.Click += new System.EventHandler(this.usuńButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderImię,
            this.columnHeaderNazwisko,
            this.columnHeaderAdres,
            this.columnHeaderNumertelefonu,
            this.columnHeaderEmail});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(8, 54);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 444);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.edytujButton_Click);
            // 
            // columnHeaderImię
            // 
            this.columnHeaderImię.Text = "Imię";
            this.columnHeaderImię.Width = 80;
            // 
            // columnHeaderNazwisko
            // 
            this.columnHeaderNazwisko.Text = "Nazwisko";
            this.columnHeaderNazwisko.Width = 100;
            // 
            // columnHeaderAdres
            // 
            this.columnHeaderAdres.Text = "Adres";
            this.columnHeaderAdres.Width = 180;
            // 
            // columnHeaderNumertelefonu
            // 
            this.columnHeaderNumertelefonu.Text = "Numer telefonu";
            this.columnHeaderNumertelefonu.Width = 90;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Adres e-mail";
            this.columnHeaderEmail.Width = 212;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKontaktContextMenuStrip,
            this.edytujKontaktContextMenuStrip,
            this.usuńKontaktContextMenuStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 70);
            // 
            // dodajKontaktContextMenuStrip
            // 
            this.dodajKontaktContextMenuStrip.Name = "dodajKontaktContextMenuStrip";
            this.dodajKontaktContextMenuStrip.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.dodajKontaktContextMenuStrip.Size = new System.Drawing.Size(170, 22);
            this.dodajKontaktContextMenuStrip.Text = "Dodaj kontakt";
            this.dodajKontaktContextMenuStrip.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // edytujKontaktContextMenuStrip
            // 
            this.edytujKontaktContextMenuStrip.Enabled = false;
            this.edytujKontaktContextMenuStrip.Name = "edytujKontaktContextMenuStrip";
            this.edytujKontaktContextMenuStrip.Size = new System.Drawing.Size(170, 22);
            this.edytujKontaktContextMenuStrip.Text = "Edytuj Kontakt";
            this.edytujKontaktContextMenuStrip.Click += new System.EventHandler(this.edytujButton_Click);
            // 
            // usuńKontaktContextMenuStrip
            // 
            this.usuńKontaktContextMenuStrip.Enabled = false;
            this.usuńKontaktContextMenuStrip.Name = "usuńKontaktContextMenuStrip";
            this.usuńKontaktContextMenuStrip.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.usuńKontaktContextMenuStrip.Size = new System.Drawing.Size(170, 22);
            this.usuńKontaktContextMenuStrip.Text = "Usuń kontakt";
            this.usuńKontaktContextMenuStrip.Click += new System.EventHandler(this.usuńButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Rekord: ";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(23, 17);
            this.status.Text = "?/0";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(684, 187);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(100, 30);
            this.dodajButton.TabIndex = 40;
            this.dodajButton.Text = "&Dodaj kontakt";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // edytujButton
            // 
            this.edytujButton.Enabled = false;
            this.edytujButton.Location = new System.Drawing.Point(684, 237);
            this.edytujButton.Name = "edytujButton";
            this.edytujButton.Size = new System.Drawing.Size(100, 30);
            this.edytujButton.TabIndex = 41;
            this.edytujButton.Text = "&Edytuj kontakt";
            this.edytujButton.UseVisualStyleBackColor = true;
            this.edytujButton.Click += new System.EventHandler(this.edytujButton_Click);
            // 
            // usuńButton
            // 
            this.usuńButton.Enabled = false;
            this.usuńButton.Location = new System.Drawing.Point(684, 287);
            this.usuńButton.Name = "usuńButton";
            this.usuńButton.Size = new System.Drawing.Size(100, 30);
            this.usuńButton.TabIndex = 42;
            this.usuńButton.Text = "&Usuń kontakt";
            this.usuńButton.UseVisualStyleBackColor = true;
            this.usuńButton.Click += new System.EventHandler(this.usuńButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 523);
            this.Controls.Add(this.usuńButton);
            this.Controls.Add(this.edytujButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza teleadresowa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKontaktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujKontaktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńKontaktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inforamcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton otwórzToolStripButton;
        private System.Windows.Forms.ToolStripButton zapiszToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton dodajToolStripButton;
        private System.Windows.Forms.ToolStripButton edytujToolStripButton;
        private System.Windows.Forms.ToolStripButton usuńToolStripButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader columnHeaderImię;
        private System.Windows.Forms.ColumnHeader columnHeaderNazwisko;
        private System.Windows.Forms.ColumnHeader columnHeaderAdres;
        private System.Windows.Forms.ColumnHeader columnHeaderNumertelefonu;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button edytujButton;
        private System.Windows.Forms.Button usuńButton;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajKontaktContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem edytujKontaktContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem usuńKontaktContextMenuStrip;
    }
}

