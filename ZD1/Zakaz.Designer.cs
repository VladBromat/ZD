namespace ZD1
{
    partial class Zakaz
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGruz = new System.Windows.Forms.Button();
            this.btnRecipient = new System.Windows.Forms.Button();
            this.btnSender = new System.Windows.Forms.Button();
            this.cbVagon = new System.Windows.Forms.ComboBox();
            this.vagonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1 = new ZD1._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tbRecipient = new System.Windows.Forms.TextBox();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.Груз = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKodSenstr = new System.Windows.Forms.TextBox();
            this.tbKodStnSen = new System.Windows.Forms.TextBox();
            this.tbSenStr = new System.Windows.Forms.TextBox();
            this.tbStnSen = new System.Windows.Forms.TextBox();
            this.tbAddrSen = new System.Windows.Forms.TextBox();
            this.tbAddrRes = new System.Windows.Forms.TextBox();
            this.tbStnRes = new System.Windows.Forms.TextBox();
            this.tbStrRes = new System.Windows.Forms.TextBox();
            this.tbKodStnRes = new System.Windows.Forms.TextBox();
            this.tbKodStrRes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbVesTara = new System.Windows.Forms.TextBox();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.tbVesGruza = new System.Windows.Forms.TextBox();
            this.tbBrut = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbVid = new System.Windows.Forms.TextBox();
            this.tbGr = new System.Windows.Forms.TextBox();
            this.tbKodGr = new System.Windows.Forms.TextBox();
            this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet = new ZD1._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet();
            this.vagonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vagonTableAdapter = new ZD1._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSetTableAdapters.VagonTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRespPers = new System.Windows.Forms.TextBox();
            this.vagonTableAdapter1 = new ZD1._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1TableAdapters.VagonTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.vagonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagonBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(501, 399);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 39);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(657, 399);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(131, 39);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Создать заказ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGruz
            // 
            this.btnGruz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGruz.Location = new System.Drawing.Point(501, 61);
            this.btnGruz.Name = "btnGruz";
            this.btnGruz.Size = new System.Drawing.Size(151, 26);
            this.btnGruz.TabIndex = 4;
            this.btnGruz.Text = "Данные о грузе";
            this.btnGruz.UseVisualStyleBackColor = true;
            this.btnGruz.Click += new System.EventHandler(this.btnGruz_Click);
            // 
            // btnRecipient
            // 
            this.btnRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecipient.Location = new System.Drawing.Point(501, 148);
            this.btnRecipient.Name = "btnRecipient";
            this.btnRecipient.Size = new System.Drawing.Size(151, 26);
            this.btnRecipient.TabIndex = 5;
            this.btnRecipient.Text = "Данные о получателе";
            this.btnRecipient.UseVisualStyleBackColor = true;
            this.btnRecipient.Click += new System.EventHandler(this.btnRecipient_Click);
            // 
            // btnSender
            // 
            this.btnSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSender.Location = new System.Drawing.Point(501, 102);
            this.btnSender.Name = "btnSender";
            this.btnSender.Size = new System.Drawing.Size(151, 26);
            this.btnSender.TabIndex = 6;
            this.btnSender.Text = "Данные об отправителе";
            this.btnSender.UseVisualStyleBackColor = true;
            this.btnSender.Click += new System.EventHandler(this.btnSender_Click);
            // 
            // cbVagon
            // 
            this.cbVagon.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vagonBindingSource1, "VagonNumber", true));
            this.cbVagon.DataSource = this.vagonBindingSource1;
            this.cbVagon.DisplayMember = "VagonNumber";
            this.cbVagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVagon.FormattingEnabled = true;
            this.cbVagon.Location = new System.Drawing.Point(201, 282);
            this.cbVagon.Name = "cbVagon";
            this.cbVagon.Size = new System.Drawing.Size(235, 24);
            this.cbVagon.TabIndex = 7;
            this.cbVagon.ValueMember = "VagonNumber";
            // 
            // vagonBindingSource1
            // 
            this.vagonBindingSource1.DataMember = "Vagon";
            this.vagonBindingSource1.DataSource = this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1;
            // 
            // _C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1
            // 
            this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1.DataSetName = "_C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1";
            this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(201, 232);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // tbRecipient
            // 
            this.tbRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRecipient.Location = new System.Drawing.Point(201, 148);
            this.tbRecipient.Name = "tbRecipient";
            this.tbRecipient.Size = new System.Drawing.Size(235, 22);
            this.tbRecipient.TabIndex = 11;
            // 
            // tbSender
            // 
            this.tbSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSender.Location = new System.Drawing.Point(201, 102);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(235, 22);
            this.tbSender.TabIndex = 12;
            // 
            // tbStatus
            // 
            this.tbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStatus.Location = new System.Drawing.Point(201, 365);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(235, 22);
            this.tbStatus.TabIndex = 13;
            this.tbStatus.Text = "Новый";
            // 
            // Груз
            // 
            this.Груз.AutoSize = true;
            this.Груз.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Груз.Location = new System.Drawing.Point(25, 61);
            this.Груз.Name = "Груз";
            this.Груз.Size = new System.Drawing.Size(42, 20);
            this.Груз.TabIndex = 14;
            this.Груз.Text = "Груз";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Отправитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Получатель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дата получения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Вагон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Дата отправления";
            // 
            // tbKodSenstr
            // 
            this.tbKodSenstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKodSenstr.Location = new System.Drawing.Point(501, 251);
            this.tbKodSenstr.Name = "tbKodSenstr";
            this.tbKodSenstr.Size = new System.Drawing.Size(67, 22);
            this.tbKodSenstr.TabIndex = 22;
            // 
            // tbKodStnSen
            // 
            this.tbKodStnSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKodStnSen.Location = new System.Drawing.Point(501, 307);
            this.tbKodStnSen.Name = "tbKodStnSen";
            this.tbKodStnSen.Size = new System.Drawing.Size(67, 22);
            this.tbKodStnSen.TabIndex = 23;
            // 
            // tbSenStr
            // 
            this.tbSenStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSenStr.Location = new System.Drawing.Point(501, 279);
            this.tbSenStr.Name = "tbSenStr";
            this.tbSenStr.Size = new System.Drawing.Size(67, 22);
            this.tbSenStr.TabIndex = 24;
            // 
            // tbStnSen
            // 
            this.tbStnSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStnSen.Location = new System.Drawing.Point(501, 335);
            this.tbStnSen.Name = "tbStnSen";
            this.tbStnSen.Size = new System.Drawing.Size(67, 22);
            this.tbStnSen.TabIndex = 25;
            // 
            // tbAddrSen
            // 
            this.tbAddrSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddrSen.Location = new System.Drawing.Point(501, 363);
            this.tbAddrSen.Name = "tbAddrSen";
            this.tbAddrSen.Size = new System.Drawing.Size(67, 22);
            this.tbAddrSen.TabIndex = 26;
            // 
            // tbAddrRes
            // 
            this.tbAddrRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddrRes.Location = new System.Drawing.Point(585, 363);
            this.tbAddrRes.Name = "tbAddrRes";
            this.tbAddrRes.Size = new System.Drawing.Size(67, 22);
            this.tbAddrRes.TabIndex = 31;
            // 
            // tbStnRes
            // 
            this.tbStnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStnRes.Location = new System.Drawing.Point(585, 335);
            this.tbStnRes.Name = "tbStnRes";
            this.tbStnRes.Size = new System.Drawing.Size(67, 22);
            this.tbStnRes.TabIndex = 30;
            // 
            // tbStrRes
            // 
            this.tbStrRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStrRes.Location = new System.Drawing.Point(585, 279);
            this.tbStrRes.Name = "tbStrRes";
            this.tbStrRes.Size = new System.Drawing.Size(67, 22);
            this.tbStrRes.TabIndex = 29;
            // 
            // tbKodStnRes
            // 
            this.tbKodStnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKodStnRes.Location = new System.Drawing.Point(585, 307);
            this.tbKodStnRes.Name = "tbKodStnRes";
            this.tbKodStnRes.Size = new System.Drawing.Size(67, 22);
            this.tbKodStnRes.TabIndex = 28;
            // 
            // tbKodStrRes
            // 
            this.tbKodStrRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKodStrRes.Location = new System.Drawing.Point(585, 251);
            this.tbKodStrRes.Name = "tbKodStrRes";
            this.tbKodStrRes.Size = new System.Drawing.Size(67, 22);
            this.tbKodStrRes.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Отпр";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Заказчик";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Груз";
            // 
            // tbVesTara
            // 
            this.tbVesTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVesTara.Location = new System.Drawing.Point(724, 253);
            this.tbVesTara.Name = "tbVesTara";
            this.tbVesTara.Size = new System.Drawing.Size(61, 22);
            this.tbVesTara.TabIndex = 47;
            // 
            // tbSpec
            // 
            this.tbSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSpec.Location = new System.Drawing.Point(724, 281);
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.Size = new System.Drawing.Size(61, 22);
            this.tbSpec.TabIndex = 46;
            // 
            // tbVesGruza
            // 
            this.tbVesGruza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVesGruza.Location = new System.Drawing.Point(657, 363);
            this.tbVesGruza.Name = "tbVesGruza";
            this.tbVesGruza.Size = new System.Drawing.Size(61, 22);
            this.tbVesGruza.TabIndex = 45;
            // 
            // tbBrut
            // 
            this.tbBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBrut.Location = new System.Drawing.Point(657, 335);
            this.tbBrut.Name = "tbBrut";
            this.tbBrut.Size = new System.Drawing.Size(61, 22);
            this.tbBrut.TabIndex = 44;
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDesc.Location = new System.Drawing.Point(657, 309);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(61, 22);
            this.tbDesc.TabIndex = 43;
            // 
            // tbVid
            // 
            this.tbVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVid.Location = new System.Drawing.Point(657, 281);
            this.tbVid.Name = "tbVid";
            this.tbVid.Size = new System.Drawing.Size(61, 22);
            this.tbVid.TabIndex = 42;
            // 
            // tbGr
            // 
            this.tbGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGr.Location = new System.Drawing.Point(201, 61);
            this.tbGr.Name = "tbGr";
            this.tbGr.Size = new System.Drawing.Size(235, 22);
            this.tbGr.TabIndex = 41;
            // 
            // tbKodGr
            // 
            this.tbKodGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKodGr.Location = new System.Drawing.Point(657, 253);
            this.tbKodGr.Name = "tbKodGr";
            this.tbKodGr.Size = new System.Drawing.Size(61, 22);
            this.tbKodGr.TabIndex = 40;
            // 
            // _C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet
            // 
            this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet.DataSetName = "_C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet";
            this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vagonBindingSource
            // 
            this.vagonBindingSource.DataMember = "Vagon";
            this.vagonBindingSource.DataSource = this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet;
            // 
            // vagonTableAdapter
            // 
            this.vagonTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(25, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Ответственное лицо";
            // 
            // tbRespPers
            // 
            this.tbRespPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRespPers.Location = new System.Drawing.Point(201, 323);
            this.tbRespPers.Name = "tbRespPers";
            this.tbRespPers.Size = new System.Drawing.Size(235, 22);
            this.tbRespPers.TabIndex = 48;
            // 
            // vagonTableAdapter1
            // 
            this.vagonTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGruz);
            this.groupBox1.Controls.Add(this.btnSender);
            this.groupBox1.Controls.Add(this.btnRecipient);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать заказ";
            // 
            // Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbRespPers);
            this.Controls.Add(this.tbGr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Груз);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbSender);
            this.Controls.Add(this.tbRecipient);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbVagon);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbVesTara);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.tbVesGruza);
            this.Controls.Add(this.tbBrut);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbVid);
            this.Controls.Add(this.tbKodGr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAddrRes);
            this.Controls.Add(this.tbStnRes);
            this.Controls.Add(this.tbStrRes);
            this.Controls.Add(this.tbKodStnRes);
            this.Controls.Add(this.tbKodStrRes);
            this.Controls.Add(this.tbAddrSen);
            this.Controls.Add(this.tbStnSen);
            this.Controls.Add(this.tbSenStr);
            this.Controls.Add(this.tbKodStnSen);
            this.Controls.Add(this.tbKodSenstr);
            this.Name = "Zakaz";
            this.Text = "Zakaz";
            this.Load += new System.EventHandler(this.Zakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vagonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagonBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGruz;
        private System.Windows.Forms.Button btnRecipient;
        private System.Windows.Forms.Button btnSender;
        private System.Windows.Forms.ComboBox cbVagon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox tbRecipient;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label Груз;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKodSenstr;
        private System.Windows.Forms.TextBox tbKodStnSen;
        private System.Windows.Forms.TextBox tbSenStr;
        private System.Windows.Forms.TextBox tbStnSen;
        private System.Windows.Forms.TextBox tbAddrSen;
        private System.Windows.Forms.TextBox tbAddrRes;
        private System.Windows.Forms.TextBox tbStnRes;
        private System.Windows.Forms.TextBox tbStrRes;
        private System.Windows.Forms.TextBox tbKodStnRes;
        private System.Windows.Forms.TextBox tbKodStrRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbVesTara;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.TextBox tbVesGruza;
        private System.Windows.Forms.TextBox tbBrut;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbVid;
        private System.Windows.Forms.TextBox tbGr;
        private System.Windows.Forms.TextBox tbKodGr;
        private _C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet _C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet;
        private System.Windows.Forms.BindingSource vagonBindingSource;
        private _C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSetTableAdapters.VagonTableAdapter vagonTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRespPers;
        private _C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1 _C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1;
        private System.Windows.Forms.BindingSource vagonBindingSource1;
        private _C__USERS_ASUS_SOURCE_REPOS_ZD_ZD_ZD_MDFDataSet1TableAdapters.VagonTableAdapter vagonTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}