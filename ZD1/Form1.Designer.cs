namespace ZD1
{
    partial class Form1
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
            this.btnZakaz = new System.Windows.Forms.Button();
            this.btnVagon = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZakaz
            // 
            this.btnZakaz.Location = new System.Drawing.Point(298, 200);
            this.btnZakaz.Name = "btnZakaz";
            this.btnZakaz.Size = new System.Drawing.Size(131, 39);
            this.btnZakaz.TabIndex = 0;
            this.btnZakaz.Text = "Создать заказ";
            this.btnZakaz.UseVisualStyleBackColor = true;
            this.btnZakaz.Click += new System.EventHandler(this.btnZakaz_Click);
            // 
            // btnVagon
            // 
            this.btnVagon.Location = new System.Drawing.Point(298, 255);
            this.btnVagon.Name = "btnVagon";
            this.btnVagon.Size = new System.Drawing.Size(131, 39);
            this.btnVagon.TabIndex = 1;
            this.btnVagon.Text = "Добавить вагон";
            this.btnVagon.UseVisualStyleBackColor = true;
            this.btnVagon.Click += new System.EventHandler(this.btnVagon_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(298, 313);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(131, 39);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "Просмотр заказов";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(657, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(247, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Управление заказами";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnVagon);
            this.Controls.Add(this.btnZakaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZakaz;
        private System.Windows.Forms.Button btnVagon;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

