namespace ApplicationDB
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtCoefficient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tapSizes = new System.Windows.Forms.TabPage();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridSizes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDelU = new System.Windows.Forms.TextBox();
            this.btnDelU = new System.Windows.Forms.Button();
            this.btnaddUser = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDeleteIdRole = new System.Windows.Forms.TextBox();
            this.btnRoleDelete = new System.Windows.Forms.Button();
            this.dataGridRoles = new System.Windows.Forms.DataGridView();
            this.role_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab.SuspendLayout();
            this.tapSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSizes)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(236, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(106, 51);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 5;
            // 
            // txtCoefficient
            // 
            this.txtCoefficient.Location = new System.Drawing.Point(106, 77);
            this.txtCoefficient.Name = "txtCoefficient";
            this.txtCoefficient.Size = new System.Drawing.Size(100, 20);
            this.txtCoefficient.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Diameter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Coefficient";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tapSizes);
            this.tab.Controls.Add(this.tabUsers);
            this.tab.Controls.Add(this.tabRole);
            this.tab.Location = new System.Drawing.Point(12, 10);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(678, 219);
            this.tab.TabIndex = 13;
            // 
            // tapSizes
            // 
            this.tapSizes.BackColor = System.Drawing.Color.Silver;
            this.tapSizes.Controls.Add(this.txtDeleteId);
            this.tapSizes.Controls.Add(this.label4);
            this.tapSizes.Controls.Add(this.btnDelete);
            this.tapSizes.Controls.Add(this.dataGridSizes);
            this.tapSizes.Controls.Add(this.txtCoefficient);
            this.tapSizes.Controls.Add(this.txtName);
            this.tapSizes.Controls.Add(this.txtDiameter);
            this.tapSizes.Controls.Add(this.btnAdd);
            this.tapSizes.Controls.Add(this.label1);
            this.tapSizes.Controls.Add(this.label3);
            this.tapSizes.Controls.Add(this.label2);
            this.tapSizes.Location = new System.Drawing.Point(4, 22);
            this.tapSizes.Name = "tapSizes";
            this.tapSizes.Padding = new System.Windows.Forms.Padding(3);
            this.tapSizes.Size = new System.Drawing.Size(670, 193);
            this.tapSizes.TabIndex = 0;
            this.tapSizes.Text = "Sizes Table";
            this.tapSizes.Enter += new System.EventHandler(this.tapSizes_Enter);
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(407, 158);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(46, 20);
            this.txtDeleteId.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label4.Location = new System.Drawing.Point(380, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Id";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(459, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridSizes
            // 
            this.dataGridSizes.AllowUserToAddRows = false;
            this.dataGridSizes.AllowUserToDeleteRows = false;
            this.dataGridSizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NName,
            this.Diameter,
            this.Coefficient});
            this.dataGridSizes.Location = new System.Drawing.Point(261, 3);
            this.dataGridSizes.Name = "dataGridSizes";
            this.dataGridSizes.ReadOnly = true;
            this.dataGridSizes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSizes.Size = new System.Drawing.Size(298, 150);
            this.dataGridSizes.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // NName
            // 
            this.NName.HeaderText = "Name";
            this.NName.Name = "NName";
            this.NName.ReadOnly = true;
            this.NName.Width = 55;
            // 
            // Diameter
            // 
            this.Diameter.HeaderText = "Diameter";
            this.Diameter.Name = "Diameter";
            this.Diameter.ReadOnly = true;
            this.Diameter.Width = 75;
            // 
            // Coefficient
            // 
            this.Coefficient.HeaderText = "Coefficient";
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.ReadOnly = true;
            this.Coefficient.Width = 75;
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.Silver;
            this.tabUsers.Controls.Add(this.label15);
            this.tabUsers.Controls.Add(this.txtDelU);
            this.tabUsers.Controls.Add(this.btnDelU);
            this.tabUsers.Controls.Add(this.btnaddUser);
            this.tabUsers.Controls.Add(this.txtR);
            this.tabUsers.Controls.Add(this.label11);
            this.tabUsers.Controls.Add(this.txtS);
            this.tabUsers.Controls.Add(this.label12);
            this.tabUsers.Controls.Add(this.dataGridUsers);
            this.tabUsers.Controls.Add(this.txtA);
            this.tabUsers.Controls.Add(this.txtNum);
            this.tabUsers.Controls.Add(this.txtE);
            this.tabUsers.Controls.Add(this.label8);
            this.tabUsers.Controls.Add(this.label9);
            this.tabUsers.Controls.Add(this.label10);
            this.tabUsers.Controls.Add(this.txtN);
            this.tabUsers.Controls.Add(this.txtL);
            this.tabUsers.Controls.Add(this.txtP);
            this.tabUsers.Controls.Add(this.label5);
            this.tabUsers.Controls.Add(this.label6);
            this.tabUsers.Controls.Add(this.label7);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(670, 193);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Users Table";
            this.tabUsers.Enter += new System.EventHandler(this.tabUsers_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(240, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Id";
            // 
            // txtDelU
            // 
            this.txtDelU.Location = new System.Drawing.Point(266, 233);
            this.txtDelU.Name = "txtDelU";
            this.txtDelU.Size = new System.Drawing.Size(35, 20);
            this.txtDelU.TabIndex = 29;
            // 
            // btnDelU
            // 
            this.btnDelU.Location = new System.Drawing.Point(307, 233);
            this.btnDelU.Name = "btnDelU";
            this.btnDelU.Size = new System.Drawing.Size(100, 23);
            this.btnDelU.TabIndex = 28;
            this.btnDelU.Text = "Delete";
            this.btnDelU.UseVisualStyleBackColor = true;
            this.btnDelU.Click += new System.EventHandler(this.btnDelU_Click);
            // 
            // btnaddUser
            // 
            this.btnaddUser.Location = new System.Drawing.Point(307, 61);
            this.btnaddUser.Name = "btnaddUser";
            this.btnaddUser.Size = new System.Drawing.Size(100, 23);
            this.btnaddUser.TabIndex = 20;
            this.btnaddUser.Text = "Add";
            this.btnaddUser.UseVisualStyleBackColor = true;
            this.btnaddUser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(609, 6);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(546, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Role";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(266, 32);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 20);
            this.txtS.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(189, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Surname";
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._login,
            this._password,
            this._name,
            this._surname,
            this._number,
            this._email,
            this._address,
            this._role});
            this.dataGridUsers.Location = new System.Drawing.Point(31, 90);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersWidth = 20;
            this.dataGridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridUsers.Size = new System.Drawing.Size(651, 137);
            this.dataGridUsers.TabIndex = 22;
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellContentClick);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(609, 32);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 19;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(440, 3);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 16;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(440, 30);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(100, 20);
            this.txtE.TabIndex = 17;
            this.txtE.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(377, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(546, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(377, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Email";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(266, 6);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 12;
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(83, 6);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(100, 20);
            this.txtL.TabIndex = 10;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(83, 33);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(189, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // tabRole
            // 
            this.tabRole.BackColor = System.Drawing.Color.Silver;
            this.tabRole.Controls.Add(this.label14);
            this.tabRole.Controls.Add(this.txtDeleteIdRole);
            this.tabRole.Controls.Add(this.btnRoleDelete);
            this.tabRole.Controls.Add(this.dataGridRoles);
            this.tabRole.Controls.Add(this.txtRoleName);
            this.tabRole.Controls.Add(this.btnAddRole);
            this.tabRole.Controls.Add(this.label13);
            this.tabRole.Location = new System.Drawing.Point(4, 22);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRole.Size = new System.Drawing.Size(670, 193);
            this.tabRole.TabIndex = 2;
            this.tabRole.Text = "Roles Table";
            this.tabRole.Enter += new System.EventHandler(this.tabRole_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(209, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Id";
            // 
            // txtDeleteIdRole
            // 
            this.txtDeleteIdRole.Location = new System.Drawing.Point(235, 66);
            this.txtDeleteIdRole.Name = "txtDeleteIdRole";
            this.txtDeleteIdRole.Size = new System.Drawing.Size(55, 20);
            this.txtDeleteIdRole.TabIndex = 20;
            // 
            // btnRoleDelete
            // 
            this.btnRoleDelete.Location = new System.Drawing.Point(201, 92);
            this.btnRoleDelete.Name = "btnRoleDelete";
            this.btnRoleDelete.Size = new System.Drawing.Size(100, 23);
            this.btnRoleDelete.TabIndex = 19;
            this.btnRoleDelete.Text = "Delete";
            this.btnRoleDelete.UseVisualStyleBackColor = true;
            this.btnRoleDelete.Click += new System.EventHandler(this.btnRoleDelete_Click);
            // 
            // dataGridRoles
            // 
            this.dataGridRoles.AllowUserToAddRows = false;
            this.dataGridRoles.AllowUserToDeleteRows = false;
            this.dataGridRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.role_id,
            this.role_name});
            this.dataGridRoles.Location = new System.Drawing.Point(13, 57);
            this.dataGridRoles.Name = "dataGridRoles";
            this.dataGridRoles.ReadOnly = true;
            this.dataGridRoles.RowHeadersWidth = 20;
            this.dataGridRoles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridRoles.Size = new System.Drawing.Size(175, 107);
            this.dataGridRoles.TabIndex = 18;
            this.dataGridRoles.Enter += new System.EventHandler(this.dataGridRoles_Enter);
            // 
            // role_id
            // 
            this.role_id.HeaderText = "Id";
            this.role_id.Name = "role_id";
            this.role_id.ReadOnly = true;
            this.role_id.Width = 50;
            // 
            // role_name
            // 
            this.role_name.HeaderText = "Name";
            this.role_name.Name = "role_name";
            this.role_name.ReadOnly = true;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(61, 16);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(100, 20);
            this.txtRoleName.TabIndex = 11;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(201, 16);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(100, 23);
            this.btnAddRole.TabIndex = 17;
            this.btnAddRole.Text = "Add";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(10, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Name";
            // 
            // _id
            // 
            this._id.HeaderText = "Id";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Width = 50;
            // 
            // _login
            // 
            this._login.HeaderText = "Login";
            this._login.Name = "_login";
            this._login.ReadOnly = true;
            this._login.Width = 75;
            // 
            // _password
            // 
            this._password.HeaderText = "Password";
            this._password.Name = "_password";
            this._password.ReadOnly = true;
            // 
            // _name
            // 
            this._name.HeaderText = "Name";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            this._name.Width = 50;
            // 
            // _surname
            // 
            this._surname.HeaderText = "Surname";
            this._surname.Name = "_surname";
            this._surname.ReadOnly = true;
            this._surname.Width = 50;
            // 
            // _number
            // 
            this._number.HeaderText = "Number";
            this._number.Name = "_number";
            this._number.ReadOnly = true;
            // 
            // _email
            // 
            this._email.HeaderText = "Email";
            this._email.Name = "_email";
            this._email.ReadOnly = true;
            // 
            // _address
            // 
            this._address.HeaderText = "Address";
            this._address.Name = "_address";
            this._address.ReadOnly = true;
            this._address.Width = 50;
            // 
            // _role
            // 
            this._role.HeaderText = "Role";
            this._role.Name = "_role";
            this._role.ReadOnly = true;
            this._role.Width = 50;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 285);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.btnClose);
            this.Name = "mainForm";
            this.Text = "AppliationDB";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.Load += new System.EventHandler(this.mainForm_Load_1);
            this.tab.ResumeLayout(false);
            this.tapSizes.ResumeLayout(false);
            this.tapSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSizes)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.tabRole.ResumeLayout(false);
            this.tabRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtCoefficient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tapSizes;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.DataGridView dataGridSizes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefficient;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnaddUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDeleteIdRole;
        private System.Windows.Forms.Button btnRoleDelete;
        private System.Windows.Forms.DataGridView dataGridRoles;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDelU;
        private System.Windows.Forms.Button btnDelU;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _login;
        private System.Windows.Forms.DataGridViewTextBoxColumn _password;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn _number;
        private System.Windows.Forms.DataGridViewTextBoxColumn _email;
        private System.Windows.Forms.DataGridViewTextBoxColumn _address;
        private System.Windows.Forms.DataGridViewTextBoxColumn _role;
    }
}

