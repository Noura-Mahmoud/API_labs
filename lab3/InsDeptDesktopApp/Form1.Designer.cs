namespace InsDeptDesktopApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.insPage = new System.Windows.Forms.TabPage();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.btnUpdateIns = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNameIns = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.btnNewIns = new System.Windows.Forms.Button();
            this.dataGridViewInstructors = new System.Windows.Forms.DataGridView();
            this.deptPage = new System.Windows.Forms.TabPage();
            this.btnUpdateDept = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBranches = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtNameDept = new System.Windows.Forms.TextBox();
            this.btnNewDept = new System.Windows.Forms.Button();
            this.dataGridViewDepts = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.dataGridViewFoundIns = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.insPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructors)).BeginInit();
            this.deptPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepts)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoundIns)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.insPage);
            this.tabControl1.Controls.Add(this.deptPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // insPage
            // 
            this.insPage.Controls.Add(this.comboBoxDept);
            this.insPage.Controls.Add(this.label10);
            this.insPage.Controls.Add(this.txtBirthdate);
            this.insPage.Controls.Add(this.btnUpdateIns);
            this.insPage.Controls.Add(this.label9);
            this.insPage.Controls.Add(this.label8);
            this.insPage.Controls.Add(this.label6);
            this.insPage.Controls.Add(this.txtAddress);
            this.insPage.Controls.Add(this.txtPhone);
            this.insPage.Controls.Add(this.label7);
            this.insPage.Controls.Add(this.label5);
            this.insPage.Controls.Add(this.label4);
            this.insPage.Controls.Add(this.label3);
            this.insPage.Controls.Add(this.label2);
            this.insPage.Controls.Add(this.label1);
            this.insPage.Controls.Add(this.txtSalary);
            this.insPage.Controls.Add(this.txtPassword);
            this.insPage.Controls.Add(this.txtEmail);
            this.insPage.Controls.Add(this.txtAge);
            this.insPage.Controls.Add(this.txtNameIns);
            this.insPage.Controls.Add(this.txtSSN);
            this.insPage.Controls.Add(this.btnNewIns);
            this.insPage.Controls.Add(this.dataGridViewInstructors);
            this.insPage.Location = new System.Drawing.Point(4, 25);
            this.insPage.Name = "insPage";
            this.insPage.Padding = new System.Windows.Forms.Padding(3);
            this.insPage.Size = new System.Drawing.Size(790, 422);
            this.insPage.TabIndex = 0;
            this.insPage.Text = "Instructors";
            this.insPage.UseVisualStyleBackColor = true;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(424, 68);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(100, 22);
            this.txtBirthdate.TabIndex = 7;
            // 
            // btnUpdateIns
            // 
            this.btnUpdateIns.Location = new System.Drawing.Point(681, 101);
            this.btnUpdateIns.Name = "btnUpdateIns";
            this.btnUpdateIns.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateIns.TabIndex = 11;
            this.btnUpdateIns.Text = "Update";
            this.btnUpdateIns.UseVisualStyleBackColor = true;
            this.btnUpdateIns.Click += new System.EventHandler(this.btnUpdateIns_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "BirthDate";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(424, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(424, 24);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Salary";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "SSN";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(247, 68);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(247, 108);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 5;
            // 
            // txtNameIns
            // 
            this.txtNameIns.Location = new System.Drawing.Point(247, 26);
            this.txtNameIns.Name = "txtNameIns";
            this.txtNameIns.Size = new System.Drawing.Size(100, 22);
            this.txtNameIns.TabIndex = 3;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(86, 26);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 22);
            this.txtSSN.TabIndex = 0;
            // 
            // btnNewIns
            // 
            this.btnNewIns.Location = new System.Drawing.Point(681, 25);
            this.btnNewIns.Name = "btnNewIns";
            this.btnNewIns.Size = new System.Drawing.Size(75, 23);
            this.btnNewIns.TabIndex = 10;
            this.btnNewIns.Text = "New";
            this.btnNewIns.UseVisualStyleBackColor = true;
            this.btnNewIns.Click += new System.EventHandler(this.btnNewIns_Click);
            // 
            // dataGridViewInstructors
            // 
            this.dataGridViewInstructors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstructors.Location = new System.Drawing.Point(3, 141);
            this.dataGridViewInstructors.Name = "dataGridViewInstructors";
            this.dataGridViewInstructors.RowHeadersWidth = 51;
            this.dataGridViewInstructors.RowTemplate.Height = 24;
            this.dataGridViewInstructors.Size = new System.Drawing.Size(784, 280);
            this.dataGridViewInstructors.TabIndex = 1;
            this.dataGridViewInstructors.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewInstructors_RowHeaderMouseDoubleClick);
            // 
            // deptPage
            // 
            this.deptPage.Controls.Add(this.btnUpdateDept);
            this.deptPage.Controls.Add(this.label14);
            this.deptPage.Controls.Add(this.label16);
            this.deptPage.Controls.Add(this.label17);
            this.deptPage.Controls.Add(this.label18);
            this.deptPage.Controls.Add(this.txtDescription);
            this.deptPage.Controls.Add(this.txtBranches);
            this.deptPage.Controls.Add(this.txtLocation);
            this.deptPage.Controls.Add(this.txtNameDept);
            this.deptPage.Controls.Add(this.btnNewDept);
            this.deptPage.Controls.Add(this.dataGridViewDepts);
            this.deptPage.Location = new System.Drawing.Point(4, 25);
            this.deptPage.Name = "deptPage";
            this.deptPage.Padding = new System.Windows.Forms.Padding(3);
            this.deptPage.Size = new System.Drawing.Size(790, 422);
            this.deptPage.TabIndex = 2;
            this.deptPage.Text = "Departments";
            this.deptPage.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDept
            // 
            this.btnUpdateDept.Location = new System.Drawing.Point(554, 87);
            this.btnUpdateDept.Name = "btnUpdateDept";
            this.btnUpdateDept.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDept.TabIndex = 27;
            this.btnUpdateDept.Text = "Update";
            this.btnUpdateDept.UseVisualStyleBackColor = true;
            this.btnUpdateDept.Click += new System.EventHandler(this.btnUpdateDept_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Description";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Branches";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(267, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Location";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(67, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(144, 89);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 7;
            // 
            // txtBranches
            // 
            this.txtBranches.Location = new System.Drawing.Point(339, 89);
            this.txtBranches.Name = "txtBranches";
            this.txtBranches.Size = new System.Drawing.Size(100, 22);
            this.txtBranches.TabIndex = 5;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(339, 41);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 4;
            // 
            // txtNameDept
            // 
            this.txtNameDept.Location = new System.Drawing.Point(144, 41);
            this.txtNameDept.Name = "txtNameDept";
            this.txtNameDept.Size = new System.Drawing.Size(100, 22);
            this.txtNameDept.TabIndex = 3;
            // 
            // btnNewDept
            // 
            this.btnNewDept.Location = new System.Drawing.Point(554, 40);
            this.btnNewDept.Name = "btnNewDept";
            this.btnNewDept.Size = new System.Drawing.Size(75, 23);
            this.btnNewDept.TabIndex = 2;
            this.btnNewDept.Text = "New";
            this.btnNewDept.UseVisualStyleBackColor = true;
            this.btnNewDept.Click += new System.EventHandler(this.btnNewDept_Click);
            // 
            // dataGridViewDepts
            // 
            this.dataGridViewDepts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepts.Location = new System.Drawing.Point(3, 141);
            this.dataGridViewDepts.Name = "dataGridViewDepts";
            this.dataGridViewDepts.RowHeadersWidth = 51;
            this.dataGridViewDepts.RowTemplate.Height = 24;
            this.dataGridViewDepts.Size = new System.Drawing.Size(784, 280);
            this.dataGridViewDepts.TabIndex = 1;
            this.dataGridViewDepts.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDepts_RowHeaderMouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewFoundIns);
            this.tabPage1.Controls.Add(this.txtSearchId);
            this.tabPage1.Controls.Add(this.btnSearchID);
            this.tabPage1.Controls.Add(this.txtSearchName);
            this.tabPage1.Controls.Add(this.btnSearchName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 422);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Search Instructor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(391, 121);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(160, 33);
            this.btnSearchName.TabIndex = 0;
            this.btnSearchName.Text = "Search by name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(241, 128);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 22);
            this.txtSearchName.TabIndex = 1;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(241, 64);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(100, 22);
            this.txtSearchId.TabIndex = 3;
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(391, 60);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(160, 29);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.Text = "Search by ID";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // dataGridViewFoundIns
            // 
            this.dataGridViewFoundIns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFoundIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoundIns.Location = new System.Drawing.Point(72, 204);
            this.dataGridViewFoundIns.Name = "dataGridViewFoundIns";
            this.dataGridViewFoundIns.RowHeadersWidth = 51;
            this.dataGridViewFoundIns.RowTemplate.Height = 24;
            this.dataGridViewFoundIns.Size = new System.Drawing.Size(644, 150);
            this.dataGridViewFoundIns.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(544, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Department";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(547, 75);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(74, 24);
            this.comboBoxDept.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrucrutors and Departments";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.insPage.ResumeLayout(false);
            this.insPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructors)).EndInit();
            this.deptPage.ResumeLayout(false);
            this.deptPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepts)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoundIns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage insPage;
        private System.Windows.Forms.Button btnNewIns;
        private System.Windows.Forms.DataGridView dataGridViewInstructors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNameIns;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnUpdateIns;
        private System.Windows.Forms.TabPage deptPage;
        private System.Windows.Forms.Button btnUpdateDept;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBranches;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtNameDept;
        private System.Windows.Forms.Button btnNewDept;
        private System.Windows.Forms.DataGridView dataGridViewDepts;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.DataGridView dataGridViewFoundIns;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Label label10;
    }
}

