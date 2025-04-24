
namespace GlazedForms
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
            this.checkBoxpidv = new System.Windows.Forms.CheckBox();
            this.radiobtdvo = new System.Windows.Forms.RadioButton();
            this.radiobtodno = new System.Windows.Forms.RadioButton();
            this.combomater = new System.Windows.Forms.ComboBox();
            this.textboxheight = new System.Windows.Forms.TextBox();
            this.textboxwidth = new System.Windows.Forms.TextBox();
            this.btrozr = new System.Windows.Forms.Button();
            this.labelvart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxpidv
            // 
            this.checkBoxpidv.AutoSize = true;
            this.checkBoxpidv.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxpidv.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxpidv.Location = new System.Drawing.Point(392, 173);
            this.checkBoxpidv.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxpidv.Name = "checkBoxpidv";
            this.checkBoxpidv.Size = new System.Drawing.Size(93, 24);
            this.checkBoxpidv.TabIndex = 43;
            this.checkBoxpidv.Text = "Підвіконня";
            this.checkBoxpidv.UseVisualStyleBackColor = false;
            // 
            // radiobtdvo
            // 
            this.radiobtdvo.AutoSize = true;
            this.radiobtdvo.BackColor = System.Drawing.SystemColors.Control;
            this.radiobtdvo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiobtdvo.Location = new System.Drawing.Point(392, 144);
            this.radiobtdvo.Margin = new System.Windows.Forms.Padding(2);
            this.radiobtdvo.Name = "radiobtdvo";
            this.radiobtdvo.Size = new System.Drawing.Size(110, 24);
            this.radiobtdvo.TabIndex = 42;
            this.radiobtdvo.Text = "Двокамерний";
            this.radiobtdvo.UseVisualStyleBackColor = false;
            // 
            // radiobtodno
            // 
            this.radiobtodno.AutoSize = true;
            this.radiobtodno.BackColor = System.Drawing.SystemColors.Control;
            this.radiobtodno.Checked = true;
            this.radiobtodno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiobtodno.Location = new System.Drawing.Point(392, 113);
            this.radiobtodno.Margin = new System.Windows.Forms.Padding(2);
            this.radiobtodno.Name = "radiobtodno";
            this.radiobtodno.Size = new System.Drawing.Size(119, 24);
            this.radiobtodno.TabIndex = 41;
            this.radiobtodno.TabStop = true;
            this.radiobtodno.Text = "Однокамерний";
            this.radiobtodno.UseVisualStyleBackColor = false;
            // 
            // combomater
            // 
            this.combomater.BackColor = System.Drawing.SystemColors.Control;
            this.combomater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomater.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combomater.FormattingEnabled = true;
            this.combomater.Items.AddRange(new object[] {
            "Дерево",
            "Метал",
            "Металопластик"});
            this.combomater.Location = new System.Drawing.Point(138, 170);
            this.combomater.Margin = new System.Windows.Forms.Padding(2);
            this.combomater.Name = "combomater";
            this.combomater.Size = new System.Drawing.Size(130, 28);
            this.combomater.TabIndex = 40;
            // 
            // textboxheight
            // 
            this.textboxheight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxheight.BackColor = System.Drawing.SystemColors.Control;
            this.textboxheight.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxheight.Location = new System.Drawing.Point(138, 136);
            this.textboxheight.Margin = new System.Windows.Forms.Padding(2);
            this.textboxheight.Name = "textboxheight";
            this.textboxheight.Size = new System.Drawing.Size(108, 26);
            this.textboxheight.TabIndex = 39;
            // 
            // textboxwidth
            // 
            this.textboxwidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxwidth.BackColor = System.Drawing.SystemColors.Control;
            this.textboxwidth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxwidth.Location = new System.Drawing.Point(138, 106);
            this.textboxwidth.Margin = new System.Windows.Forms.Padding(2);
            this.textboxwidth.Name = "textboxwidth";
            this.textboxwidth.Size = new System.Drawing.Size(108, 26);
            this.textboxwidth.TabIndex = 38;
            // 
            // btrozr
            // 
            this.btrozr.BackColor = System.Drawing.SystemColors.Control;
            this.btrozr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btrozr.Location = new System.Drawing.Point(392, 210);
            this.btrozr.Margin = new System.Windows.Forms.Padding(2);
            this.btrozr.Name = "btrozr";
            this.btrozr.Size = new System.Drawing.Size(108, 36);
            this.btrozr.TabIndex = 37;
            this.btrozr.Text = "Розрахувати";
            this.btrozr.UseVisualStyleBackColor = false;
            this.btrozr.Click += new System.EventHandler(this.btrozr_Click);
            // 
            // labelvart
            // 
            this.labelvart.AutoSize = true;
            this.labelvart.BackColor = System.Drawing.SystemColors.Control;
            this.labelvart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelvart.ForeColor = System.Drawing.Color.Red;
            this.labelvart.Location = new System.Drawing.Point(123, 248);
            this.labelvart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelvart.Name = "labelvart";
            this.labelvart.Size = new System.Drawing.Size(0, 19);
            this.labelvart.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(43, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Вартість:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(43, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Матеріал:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(43, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Висота (см):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ширина (см):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(390, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Склопакет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Розміри вікна";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 378);
            this.Controls.Add(this.checkBoxpidv);
            this.Controls.Add(this.radiobtdvo);
            this.Controls.Add(this.radiobtodno);
            this.Controls.Add(this.combomater);
            this.Controls.Add(this.textboxheight);
            this.Controls.Add(this.textboxwidth);
            this.Controls.Add(this.btrozr);
            this.Controls.Add(this.labelvart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxpidv;
        private System.Windows.Forms.RadioButton radiobtdvo;
        private System.Windows.Forms.RadioButton radiobtodno;
        private System.Windows.Forms.ComboBox combomater;
        private System.Windows.Forms.TextBox textboxheight;
        private System.Windows.Forms.TextBox textboxwidth;
        private System.Windows.Forms.Button btrozr;
        private System.Windows.Forms.Label labelvart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

