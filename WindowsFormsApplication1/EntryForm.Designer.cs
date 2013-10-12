namespace WindowsFormsApplication1
{
    partial class EntryForm
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.DateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameValidation = new System.Windows.Forms.Label();
            this.PriceValidation = new System.Windows.Forms.Label();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PriceErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(37, 20);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Date";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(37, 59);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(36, 123);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(37, 177);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Enabled = false;
            this.dateTextBox.Location = new System.Drawing.Point(109, 17);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(158, 20);
            this.dateTextBox.TabIndex = 4;
            this.dateTextBox.Text = "10/10/2013 12:00:00 AM";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(210, 32);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.PickDate);
            this.monthCalendar1.Leave += new System.EventHandler(this.monthCalendar1_Leave);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(109, 59);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(158, 20);
            this.NameBox.TabIndex = 5;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            this.NameBox.Validated += new System.EventHandler(this.NameBox_Validated);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(109, 116);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(158, 20);
            this.PriceBox.TabIndex = 6;
            this.PriceBox.Validating += new System.ComponentModel.CancelEventHandler(this.Price_Validating);
            this.PriceBox.Validated += new System.EventHandler(this.PriceBox_Validated);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(40, 206);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(397, 178);
            this.DescriptionBox.TabIndex = 7;
            // 
            // DateButton
            // 
            this.DateButton.Location = new System.Drawing.Point(273, 15);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(91, 23);
            this.DateButton.TabIndex = 9;
            this.DateButton.Text = "Change Date..";
            this.DateButton.UseVisualStyleBackColor = true;
            this.DateButton.Click += new System.EventHandler(this.ClickDateButton);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(362, 404);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(263, 404);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NameValidation
            // 
            this.NameValidation.AutoSize = true;
            this.NameValidation.Location = new System.Drawing.Point(109, 86);
            this.NameValidation.Name = "NameValidation";
            this.NameValidation.Size = new System.Drawing.Size(0, 13);
            this.NameValidation.TabIndex = 12;
            // 
            // PriceValidation
            // 
            this.PriceValidation.AutoSize = true;
            this.PriceValidation.Location = new System.Drawing.Point(112, 143);
            this.PriceValidation.Name = "PriceValidation";
            this.PriceValidation.Size = new System.Drawing.Size(0, 13);
            this.PriceValidation.TabIndex = 13;
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.ContainerControl = this;
            // 
            // PriceErrorProvider
            // 
            this.PriceErrorProvider.ContainerControl = this;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 453);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.PriceValidation);
            this.Controls.Add(this.NameValidation);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DateLabel);
            this.Name = "Form";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label NameValidation;
        private System.Windows.Forms.Label PriceValidation;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider PriceErrorProvider;
    }
}