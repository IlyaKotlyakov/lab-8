namespace XMLGUI.Forms
{
    partial class FilterProperties
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
            this.btnApply = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.paramTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnApply.Location = new System.Drawing.Point(167, 96);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(130, 39);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "ОК";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnBtnApplyClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Чит билет",
            "Автор",
            "Издательство",
            "Дата сдачи"});
            this.comboBox1.Location = new System.Drawing.Point(16, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(16, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // paramTxtBox
            // 
            this.paramTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.paramTxtBox.Location = new System.Drawing.Point(16, 56);
            this.paramTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paramTxtBox.Name = "paramTxtBox";
            this.paramTxtBox.Size = new System.Drawing.Size(281, 30);
            this.paramTxtBox.TabIndex = 4;
            // 
            // FilterProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 149);
            this.Controls.Add(this.paramTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FilterProperties";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox paramTxtBox;
    }
}