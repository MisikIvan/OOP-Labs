
namespace TravelForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.numericgid = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericden = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericputivka = new System.Windows.Forms.NumericUpDown();
            this.lbres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btrozr = new System.Windows.Forms.Button();
            this.gidcheck = new System.Windows.Forms.CheckBox();
            this.sezoncombo = new System.Windows.Forms.ComboBox();
            this.countrycombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericgid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericputivka)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Кількість днів з гідом";
            // 
            // numericgid
            // 
            this.numericgid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericgid.Location = new System.Drawing.Point(221, 119);
            this.numericgid.Margin = new System.Windows.Forms.Padding(2);
            this.numericgid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericgid.Name = "numericgid";
            this.numericgid.Size = new System.Drawing.Size(90, 26);
            this.numericgid.TabIndex = 41;
            this.numericgid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(419, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Кількість днів";
            // 
            // numericden
            // 
            this.numericden.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericden.Location = new System.Drawing.Point(421, 150);
            this.numericden.Margin = new System.Windows.Forms.Padding(2);
            this.numericden.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericden.Name = "numericden";
            this.numericden.Size = new System.Drawing.Size(90, 26);
            this.numericden.TabIndex = 39;
            this.numericden.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(419, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Кількість путівок";
            // 
            // numericputivka
            // 
            this.numericputivka.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericputivka.Location = new System.Drawing.Point(421, 64);
            this.numericputivka.Margin = new System.Windows.Forms.Padding(2);
            this.numericputivka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericputivka.Name = "numericputivka";
            this.numericputivka.Size = new System.Drawing.Size(90, 26);
            this.numericputivka.TabIndex = 37;
            this.numericputivka.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbres
            // 
            this.lbres.AutoSize = true;
            this.lbres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbres.ForeColor = System.Drawing.Color.Red;
            this.lbres.Location = new System.Drawing.Point(69, 202);
            this.lbres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(0, 19);
            this.lbres.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Всього:";
            // 
            // btrozr
            // 
            this.btrozr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btrozr.Location = new System.Drawing.Point(221, 173);
            this.btrozr.Margin = new System.Windows.Forms.Padding(2);
            this.btrozr.Name = "btrozr";
            this.btrozr.Size = new System.Drawing.Size(95, 36);
            this.btrozr.TabIndex = 34;
            this.btrozr.Text = "Розрахувати";
            this.btrozr.UseVisualStyleBackColor = true;
            this.btrozr.Click += new System.EventHandler(this.btrozr_Click);
            // 
            // gidcheck
            // 
            this.gidcheck.AutoSize = true;
            this.gidcheck.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gidcheck.Location = new System.Drawing.Point(221, 46);
            this.gidcheck.Margin = new System.Windows.Forms.Padding(2);
            this.gidcheck.Name = "gidcheck";
            this.gidcheck.Size = new System.Drawing.Size(141, 24);
            this.gidcheck.TabIndex = 33;
            this.gidcheck.Text = "Індивідуальний гід";
            this.gidcheck.UseVisualStyleBackColor = true;
            // 
            // sezoncombo
            // 
            this.sezoncombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sezoncombo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sezoncombo.FormattingEnabled = true;
            this.sezoncombo.Items.AddRange(new object[] {
            "Літо",
            "Зима"});
            this.sezoncombo.Location = new System.Drawing.Point(30, 140);
            this.sezoncombo.Margin = new System.Windows.Forms.Padding(2);
            this.sezoncombo.Name = "sezoncombo";
            this.sezoncombo.Size = new System.Drawing.Size(107, 28);
            this.sezoncombo.TabIndex = 32;
            // 
            // countrycombo
            // 
            this.countrycombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countrycombo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countrycombo.FormattingEnabled = true;
            this.countrycombo.Items.AddRange(new object[] {
            "Болгарія",
            "Німеччина",
            "Польща"});
            this.countrycombo.Location = new System.Drawing.Point(30, 58);
            this.countrycombo.Margin = new System.Windows.Forms.Padding(2);
            this.countrycombo.Name = "countrycombo";
            this.countrycombo.Size = new System.Drawing.Size(104, 28);
            this.countrycombo.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Сезон:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Країнa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 325);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericgid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericputivka);
            this.Controls.Add(this.lbres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btrozr);
            this.Controls.Add(this.gidcheck);
            this.Controls.Add(this.sezoncombo);
            this.Controls.Add(this.countrycombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericgid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericputivka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericgid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericputivka;
        private System.Windows.Forms.Label lbres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btrozr;
        private System.Windows.Forms.CheckBox gidcheck;
        private System.Windows.Forms.ComboBox sezoncombo;
        private System.Windows.Forms.ComboBox countrycombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

