namespace CityInfoApp
{
    partial class CityInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cityListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.countryRadioButton = new System.Windows.Forms.RadioButton();
            this.cityRadioButton = new System.Windows.Forms.RadioButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(this.aboutTextBox);
            this.groupBox1.Controls.Add(this.cityNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(115, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City Information";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(197, 114);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "City Name";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(100, 86);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(172, 20);
            this.countryTextBox.TabIndex = 2;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Location = new System.Drawing.Point(100, 45);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(172, 35);
            this.aboutTextBox.TabIndex = 1;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(100, 19);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.cityNameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cityListView);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.countryRadioButton);
            this.groupBox2.Controls.Add(this.cityRadioButton);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cityListView
            // 
            this.cityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.cityListView.FullRowSelect = true;
            this.cityListView.Location = new System.Drawing.Point(6, 79);
            this.cityListView.Name = "cityListView";
            this.cityListView.Size = new System.Drawing.Size(488, 137);
            this.cityListView.TabIndex = 4;
            this.cityListView.UseCompatibleStateImageBehavior = false;
            this.cityListView.View = System.Windows.Forms.View.Details;
            this.cityListView.DoubleClick += new System.EventHandler(this.cityListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "City Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "About";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 231;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Country";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(399, 30);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // countryRadioButton
            // 
            this.countryRadioButton.AutoSize = true;
            this.countryRadioButton.Location = new System.Drawing.Point(48, 42);
            this.countryRadioButton.Name = "countryRadioButton";
            this.countryRadioButton.Size = new System.Drawing.Size(112, 17);
            this.countryRadioButton.TabIndex = 2;
            this.countryRadioButton.TabStop = true;
            this.countryRadioButton.Text = "Search by Country";
            this.countryRadioButton.UseVisualStyleBackColor = true;
            this.countryRadioButton.CheckedChanged += new System.EventHandler(this.countryRadioButton_CheckedChanged);
            // 
            // cityRadioButton
            // 
            this.cityRadioButton.AutoSize = true;
            this.cityRadioButton.Location = new System.Drawing.Point(48, 19);
            this.cityRadioButton.Name = "cityRadioButton";
            this.cityRadioButton.Size = new System.Drawing.Size(93, 17);
            this.cityRadioButton.TabIndex = 1;
            this.cityRadioButton.TabStop = true;
            this.cityRadioButton.Text = "Search by City";
            this.cityRadioButton.UseVisualStyleBackColor = true;
            this.cityRadioButton.CheckedChanged += new System.EventHandler(this.cityRadioButton_CheckedChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(203, 30);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(172, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // CityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CityInfo";
            this.Text = "City Information";
            this.Load += new System.EventHandler(this.CityInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton countryRadioButton;
        private System.Windows.Forms.RadioButton cityRadioButton;
        private System.Windows.Forms.ListView cityListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

