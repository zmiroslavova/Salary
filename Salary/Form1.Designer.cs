namespace Salary
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
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelSalaryPerHour = new System.Windows.Forms.Label();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxSalaryPerHour = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.richTextBoxAll = new System.Windows.Forms.RichTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Items.AddRange(new object[] {
            "Петър Петров",
            "Иван Иванов",
            "Силвия Митева",
            "Мартин Иванов",
            "Георги Георгиев",
            "Жанет Кирова",
            "Петя Христова",
            "Кристиян Петров",
            "Силвия Милева"});
            this.comboBoxName.Location = new System.Drawing.Point(146, 18);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(263, 21);
            this.comboBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Име и фамилия";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(12, 53);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(106, 13);
            this.labelHours.TabIndex = 2;
            this.labelHours.Text = "Изработени часове";
            // 
            // labelSalaryPerHour
            // 
            this.labelSalaryPerHour.AutoSize = true;
            this.labelSalaryPerHour.Location = new System.Drawing.Point(15, 85);
            this.labelSalaryPerHour.Name = "labelSalaryPerHour";
            this.labelSalaryPerHour.Size = new System.Drawing.Size(78, 13);
            this.labelSalaryPerHour.TabIndex = 3;
            this.labelSalaryPerHour.Text = "Ставка на час";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(146, 50);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(263, 20);
            this.textBoxHours.TabIndex = 4;
            // 
            // textBoxSalaryPerHour
            // 
            this.textBoxSalaryPerHour.Location = new System.Drawing.Point(145, 82);
            this.textBoxSalaryPerHour.Name = "textBoxSalaryPerHour";
            this.textBoxSalaryPerHour.Size = new System.Drawing.Size(263, 20);
            this.textBoxSalaryPerHour.TabIndex = 5;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(145, 116);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.ReadOnly = true;
            this.textBoxSalary.Size = new System.Drawing.Size(263, 20);
            this.textBoxSalary.TabIndex = 6;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(15, 119);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(95, 13);
            this.labelSalary.TabIndex = 7;
            this.labelSalary.Text = "Месечна заплата";
            // 
            // richTextBoxAll
            // 
            this.richTextBoxAll.Location = new System.Drawing.Point(18, 158);
            this.richTextBoxAll.Name = "richTextBoxAll";
            this.richTextBoxAll.ReadOnly = true;
            this.richTextBoxAll.Size = new System.Drawing.Size(392, 280);
            this.richTextBoxAll.TabIndex = 8;
            this.richTextBoxAll.Text = "";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(432, 190);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 33);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Изчисти";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(432, 307);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 33);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добави";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(432, 366);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 33);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Запиши";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(432, 248);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(119, 33);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Изчисли";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.richTextBoxAll);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxSalaryPerHour);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.labelSalaryPerHour);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxName);
            this.Name = "Form1";
            this.Text = "Заплати";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelSalaryPerHour;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.TextBox textBoxSalaryPerHour;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.RichTextBox richTextBoxAll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

