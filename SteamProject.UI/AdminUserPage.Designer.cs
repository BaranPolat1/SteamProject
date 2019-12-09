namespace SteamProject.UI
{
    partial class AdminUserPage
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnGetByDate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.mskdStartDate = new System.Windows.Forms.MaskedTextBox();
            this.mskdEndDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFindLastName = new System.Windows.Forms.TextBox();
            this.txtFindFirstName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtUpdateCountry = new System.Windows.Forms.TextBox();
            this.txtUpdateAdress = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.mskUpdateBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.mskUpdatePhone = new System.Windows.Forms.MaskedTextBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateUserName = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAddCountry = new System.Windows.Forms.TextBox();
            this.txtAddAdress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mskAddBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbAddRole = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.mskAddedPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddUserName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnGetByDate);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.mskdStartDate);
            this.groupBox7.Controls.Add(this.mskdEndDate);
            this.groupBox7.Location = new System.Drawing.Point(880, 324);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(308, 103);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "GetUser By Date";
            // 
            // btnGetByDate
            // 
            this.btnGetByDate.Location = new System.Drawing.Point(200, 56);
            this.btnGetByDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetByDate.Name = "btnGetByDate";
            this.btnGetByDate.Size = new System.Drawing.Size(100, 28);
            this.btnGetByDate.TabIndex = 2;
            this.btnGetByDate.Text = "Get";
            this.btnGetByDate.UseVisualStyleBackColor = true;
            this.btnGetByDate.Click += new System.EventHandler(this.btnGetByDate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Please type into dates";
            // 
            // mskdStartDate
            // 
            this.mskdStartDate.Location = new System.Drawing.Point(12, 59);
            this.mskdStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.mskdStartDate.Mask = "00/00/0000";
            this.mskdStartDate.Name = "mskdStartDate";
            this.mskdStartDate.Size = new System.Drawing.Size(81, 22);
            this.mskdStartDate.TabIndex = 0;
            this.mskdStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskdEndDate
            // 
            this.mskdEndDate.Location = new System.Drawing.Point(103, 59);
            this.mskdEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.mskdEndDate.Mask = "00/00/0000";
            this.mskdEndDate.Name = "mskdEndDate";
            this.mskdEndDate.Size = new System.Drawing.Size(81, 22);
            this.mskdEndDate.TabIndex = 0;
            this.mskdEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGetAll);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(1156, 17);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(308, 112);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Get All User";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(75, 69);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(132, 33);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(8, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(279, 60);
            this.label15.TabIndex = 0;
            this.label15.Text = "Please Cllick The Button For Access All User";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFind);
            this.groupBox5.Controls.Add(this.txtFindLastName);
            this.groupBox5.Controls.Add(this.txtFindFirstName);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(875, 135);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(267, 177);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Find A User";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(106, 132);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 28);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFindLastName
            // 
            this.txtFindLastName.Location = new System.Drawing.Point(87, 76);
            this.txtFindLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindLastName.Name = "txtFindLastName";
            this.txtFindLastName.Size = new System.Drawing.Size(157, 22);
            this.txtFindLastName.TabIndex = 3;
            // 
            // txtFindFirstName
            // 
            this.txtFindFirstName.Location = new System.Drawing.Point(87, 31);
            this.txtFindFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindFirstName.Name = "txtFindFirstName";
            this.txtFindFirstName.Size = new System.Drawing.Size(157, 22);
            this.txtFindFirstName.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(2, 81);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 17);
            this.label27.TabIndex = 2;
            this.label27.Text = "LastName:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "FirstName:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtDelete);
            this.groupBox4.Location = new System.Drawing.Point(875, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(267, 112);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete User";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(144, 47);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 53);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "ID:";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(59, 49);
            this.txtDelete.Margin = new System.Windows.Forms.Padding(4);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(76, 22);
            this.txtDelete.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txtUpdateCountry);
            this.groupBox3.Controls.Add(this.txtUpdateAdress);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.cmbUpdateRole);
            this.groupBox3.Controls.Add(this.mskUpdateBirthDate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtUpdatePassword);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.mskUpdatePhone);
            this.groupBox3.Controls.Add(this.txtUpdateEmail);
            this.groupBox3.Controls.Add(this.txtUpdateUserName);
            this.groupBox3.Controls.Add(this.txtUpdateLastName);
            this.groupBox3.Controls.Add(this.txtUpdateID);
            this.groupBox3.Controls.Add(this.txtUpdateFirstName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(445, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(424, 417);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "\"";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(89, 285);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 17);
            this.label25.TabIndex = 13;
            this.label25.Text = "Country:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(89, 260);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 17);
            this.label26.TabIndex = 14;
            this.label26.Text = "Adress:";
            // 
            // txtUpdateCountry
            // 
            this.txtUpdateCountry.Location = new System.Drawing.Point(156, 282);
            this.txtUpdateCountry.Name = "txtUpdateCountry";
            this.txtUpdateCountry.Size = new System.Drawing.Size(172, 22);
            this.txtUpdateCountry.TabIndex = 11;
            // 
            // txtUpdateAdress
            // 
            this.txtUpdateAdress.Location = new System.Drawing.Point(157, 252);
            this.txtUpdateAdress.Name = "txtUpdateAdress";
            this.txtUpdateAdress.Size = new System.Drawing.Size(172, 22);
            this.txtUpdateAdress.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(74, 229);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 17);
            this.label22.TabIndex = 8;
            this.label22.Text = "BirthDate:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(187, 370);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Location = new System.Drawing.Point(155, 311);
            this.cmbUpdateRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(173, 24);
            this.cmbUpdateRole.TabIndex = 3;
            // 
            // mskUpdateBirthDate
            // 
            this.mskUpdateBirthDate.Location = new System.Drawing.Point(157, 224);
            this.mskUpdateBirthDate.Mask = "00/00/0000";
            this.mskUpdateBirthDate.Name = "mskUpdateBirthDate";
            this.mskUpdateBirthDate.Size = new System.Drawing.Size(172, 22);
            this.mskUpdateBirthDate.TabIndex = 7;
            this.mskUpdateBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Choose a Role:";
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(157, 169);
            this.txtUpdatePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(172, 22);
            this.txtUpdatePassword.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(93, 197);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 17);
            this.label21.TabIndex = 6;
            this.label21.Text = "Phone:";
            // 
            // mskUpdatePhone
            // 
            this.mskUpdatePhone.Location = new System.Drawing.Point(157, 197);
            this.mskUpdatePhone.Mask = "(999) 000-0000";
            this.mskUpdatePhone.Name = "mskUpdatePhone";
            this.mskUpdatePhone.Size = new System.Drawing.Size(172, 22);
            this.mskUpdatePhone.TabIndex = 5;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(157, 142);
            this.txtUpdateEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(172, 22);
            this.txtUpdateEmail.TabIndex = 1;
            // 
            // txtUpdateUserName
            // 
            this.txtUpdateUserName.Location = new System.Drawing.Point(157, 107);
            this.txtUpdateUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateUserName.Name = "txtUpdateUserName";
            this.txtUpdateUserName.Size = new System.Drawing.Size(171, 22);
            this.txtUpdateUserName.TabIndex = 1;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(158, 74);
            this.txtUpdateLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(172, 22);
            this.txtUpdateLastName.TabIndex = 1;
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(157, 14);
            this.txtUpdateID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(174, 22);
            this.txtUpdateID.TabIndex = 1;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(158, 44);
            this.txtUpdateFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(175, 22);
            this.txtUpdateFirstName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "User Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(121, 13);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Last Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(1, 438);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1477, 225);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1460, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtAddCountry);
            this.groupBox1.Controls.Add(this.txtAddAdress);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.mskAddBirthDate);
            this.groupBox1.Controls.Add(this.cmbAddRole);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.mskAddedPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddPassword);
            this.groupBox1.Controls.Add(this.txtAddEmail);
            this.groupBox1.Controls.Add(this.txtAddUserName);
            this.groupBox1.Controls.Add(this.txtAddLastName);
            this.groupBox1.Controls.Add(this.txtAddFirstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(424, 422);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(72, 254);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 17);
            this.label24.TabIndex = 10;
            this.label24.Text = "Country:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(72, 229);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 17);
            this.label23.TabIndex = 10;
            this.label23.Text = "Adress:";
            // 
            // txtAddCountry
            // 
            this.txtAddCountry.Location = new System.Drawing.Point(142, 251);
            this.txtAddCountry.Name = "txtAddCountry";
            this.txtAddCountry.Size = new System.Drawing.Size(172, 22);
            this.txtAddCountry.TabIndex = 9;
            // 
            // txtAddAdress
            // 
            this.txtAddAdress.Location = new System.Drawing.Point(142, 223);
            this.txtAddAdress.Name = "txtAddAdress";
            this.txtAddAdress.Size = new System.Drawing.Size(172, 22);
            this.txtAddAdress.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 200);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 17);
            this.label20.TabIndex = 8;
            this.label20.Text = "BirthDate:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(175, 375);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mskAddBirthDate
            // 
            this.mskAddBirthDate.Location = new System.Drawing.Point(142, 195);
            this.mskAddBirthDate.Mask = "00/00/0000";
            this.mskAddBirthDate.Name = "mskAddBirthDate";
            this.mskAddBirthDate.Size = new System.Drawing.Size(172, 22);
            this.mskAddBirthDate.TabIndex = 7;
            this.mskAddBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbAddRole
            // 
            this.cmbAddRole.FormattingEnabled = true;
            this.cmbAddRole.Location = new System.Drawing.Point(142, 280);
            this.cmbAddRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAddRole.Name = "cmbAddRole";
            this.cmbAddRole.Size = new System.Drawing.Size(172, 24);
            this.cmbAddRole.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(74, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = "Phone:";
            // 
            // mskAddedPhone
            // 
            this.mskAddedPhone.Location = new System.Drawing.Point(142, 166);
            this.mskAddedPhone.Mask = "(999) 000-0000";
            this.mskAddedPhone.Name = "mskAddedPhone";
            this.mskAddedPhone.Size = new System.Drawing.Size(172, 22);
            this.mskAddedPhone.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Choose a Role:";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(142, 137);
            this.txtAddPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(172, 22);
            this.txtAddPassword.TabIndex = 1;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(144, 109);
            this.txtAddEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(170, 22);
            this.txtAddEmail.TabIndex = 1;
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Location = new System.Drawing.Point(142, 77);
            this.txtAddUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(172, 22);
            this.txtAddUserName.TabIndex = 1;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(144, 44);
            this.txtAddLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(170, 22);
            this.txtAddLastName.TabIndex = 1;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(142, 13);
            this.txtAddFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(172, 22);
            this.txtAddFirstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // AdminUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 663);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminUserPage";
            this.Text = "AdminUserPage";
            this.Load += new System.EventHandler(this.AdminUserPage_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnGetByDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mskdStartDate;
        private System.Windows.Forms.MaskedTextBox mskdEndDate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFindFirstName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdateUserName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAddRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddUserName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskAddedPhone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox mskAddBirthDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox mskUpdateBirthDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox mskUpdatePhone;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAddCountry;
        private System.Windows.Forms.TextBox txtAddAdress;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtUpdateCountry;
        private System.Windows.Forms.TextBox txtUpdateAdress;
        private System.Windows.Forms.TextBox txtFindLastName;
        private System.Windows.Forms.Label label27;
    }
}