namespace FormUI
{
    partial class Dashboard
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
            this.EmployeeFoundList = new System.Windows.Forms.ListBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.GenderLable = new System.Windows.Forms.Label();
            this.CityLable = new System.Windows.Forms.Label();
            this.SalaryLable = new System.Windows.Forms.Label();
            this.NameInsLable = new System.Windows.Forms.Label();
            this.NameInsText = new System.Windows.Forms.TextBox();
            this.GenderInsText = new System.Windows.Forms.TextBox();
            this.CityInsText = new System.Windows.Forms.TextBox();
            this.SalaryInsText = new System.Windows.Forms.TextBox();
            this.IdInsLable = new System.Windows.Forms.Label();
            this.IdInsText = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeFoundList
            // 
            this.EmployeeFoundList.FormattingEnabled = true;
            this.EmployeeFoundList.ItemHeight = 20;
            this.EmployeeFoundList.Location = new System.Drawing.Point(78, 123);
            this.EmployeeFoundList.Name = "EmployeeFoundList";
            this.EmployeeFoundList.Size = new System.Drawing.Size(384, 64);
            this.EmployeeFoundList.TabIndex = 0;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(459, 40);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(132, 26);
            this.NameText.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(187, 46);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(291, 80);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(85, 37);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // GenderLable
            // 
            this.GenderLable.AutoSize = true;
            this.GenderLable.Location = new System.Drawing.Point(22, 329);
            this.GenderLable.Name = "GenderLable";
            this.GenderLable.Size = new System.Drawing.Size(63, 20);
            this.GenderLable.TabIndex = 4;
            this.GenderLable.Text = "Gender";
            // 
            // CityLable
            // 
            this.CityLable.AutoSize = true;
            this.CityLable.Location = new System.Drawing.Point(373, 332);
            this.CityLable.Name = "CityLable";
            this.CityLable.Size = new System.Drawing.Size(35, 20);
            this.CityLable.TabIndex = 5;
            this.CityLable.Text = "City";
            // 
            // SalaryLable
            // 
            this.SalaryLable.AutoSize = true;
            this.SalaryLable.Location = new System.Drawing.Point(22, 364);
            this.SalaryLable.Name = "SalaryLable";
            this.SalaryLable.Size = new System.Drawing.Size(53, 20);
            this.SalaryLable.TabIndex = 6;
            this.SalaryLable.Text = "Salary";
            // 
            // NameInsLable
            // 
            this.NameInsLable.AutoSize = true;
            this.NameInsLable.Location = new System.Drawing.Point(22, 270);
            this.NameInsLable.Name = "NameInsLable";
            this.NameInsLable.Size = new System.Drawing.Size(51, 20);
            this.NameInsLable.TabIndex = 7;
            this.NameInsLable.Text = "Name";
            // 
            // NameInsText
            // 
            this.NameInsText.Location = new System.Drawing.Point(106, 267);
            this.NameInsText.Name = "NameInsText";
            this.NameInsText.Size = new System.Drawing.Size(132, 26);
            this.NameInsText.TabIndex = 8;
            // 
            // GenderInsText
            // 
            this.GenderInsText.Location = new System.Drawing.Point(106, 326);
            this.GenderInsText.Name = "GenderInsText";
            this.GenderInsText.Size = new System.Drawing.Size(132, 26);
            this.GenderInsText.TabIndex = 9;
            // 
            // CityInsText
            // 
            this.CityInsText.Location = new System.Drawing.Point(572, 323);
            this.CityInsText.Name = "CityInsText";
            this.CityInsText.Size = new System.Drawing.Size(132, 26);
            this.CityInsText.TabIndex = 10;
            this.CityInsText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SalaryInsText
            // 
            this.SalaryInsText.Location = new System.Drawing.Point(106, 364);
            this.SalaryInsText.Name = "SalaryInsText";
            this.SalaryInsText.Size = new System.Drawing.Size(132, 26);
            this.SalaryInsText.TabIndex = 11;
            // 
            // IdInsLable
            // 
            this.IdInsLable.AutoSize = true;
            this.IdInsLable.Location = new System.Drawing.Point(373, 270);
            this.IdInsLable.Name = "IdInsLable";
            this.IdInsLable.Size = new System.Drawing.Size(23, 20);
            this.IdInsLable.TabIndex = 12;
            this.IdInsLable.Text = "Id";
            // 
            // IdInsText
            // 
            this.IdInsText.Location = new System.Drawing.Point(572, 264);
            this.IdInsText.Name = "IdInsText";
            this.IdInsText.Size = new System.Drawing.Size(132, 26);
            this.IdInsText.TabIndex = 13;
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(346, 401);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(85, 37);
            this.InsertRecordButton.TabIndex = 14;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.IdInsText);
            this.Controls.Add(this.IdInsLable);
            this.Controls.Add(this.SalaryInsText);
            this.Controls.Add(this.CityInsText);
            this.Controls.Add(this.GenderInsText);
            this.Controls.Add(this.NameInsText);
            this.Controls.Add(this.NameInsLable);
            this.Controls.Add(this.SalaryLable);
            this.Controls.Add(this.CityLable);
            this.Controls.Add(this.GenderLable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.EmployeeFoundList);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeFoundList;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label GenderLable;
        private System.Windows.Forms.Label CityLable;
        private System.Windows.Forms.Label SalaryLable;
        private System.Windows.Forms.Label NameInsLable;
        private System.Windows.Forms.TextBox NameInsText;
        private System.Windows.Forms.TextBox GenderInsText;
        private System.Windows.Forms.TextBox CityInsText;
        private System.Windows.Forms.TextBox SalaryInsText;
        private System.Windows.Forms.Label IdInsLable;
        private System.Windows.Forms.TextBox IdInsText;
        private System.Windows.Forms.Button InsertRecordButton;
    }
}