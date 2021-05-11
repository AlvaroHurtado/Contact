namespace Base_de_Datos
{
    partial class frmMajor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.pnlMajor = new MetroFramework.Controls.MetroPanel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtCellNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblCellNumber = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lblLastName = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lblFirstName = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lblId = new MetroFramework.Drawing.Html.HtmlLabel();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.grdMajor = new MetroFramework.Controls.MetroGrid();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.lblDescription = new MetroFramework.Drawing.Html.HtmlLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMajor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(677, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(521, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(354, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(187, 223);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlMajor
            // 
            this.pnlMajor.Controls.Add(this.lblDescription);
            this.pnlMajor.Controls.Add(this.txtDescription);
            this.pnlMajor.Controls.Add(this.txtEmail);
            this.pnlMajor.Controls.Add(this.lblEmail);
            this.pnlMajor.Controls.Add(this.btnSearch);
            this.pnlMajor.Controls.Add(this.txtCellNumber);
            this.pnlMajor.Controls.Add(this.txtLastName);
            this.pnlMajor.Controls.Add(this.txtFirstName);
            this.pnlMajor.Controls.Add(this.txtId);
            this.pnlMajor.Controls.Add(this.lblCellNumber);
            this.pnlMajor.Controls.Add(this.lblLastName);
            this.pnlMajor.Controls.Add(this.lblFirstName);
            this.pnlMajor.Controls.Add(this.lblId);
            this.pnlMajor.Controls.Add(this.pctPhoto);
            this.pnlMajor.HorizontalScrollbarBarColor = true;
            this.pnlMajor.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMajor.HorizontalScrollbarSize = 10;
            this.pnlMajor.Location = new System.Drawing.Point(23, 58);
            this.pnlMajor.Name = "pnlMajor";
            this.pnlMajor.Size = new System.Drawing.Size(754, 159);
            this.pnlMajor.TabIndex = 27;
            this.pnlMajor.VerticalScrollbarBarColor = true;
            this.pnlMajor.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMajor.VerticalScrollbarSize = 10;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "Email", true));
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(513, 3);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(172, 23);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoScroll = true;
            this.lblEmail.AutoScrollMinSize = new System.Drawing.Size(38, 23);
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmail.Location = new System.Drawing.Point(432, 3);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 23);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCellNumber
            // 
            // 
            // 
            // 
            this.txtCellNumber.CustomButton.Image = null;
            this.txtCellNumber.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtCellNumber.CustomButton.Name = "";
            this.txtCellNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCellNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCellNumber.CustomButton.TabIndex = 1;
            this.txtCellNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCellNumber.CustomButton.UseSelectable = true;
            this.txtCellNumber.CustomButton.Visible = false;
            this.txtCellNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "CellNumber", true));
            this.txtCellNumber.Lines = new string[0];
            this.txtCellNumber.Location = new System.Drawing.Point(217, 91);
            this.txtCellNumber.MaxLength = 32767;
            this.txtCellNumber.Name = "txtCellNumber";
            this.txtCellNumber.PasswordChar = '\0';
            this.txtCellNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCellNumber.SelectedText = "";
            this.txtCellNumber.SelectionLength = 0;
            this.txtCellNumber.SelectionStart = 0;
            this.txtCellNumber.ShortcutsEnabled = true;
            this.txtCellNumber.Size = new System.Drawing.Size(172, 23);
            this.txtCellNumber.TabIndex = 12;
            this.txtCellNumber.UseSelectable = true;
            this.txtCellNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCellNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "LastName", true));
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(217, 62);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(172, 23);
            this.txtLastName.TabIndex = 11;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "FirstName", true));
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(217, 32);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(172, 23);
            this.txtFirstName.TabIndex = 10;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(217, 3);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(172, 23);
            this.txtId.TabIndex = 9;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCellNumber
            // 
            this.lblCellNumber.AutoScroll = true;
            this.lblCellNumber.AutoScrollMinSize = new System.Drawing.Size(71, 23);
            this.lblCellNumber.AutoSize = false;
            this.lblCellNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblCellNumber.Location = new System.Drawing.Point(124, 91);
            this.lblCellNumber.Name = "lblCellNumber";
            this.lblCellNumber.Size = new System.Drawing.Size(75, 23);
            this.lblCellNumber.TabIndex = 8;
            this.lblCellNumber.Text = "Cell Number";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoScroll = true;
            this.lblLastName.AutoScrollMinSize = new System.Drawing.Size(63, 23);
            this.lblLastName.AutoSize = false;
            this.lblLastName.BackColor = System.Drawing.SystemColors.Window;
            this.lblLastName.Location = new System.Drawing.Point(124, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 23);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoScroll = true;
            this.lblFirstName.AutoScrollMinSize = new System.Drawing.Size(65, 23);
            this.lblFirstName.AutoSize = false;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFirstName.Location = new System.Drawing.Point(124, 32);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 23);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name";
            // 
            // lblId
            // 
            this.lblId.AutoScroll = true;
            this.lblId.AutoScrollMinSize = new System.Drawing.Size(19, 23);
            this.lblId.AutoSize = false;
            this.lblId.BackColor = System.Drawing.SystemColors.Window;
            this.lblId.Location = new System.Drawing.Point(124, 3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(75, 23);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id";
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(3, 3);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(100, 111);
            this.pctPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPhoto.TabIndex = 2;
            this.pctPhoto.TabStop = false;
            // 
            // grdMajor
            // 
            this.grdMajor.AllowUserToResizeRows = false;
            this.grdMajor.AutoGenerateColumns = false;
            this.grdMajor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMajor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdMajor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdMajor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMajor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMajor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMajor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.cellNumberDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.grdMajor.DataSource = this.majorBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMajor.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdMajor.EnableHeadersVisualStyles = false;
            this.grdMajor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdMajor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMajor.Location = new System.Drawing.Point(23, 272);
            this.grdMajor.Name = "grdMajor";
            this.grdMajor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMajor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdMajor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMajor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMajor.Size = new System.Drawing.Size(754, 150);
            this.grdMajor.TabIndex = 26;
            this.grdMajor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMajor_CellClick);
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataSource = typeof(Base_de_Datos.Entidades.Major);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "Description", true));
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(513, 32);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(172, 23);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoScroll = true;
            this.lblDescription.AutoScrollMinSize = new System.Drawing.Size(67, 23);
            this.lblDescription.AutoSize = false;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Window;
            this.lblDescription.Location = new System.Drawing.Point(432, 32);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 23);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // cellNumberDataGridViewTextBoxColumn
            // 
            this.cellNumberDataGridViewTextBoxColumn.DataPropertyName = "CellNumber";
            this.cellNumberDataGridViewTextBoxColumn.HeaderText = "CellNumber";
            this.cellNumberDataGridViewTextBoxColumn.Name = "cellNumberDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // frmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlMajor);
            this.Controls.Add(this.grdMajor);
            this.Name = "frmMajor";
            this.Text = "Major";
            this.pnlMajor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroPanel pnlMajor;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Drawing.Html.HtmlLabel lblEmail;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtCellNumber;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Drawing.Html.HtmlLabel lblCellNumber;
        private MetroFramework.Drawing.Html.HtmlLabel lblLastName;
        private MetroFramework.Drawing.Html.HtmlLabel lblFirstName;
        private MetroFramework.Drawing.Html.HtmlLabel lblId;
        private System.Windows.Forms.PictureBox pctPhoto;
        private MetroFramework.Controls.MetroGrid grdMajor;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private MetroFramework.Drawing.Html.HtmlLabel lblDescription;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}