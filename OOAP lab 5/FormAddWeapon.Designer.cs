namespace OOAP_lab_5
{
    partial class FormAddWeapon
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
            this.comboBoxWeaponType = new System.Windows.Forms.ComboBox();
            this.checkBoxOptics = new System.Windows.Forms.CheckBox();
            this.checkBoxSilencer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxWeaponType
            // 
            this.comboBoxWeaponType.FormattingEnabled = true;
            this.comboBoxWeaponType.Location = new System.Drawing.Point(29, 33);
            this.comboBoxWeaponType.Name = "comboBoxWeaponType";
            this.comboBoxWeaponType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWeaponType.TabIndex = 0;
            // 
            // checkBoxOptics
            // 
            this.checkBoxOptics.AutoSize = true;
            this.checkBoxOptics.Location = new System.Drawing.Point(29, 75);
            this.checkBoxOptics.Name = "checkBoxOptics";
            this.checkBoxOptics.Size = new System.Drawing.Size(60, 17);
            this.checkBoxOptics.TabIndex = 1;
            this.checkBoxOptics.Text = "Приціл";
            this.checkBoxOptics.UseVisualStyleBackColor = true;
            // 
            // checkBoxSilencer
            // 
            this.checkBoxSilencer.AutoSize = true;
            this.checkBoxSilencer.Location = new System.Drawing.Point(29, 109);
            this.checkBoxSilencer.Name = "checkBoxSilencer";
            this.checkBoxSilencer.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSilencer.TabIndex = 2;
            this.checkBoxSilencer.Text = "Глушник";
            this.checkBoxSilencer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вибрати зброю";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Створити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddWeapon_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAddWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 183);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSilencer);
            this.Controls.Add(this.checkBoxOptics);
            this.Controls.Add(this.comboBoxWeaponType);
            this.Name = "FormAddWeapon";
            this.Text = "FormAddWeapon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWeaponType;
        private System.Windows.Forms.CheckBox checkBoxOptics;
        private System.Windows.Forms.CheckBox checkBoxSilencer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}