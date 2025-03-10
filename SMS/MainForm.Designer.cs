namespace SMS
{
    partial class MainForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.lcYearLevel = new DevExpress.XtraEditors.LabelControl();
            this.cbYearLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.deDateOfBirth = new DevExpress.XtraEditors.DateEdit();
            this.lcBirthDate = new DevExpress.XtraEditors.LabelControl();
            this.cbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lcGender = new DevExpress.XtraEditors.LabelControl();
            this.cbDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lcDepartment = new DevExpress.XtraEditors.LabelControl();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.lcNameExtension = new DevExpress.XtraEditors.LabelControl();
            this.teNameExtension = new DevExpress.XtraEditors.TextEdit();
            this.lcFirstName = new DevExpress.XtraEditors.LabelControl();
            this.lcMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.lcLastName = new DevExpress.XtraEditors.LabelControl();
            this.gcStudentInfo = new DevExpress.XtraGrid.GridControl();
            this.gvStudentData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbYearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNameExtension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.lcYearLevel);
            this.groupControl1.Controls.Add(this.cbYearLevel);
            this.groupControl1.Controls.Add(this.deDateOfBirth);
            this.groupControl1.Controls.Add(this.lcBirthDate);
            this.groupControl1.Controls.Add(this.cbGender);
            this.groupControl1.Controls.Add(this.lcGender);
            this.groupControl1.Controls.Add(this.cbDepartment);
            this.groupControl1.Controls.Add(this.lcDepartment);
            this.groupControl1.Controls.Add(this.teFirstName);
            this.groupControl1.Controls.Add(this.teMiddleName);
            this.groupControl1.Controls.Add(this.teLastName);
            this.groupControl1.Controls.Add(this.lcNameExtension);
            this.groupControl1.Controls.Add(this.teNameExtension);
            this.groupControl1.Controls.Add(this.lcFirstName);
            this.groupControl1.Controls.Add(this.lcMiddleName);
            this.groupControl1.Controls.Add(this.lcLastName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(644, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(200, 529);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnUpdate);
            this.groupControl2.Controls.Add(this.btnAdd);
            this.groupControl2.Controls.Add(this.btnRemove);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 367);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(196, 160);
            this.groupControl2.TabIndex = 37;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(105, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 46);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 46);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(5, 98);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(187, 29);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lcYearLevel
            // 
            this.lcYearLevel.Location = new System.Drawing.Point(7, 285);
            this.lcYearLevel.Name = "lcYearLevel";
            this.lcYearLevel.Size = new System.Drawing.Size(47, 13);
            this.lcYearLevel.TabIndex = 36;
            this.lcYearLevel.Text = "YearLevel";
            // 
            // cbYearLevel
            // 
            this.cbYearLevel.Location = new System.Drawing.Point(7, 304);
            this.cbYearLevel.Name = "cbYearLevel";
            this.cbYearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbYearLevel.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbYearLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbYearLevel.Size = new System.Drawing.Size(188, 20);
            this.cbYearLevel.TabIndex = 35;
            // 
            // deDateOfBirth
            // 
            this.deDateOfBirth.EditValue = null;
            this.deDateOfBirth.Location = new System.Drawing.Point(107, 213);
            this.deDateOfBirth.Name = "deDateOfBirth";
            this.deDateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateOfBirth.Properties.DisplayFormat.FormatString = "";
            this.deDateOfBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deDateOfBirth.Properties.EditFormat.FormatString = "";
            this.deDateOfBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deDateOfBirth.Properties.MaskSettings.Set("mask", "d");
            this.deDateOfBirth.Size = new System.Drawing.Size(88, 20);
            this.deDateOfBirth.TabIndex = 33;
            // 
            // lcBirthDate
            // 
            this.lcBirthDate.Location = new System.Drawing.Point(108, 194);
            this.lcBirthDate.Name = "lcBirthDate";
            this.lcBirthDate.Size = new System.Drawing.Size(48, 13);
            this.lcBirthDate.TabIndex = 34;
            this.lcBirthDate.Text = "Birth Date";
            // 
            // cbGender
            // 
            this.cbGender.Location = new System.Drawing.Point(7, 213);
            this.cbGender.Name = "cbGender";
            this.cbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGender.Properties.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbGender.Size = new System.Drawing.Size(88, 20);
            this.cbGender.TabIndex = 31;
            // 
            // lcGender
            // 
            this.lcGender.Location = new System.Drawing.Point(8, 194);
            this.lcGender.Name = "lcGender";
            this.lcGender.Size = new System.Drawing.Size(35, 13);
            this.lcGender.TabIndex = 32;
            this.lcGender.Text = "Gender";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Location = new System.Drawing.Point(7, 263);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDepartment.Properties.Items.AddRange(new object[] {
            "CCS",
            "AMS",
            "BSA",
            "SHRIM",
            "Nursing",
            "Midwifery",
            "RadTech",
            "Pharma"});
            this.cbDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbDepartment.Size = new System.Drawing.Size(188, 20);
            this.cbDepartment.TabIndex = 29;
            // 
            // lcDepartment
            // 
            this.lcDepartment.Location = new System.Drawing.Point(7, 244);
            this.lcDepartment.Name = "lcDepartment";
            this.lcDepartment.Size = new System.Drawing.Size(57, 13);
            this.lcDepartment.TabIndex = 30;
            this.lcDepartment.Text = "Department";
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(7, 30);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Size = new System.Drawing.Size(188, 20);
            this.teFirstName.TabIndex = 21;
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(7, 75);
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Size = new System.Drawing.Size(188, 20);
            this.teMiddleName.TabIndex = 22;
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(7, 120);
            this.teLastName.Name = "teLastName";
            this.teLastName.Size = new System.Drawing.Size(188, 20);
            this.teLastName.TabIndex = 23;
            // 
            // lcNameExtension
            // 
            this.lcNameExtension.Location = new System.Drawing.Point(8, 146);
            this.lcNameExtension.Name = "lcNameExtension";
            this.lcNameExtension.Size = new System.Drawing.Size(77, 13);
            this.lcNameExtension.TabIndex = 28;
            this.lcNameExtension.Text = "Name Extension";
            // 
            // teNameExtension
            // 
            this.teNameExtension.Location = new System.Drawing.Point(7, 165);
            this.teNameExtension.Name = "teNameExtension";
            this.teNameExtension.Size = new System.Drawing.Size(188, 20);
            this.teNameExtension.TabIndex = 27;
            // 
            // lcFirstName
            // 
            this.lcFirstName.Location = new System.Drawing.Point(7, 11);
            this.lcFirstName.Name = "lcFirstName";
            this.lcFirstName.Size = new System.Drawing.Size(51, 13);
            this.lcFirstName.TabIndex = 24;
            this.lcFirstName.Text = "First Name";
            // 
            // lcMiddleName
            // 
            this.lcMiddleName.Location = new System.Drawing.Point(7, 56);
            this.lcMiddleName.Name = "lcMiddleName";
            this.lcMiddleName.Size = new System.Drawing.Size(60, 13);
            this.lcMiddleName.TabIndex = 26;
            this.lcMiddleName.Text = "Middle Name";
            // 
            // lcLastName
            // 
            this.lcLastName.Location = new System.Drawing.Point(7, 101);
            this.lcLastName.Name = "lcLastName";
            this.lcLastName.Size = new System.Drawing.Size(50, 13);
            this.lcLastName.TabIndex = 25;
            this.lcLastName.Text = "Last Name";
            // 
            // gcStudentInfo
            // 
            this.gcStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStudentInfo.Location = new System.Drawing.Point(0, 0);
            this.gcStudentInfo.MainView = this.gvStudentData;
            this.gcStudentInfo.Name = "gcStudentInfo";
            this.gcStudentInfo.Size = new System.Drawing.Size(644, 529);
            this.gcStudentInfo.TabIndex = 1;
            this.gcStudentInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudentData});
            // 
            // gvStudentData
            // 
            this.gvStudentData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvStudentData.GridControl = this.gcStudentInfo;
            this.gvStudentData.Name = "gvStudentData";
            this.gvStudentData.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Student ID";
            this.gridColumn1.FieldName = "StudentID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "First Name";
            this.gridColumn2.FieldName = "FirstName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Middle Name";
            this.gridColumn3.FieldName = "MiddleName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Last Name";
            this.gridColumn4.FieldName = "LastName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Name Extension";
            this.gridColumn5.FieldName = "NameExtension";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Gender";
            this.gridColumn6.FieldName = "Gender";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Date of Birth";
            this.gridColumn7.FieldName = "DateOfBirth";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Department";
            this.gridColumn8.FieldName = "Department";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Year Level";
            this.gridColumn9.FieldName = "YearLevel";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 529);
            this.Controls.Add(this.gcStudentInfo);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbYearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNameExtension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lcYearLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cbYearLevel;
        private DevExpress.XtraEditors.DateEdit deDateOfBirth;
        private DevExpress.XtraEditors.LabelControl lcBirthDate;
        private DevExpress.XtraEditors.ComboBoxEdit cbGender;
        private DevExpress.XtraEditors.LabelControl lcGender;
        private DevExpress.XtraEditors.ComboBoxEdit cbDepartment;
        private DevExpress.XtraEditors.LabelControl lcDepartment;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.TextEdit teMiddleName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.LabelControl lcNameExtension;
        private DevExpress.XtraEditors.TextEdit teNameExtension;
        private DevExpress.XtraEditors.LabelControl lcFirstName;
        private DevExpress.XtraEditors.LabelControl lcMiddleName;
        private DevExpress.XtraEditors.LabelControl lcLastName;
        private DevExpress.XtraGrid.GridControl gcStudentInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
    }
}

