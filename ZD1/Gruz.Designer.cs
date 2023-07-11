namespace ZD1
{
    partial class Gruz
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKodGr = new System.Windows.Forms.TextBox();
            this.tbGr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBrut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVesGruza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbVesTara = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 39);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(657, 399);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(131, 39);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Добавить груз";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(501, 399);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 39);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Код груза";
            // 
            // tbKodGr
            // 
            this.tbKodGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKodGr.Location = new System.Drawing.Point(254, 59);
            this.tbKodGr.Name = "tbKodGr";
            this.tbKodGr.Size = new System.Drawing.Size(231, 22);
            this.tbKodGr.TabIndex = 8;
            // 
            // tbGr
            // 
            this.tbGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGr.Location = new System.Drawing.Point(254, 109);
            this.tbGr.Name = "tbGr";
            this.tbGr.Size = new System.Drawing.Size(231, 22);
            this.tbGr.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Наименование груза";
            // 
            // tbVid
            // 
            this.tbVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVid.Location = new System.Drawing.Point(254, 155);
            this.tbVid.Name = "tbVid";
            this.tbVid.Size = new System.Drawing.Size(231, 22);
            this.tbVid.TabIndex = 12;
            this.tbVid.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вид упаковки";
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDesc.Location = new System.Drawing.Point(254, 198);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(231, 22);
            this.tbDesc.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Описание груза";
            // 
            // tbBrut
            // 
            this.tbBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBrut.Location = new System.Drawing.Point(254, 240);
            this.tbBrut.Name = "tbBrut";
            this.tbBrut.Size = new System.Drawing.Size(231, 22);
            this.tbBrut.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(45, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Вес груза";
            // 
            // tbVesGruza
            // 
            this.tbVesGruza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVesGruza.Location = new System.Drawing.Point(254, 276);
            this.tbVesGruza.Name = "tbVesGruza";
            this.tbVesGruza.Size = new System.Drawing.Size(231, 22);
            this.tbVesGruza.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(45, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Вес брутто";
            // 
            // tbSpec
            // 
            this.tbSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSpec.Location = new System.Drawing.Point(254, 356);
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.Size = new System.Drawing.Size(231, 22);
            this.tbSpec.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(45, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Особые отметки";
            // 
            // tbVesTara
            // 
            this.tbVesTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVesTara.Location = new System.Drawing.Point(254, 316);
            this.tbVesTara.Name = "tbVesTara";
            this.tbVesTara.Size = new System.Drawing.Size(231, 22);
            this.tbVesTara.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(45, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Вес тары";
            // 
            // Gruz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbVesTara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbVesGruza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBrut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKodGr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnReset);
            this.Name = "Gruz";
            this.Text = "Gruz";
            this.Load += new System.EventHandler(this.Gruz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKodGr;
        private System.Windows.Forms.TextBox tbGr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBrut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVesGruza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbVesTara;
        private System.Windows.Forms.Label label8;
    }
}