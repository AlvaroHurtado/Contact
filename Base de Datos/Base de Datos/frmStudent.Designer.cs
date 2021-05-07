
namespace Base_de_Datos
{
    partial class frmStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdStudent = new MetroFramework.Controls.MetroGrid();
            this.pnlStudent = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtemail = new MetroFramework.Controls.MetroTextBox();
            this.txtcellNumber = new MetroFramework.Controls.MetroTextBox();
            this.lblemail = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lblcellNumber = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtphoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.lblphoneNumber = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtlastName = new MetroFramework.Controls.MetroTextBox();
            this.txtfirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblbirthdate = new MetroFramework.Controls.MetroLabel();
            this.lbllastName = new MetroFramework.Controls.MetroLabel();
            this.lblfirstName = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.bntAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.dttBirthdate = new MetroFramework.Controls.MetroDateTime();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
            this.pnlStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStudent
            // 
            this.grdStudent.AllowUserToResizeRows = false;
            this.grdStudent.AutoGenerateColumns = false;
            this.grdStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.FirstName,
            this.LastName,
            this.Birthday,
            this.PhoneNumber,
            this.CellNumber,
            this.Photo,
            this.Email});
            this.grdStudent.DataSource = this.studentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdStudent.EnableHeadersVisualStyles = false;
            this.grdStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdStudent.Location = new System.Drawing.Point(23, 279);
            this.grdStudent.Name = "grdStudent";
            this.grdStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudent.Size = new System.Drawing.Size(754, 148);
            this.grdStudent.TabIndex = 0;
            this.grdStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_CellClick);
            // 
            // pnlStudent
            // 
            this.pnlStudent.Controls.Add(this.dttBirthdate);
            this.pnlStudent.Controls.Add(this.btnSearch);
            this.pnlStudent.Controls.Add(this.txtemail);
            this.pnlStudent.Controls.Add(this.txtcellNumber);
            this.pnlStudent.Controls.Add(this.lblemail);
            this.pnlStudent.Controls.Add(this.lblcellNumber);
            this.pnlStudent.Controls.Add(this.txtphoneNumber);
            this.pnlStudent.Controls.Add(this.lblphoneNumber);
            this.pnlStudent.Controls.Add(this.txtlastName);
            this.pnlStudent.Controls.Add(this.txtfirstName);
            this.pnlStudent.Controls.Add(this.txtId);
            this.pnlStudent.Controls.Add(this.lblbirthdate);
            this.pnlStudent.Controls.Add(this.lbllastName);
            this.pnlStudent.Controls.Add(this.lblfirstName);
            this.pnlStudent.Controls.Add(this.lblId);
            this.pnlStudent.Controls.Add(this.pctPhoto);
            this.pnlStudent.HorizontalScrollbarBarColor = true;
            this.pnlStudent.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlStudent.HorizontalScrollbarSize = 10;
            this.pnlStudent.Location = new System.Drawing.Point(23, 63);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(754, 156);
            this.pnlStudent.TabIndex = 1;
            this.pnlStudent.VerticalScrollbarBarColor = true;
            this.pnlStudent.VerticalScrollbarHighlightOnWheel = false;
            this.pnlStudent.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtemail
            // 
            // 
            // 
            // 
            this.txtemail.CustomButton.Image = null;
            this.txtemail.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtemail.CustomButton.Name = "";
            this.txtemail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtemail.CustomButton.TabIndex = 1;
            this.txtemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtemail.CustomButton.UseSelectable = true;
            this.txtemail.CustomButton.Visible = false;
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "email", true));
            this.txtemail.Lines = new string[0];
            this.txtemail.Location = new System.Drawing.Point(519, 68);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(173, 23);
            this.txtemail.TabIndex = 17;
            this.txtemail.UseSelectable = true;
            this.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtcellNumber
            // 
            // 
            // 
            // 
            this.txtcellNumber.CustomButton.Image = null;
            this.txtcellNumber.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtcellNumber.CustomButton.Name = "";
            this.txtcellNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcellNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcellNumber.CustomButton.TabIndex = 1;
            this.txtcellNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcellNumber.CustomButton.UseSelectable = true;
            this.txtcellNumber.CustomButton.Visible = false;
            this.txtcellNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "cellNumber", true));
            this.txtcellNumber.Lines = new string[0];
            this.txtcellNumber.Location = new System.Drawing.Point(519, 34);
            this.txtcellNumber.MaxLength = 32767;
            this.txtcellNumber.Name = "txtcellNumber";
            this.txtcellNumber.PasswordChar = '\0';
            this.txtcellNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcellNumber.SelectedText = "";
            this.txtcellNumber.SelectionLength = 0;
            this.txtcellNumber.SelectionStart = 0;
            this.txtcellNumber.ShortcutsEnabled = true;
            this.txtcellNumber.Size = new System.Drawing.Size(173, 23);
            this.txtcellNumber.TabIndex = 16;
            this.txtcellNumber.UseSelectable = true;
            this.txtcellNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcellNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblemail
            // 
            this.lblemail.AutoScroll = true;
            this.lblemail.AutoScrollMinSize = new System.Drawing.Size(38, 23);
            this.lblemail.AutoSize = false;
            this.lblemail.BackColor = System.Drawing.SystemColors.Window;
            this.lblemail.Location = new System.Drawing.Point(408, 65);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(105, 23);
            this.lblemail.TabIndex = 14;
            this.lblemail.Text = "Email";
            // 
            // lblcellNumber
            // 
            this.lblcellNumber.AutoScroll = true;
            this.lblcellNumber.AutoScrollMinSize = new System.Drawing.Size(71, 23);
            this.lblcellNumber.AutoSize = false;
            this.lblcellNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblcellNumber.Location = new System.Drawing.Point(408, 34);
            this.lblcellNumber.Name = "lblcellNumber";
            this.lblcellNumber.Size = new System.Drawing.Size(105, 23);
            this.lblcellNumber.TabIndex = 13;
            this.lblcellNumber.Text = "Cell Number";
            // 
            // txtphoneNumber
            // 
            // 
            // 
            // 
            this.txtphoneNumber.CustomButton.Image = null;
            this.txtphoneNumber.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtphoneNumber.CustomButton.Name = "";
            this.txtphoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtphoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtphoneNumber.CustomButton.TabIndex = 1;
            this.txtphoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtphoneNumber.CustomButton.UseSelectable = true;
            this.txtphoneNumber.CustomButton.Visible = false;
            this.txtphoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "phoneNumber", true));
            this.txtphoneNumber.Lines = new string[0];
            this.txtphoneNumber.Location = new System.Drawing.Point(519, 3);
            this.txtphoneNumber.MaxLength = 32767;
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.PasswordChar = '\0';
            this.txtphoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtphoneNumber.SelectedText = "";
            this.txtphoneNumber.SelectionLength = 0;
            this.txtphoneNumber.SelectionStart = 0;
            this.txtphoneNumber.ShortcutsEnabled = true;
            this.txtphoneNumber.Size = new System.Drawing.Size(173, 23);
            this.txtphoneNumber.TabIndex = 12;
            this.txtphoneNumber.UseSelectable = true;
            this.txtphoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtphoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblphoneNumber
            // 
            this.lblphoneNumber.AutoScroll = true;
            this.lblphoneNumber.AutoScrollMinSize = new System.Drawing.Size(83, 23);
            this.lblphoneNumber.AutoSize = false;
            this.lblphoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblphoneNumber.Location = new System.Drawing.Point(408, 3);
            this.lblphoneNumber.Name = "lblphoneNumber";
            this.lblphoneNumber.Size = new System.Drawing.Size(105, 23);
            this.lblphoneNumber.TabIndex = 11;
            this.lblphoneNumber.Text = "Phone Number";
            // 
            // txtlastName
            // 
            // 
            // 
            // 
            this.txtlastName.CustomButton.Image = null;
            this.txtlastName.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtlastName.CustomButton.Name = "";
            this.txtlastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtlastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtlastName.CustomButton.TabIndex = 1;
            this.txtlastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtlastName.CustomButton.UseSelectable = true;
            this.txtlastName.CustomButton.Visible = false;
            this.txtlastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "lastName", true));
            this.txtlastName.Lines = new string[0];
            this.txtlastName.Location = new System.Drawing.Point(196, 65);
            this.txtlastName.MaxLength = 32767;
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.PasswordChar = '\0';
            this.txtlastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlastName.SelectedText = "";
            this.txtlastName.SelectionLength = 0;
            this.txtlastName.SelectionStart = 0;
            this.txtlastName.ShortcutsEnabled = true;
            this.txtlastName.Size = new System.Drawing.Size(173, 23);
            this.txtlastName.TabIndex = 9;
            this.txtlastName.UseSelectable = true;
            this.txtlastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtlastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtfirstName
            // 
            // 
            // 
            // 
            this.txtfirstName.CustomButton.Image = null;
            this.txtfirstName.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtfirstName.CustomButton.Name = "";
            this.txtfirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtfirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfirstName.CustomButton.TabIndex = 1;
            this.txtfirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfirstName.CustomButton.UseSelectable = true;
            this.txtfirstName.CustomButton.Visible = false;
            this.txtfirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "firstName", true));
            this.txtfirstName.Lines = new string[0];
            this.txtfirstName.Location = new System.Drawing.Point(196, 34);
            this.txtfirstName.MaxLength = 32767;
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.PasswordChar = '\0';
            this.txtfirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfirstName.SelectedText = "";
            this.txtfirstName.SelectionLength = 0;
            this.txtfirstName.SelectionStart = 0;
            this.txtfirstName.ShortcutsEnabled = true;
            this.txtfirstName.Size = new System.Drawing.Size(173, 23);
            this.txtfirstName.TabIndex = 8;
            this.txtfirstName.UseSelectable = true;
            this.txtfirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(196, 3);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(173, 23);
            this.txtId.TabIndex = 7;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(109, 97);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(63, 19);
            this.lblbirthdate.TabIndex = 6;
            this.lblbirthdate.Text = "Birthdate";
            // 
            // lbllastName
            // 
            this.lbllastName.AutoSize = true;
            this.lbllastName.Location = new System.Drawing.Point(109, 65);
            this.lbllastName.Name = "lbllastName";
            this.lbllastName.Size = new System.Drawing.Size(71, 19);
            this.lbllastName.TabIndex = 5;
            this.lbllastName.Text = "Last Name";
            // 
            // lblfirstName
            // 
            this.lblfirstName.AutoSize = true;
            this.lblfirstName.Location = new System.Drawing.Point(109, 34);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(73, 19);
            this.lblfirstName.TabIndex = 4;
            this.lblfirstName.Text = "First Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(109, 3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(3, 3);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(100, 113);
            this.pctPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPhoto.TabIndex = 2;
            this.pctPhoto.TabStop = false;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(26, 225);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(100, 23);
            this.bntAdd.TabIndex = 19;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseSelectable = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(190, 225);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(344, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(512, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(677, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dttBirthdate
            // 
            this.dttBirthdate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Birthday", true));
            this.dttBirthdate.Location = new System.Drawing.Point(196, 97);
            this.dttBirthdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dttBirthdate.Name = "dttBirthdate";
            this.dttBirthdate.Size = new System.Drawing.Size(199, 29);
            this.dttBirthdate.TabIndex = 19;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Base_de_Datos.Entidades.Student);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // CellNumber
            // 
            this.CellNumber.DataPropertyName = "CellNumber";
            this.CellNumber.HeaderText = "CellNumber";
            this.CellNumber.Name = "CellNumber";
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "Photo";
            this.Photo.Name = "Photo";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.pnlStudent);
            this.Controls.Add(this.grdStudent);
            this.Name = "frmStudent";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).EndInit();
            this.pnlStudent.ResumeLayout(false);
            this.pnlStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdStudent;
        private MetroFramework.Controls.MetroPanel pnlStudent;
        private System.Windows.Forms.PictureBox pctPhoto;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroTextBox txtlastName;
        private MetroFramework.Controls.MetroTextBox txtfirstName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblbirthdate;
        private MetroFramework.Controls.MetroLabel lbllastName;
        private MetroFramework.Controls.MetroLabel lblfirstName;
        private MetroFramework.Controls.MetroTextBox txtemail;
        private MetroFramework.Controls.MetroTextBox txtcellNumber;
        private MetroFramework.Drawing.Html.HtmlLabel lblemail;
        private MetroFramework.Drawing.Html.HtmlLabel lblcellNumber;
        private MetroFramework.Controls.MetroTextBox txtphoneNumber;
        private MetroFramework.Drawing.Html.HtmlLabel lblphoneNumber;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton bntAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroDateTime dttBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}