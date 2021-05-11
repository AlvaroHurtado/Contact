namespace Base_de_Datos
{
    partial class frmCoordinator
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
            this.pnlCoordinator = new MetroFramework.Controls.MetroPanel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.coordinatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.grdCoordinator = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCoordinator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoordinator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(677, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(521, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(354, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(187, 226);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlCoordinator
            // 
            this.pnlCoordinator.Controls.Add(this.txtEmail);
            this.pnlCoordinator.Controls.Add(this.lblEmail);
            this.pnlCoordinator.Controls.Add(this.btnSearch);
            this.pnlCoordinator.Controls.Add(this.txtCellNumber);
            this.pnlCoordinator.Controls.Add(this.txtLastName);
            this.pnlCoordinator.Controls.Add(this.txtFirstName);
            this.pnlCoordinator.Controls.Add(this.txtId);
            this.pnlCoordinator.Controls.Add(this.lblCellNumber);
            this.pnlCoordinator.Controls.Add(this.lblLastName);
            this.pnlCoordinator.Controls.Add(this.lblFirstName);
            this.pnlCoordinator.Controls.Add(this.lblId);
            this.pnlCoordinator.Controls.Add(this.pctPhoto);
            this.pnlCoordinator.HorizontalScrollbarBarColor = true;
            this.pnlCoordinator.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCoordinator.HorizontalScrollbarSize = 10;
            this.pnlCoordinator.Location = new System.Drawing.Point(23, 61);
            this.pnlCoordinator.Name = "pnlCoordinator";
            this.pnlCoordinator.Size = new System.Drawing.Size(754, 159);
            this.pnlCoordinator.TabIndex = 20;
            this.pnlCoordinator.VerticalScrollbarBarColor = true;
            this.pnlCoordinator.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCoordinator.VerticalScrollbarSize = 10;
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
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "Email", true));
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
            // coordinatorBindingSource
            // 
            this.coordinatorBindingSource.DataSource = typeof(Base_de_Datos.Entidades.Coordinator);
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
            this.txtCellNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "CellNumber", true));
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
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "LastName", true));
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
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "FirstName", true));
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
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "Id", true));
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
            this.lblLastName.AutoScrollMinSize = new System.Drawing.Size(60, 23);
            this.lblLastName.AutoSize = false;
            this.lblLastName.BackColor = System.Drawing.SystemColors.Window;
            this.lblLastName.Location = new System.Drawing.Point(124, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 23);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "LastName";
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
            // grdCoordinator
            // 
            this.grdCoordinator.AllowUserToResizeRows = false;
            this.grdCoordinator.AutoGenerateColumns = false;
            this.grdCoordinator.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCoordinator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCoordinator.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdCoordinator.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCoordinator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdCoordinator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCoordinator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.cellNumberDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.grdCoordinator.DataSource = this.coordinatorBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCoordinator.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdCoordinator.EnableHeadersVisualStyles = false;
            this.grdCoordinator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdCoordinator.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCoordinator.Location = new System.Drawing.Point(23, 275);
            this.grdCoordinator.Name = "grdCoordinator";
            this.grdCoordinator.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCoordinator.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdCoordinator.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdCoordinator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCoordinator.Size = new System.Drawing.Size(754, 150);
            this.grdCoordinator.TabIndex = 19;
            this.grdCoordinator.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCoordinator_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
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
            // frmCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlCoordinator);
            this.Controls.Add(this.grdCoordinator);
            this.Name = "frmCoordinator";
            this.Text = "Coordinator";
            this.pnlCoordinator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoordinator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroPanel pnlCoordinator;
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
        private MetroFramework.Controls.MetroGrid grdCoordinator;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource coordinatorBindingSource;
    }
}