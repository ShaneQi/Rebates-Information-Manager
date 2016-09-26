namespace Asg2_zxq150130
{
    partial class Form
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
            this.button2 = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.reveiveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.attachedProofCheckBox = new System.Windows.Forms.CheckBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.middleInitialTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.addressLine2TextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addressLine1TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.middleInitialErrorLabel = new System.Windows.Forms.Label();
            this.addressLine1ErrorLabel = new System.Windows.Forms.Label();
            this.addressLine2ErrorLabel = new System.Windows.Forms.Label();
            this.stateErrorLabel = new System.Windows.Forms.Label();
            this.cityErrorLabel = new System.Windows.Forms.Label();
            this.zipErrorLabel = new System.Windows.Forms.Label();
            this.phoneNumberErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.didClickResetButton);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(499, 429);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.didClickSubmitButton);
            // 
            // reveiveDatePicker
            // 
            this.reveiveDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.recordBindingSource, "recieveDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.reveiveDatePicker.Location = new System.Drawing.Point(552, 384);
            this.reveiveDatePicker.Name = "reveiveDatePicker";
            this.reveiveDatePicker.Size = new System.Drawing.Size(200, 20);
            this.reveiveDatePicker.TabIndex = 11;
            // 
            // attachedProofCheckBox
            // 
            this.attachedProofCheckBox.AutoSize = true;
            this.attachedProofCheckBox.Checked = true;
            this.attachedProofCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.attachedProofCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.recordBindingSource, "isProofAttached", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.attachedProofCheckBox.Location = new System.Drawing.Point(552, 359);
            this.attachedProofCheckBox.Name = "attachedProofCheckBox";
            this.attachedProofCheckBox.Size = new System.Drawing.Size(44, 17);
            this.attachedProofCheckBox.TabIndex = 10;
            this.attachedProofCheckBox.Text = "Yes";
            this.attachedProofCheckBox.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(376, 538);
            this.grid.TabIndex = 28;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.didClickGirdCell);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.emailTextBox.Location = new System.Drawing.Point(552, 331);
            this.emailTextBox.MaxLength = 60;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(261, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "phoneNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(552, 303);
            this.phoneNumberTextBox.MaxLength = 21;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(261, 20);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "city", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cityTextBox.Location = new System.Drawing.Point(552, 219);
            this.cityTextBox.MaxLength = 25;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(261, 20);
            this.cityTextBox.TabIndex = 5;
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "middleInitial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.middleInitialTextBox.Location = new System.Drawing.Point(552, 135);
            this.middleInitialTextBox.MaxLength = 1;
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.Size = new System.Drawing.Size(261, 20);
            this.middleInitialTextBox.TabIndex = 2;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "zip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.zipTextBox.Location = new System.Drawing.Point(552, 275);
            this.zipTextBox.MaxLength = 9;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(261, 20);
            this.zipTextBox.TabIndex = 7;
            // 
            // addressLine2TextBox
            // 
            this.addressLine2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "addressLine2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addressLine2TextBox.Location = new System.Drawing.Point(552, 191);
            this.addressLine2TextBox.MaxLength = 35;
            this.addressLine2TextBox.Name = "addressLine2TextBox";
            this.addressLine2TextBox.Size = new System.Drawing.Size(261, 20);
            this.addressLine2TextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "lastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lastNameTextBox.Location = new System.Drawing.Point(552, 107);
            this.lastNameTextBox.MaxLength = 20;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(261, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(467, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Date Received";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Attached Proof of Purchase";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Email";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "state", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stateTextBox.Location = new System.Drawing.Point(552, 247);
            this.stateTextBox.MaxLength = 2;
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(261, 20);
            this.stateTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Phone Number";
            // 
            // addressLine1TextBox
            // 
            this.addressLine1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "addressLine1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addressLine1TextBox.Location = new System.Drawing.Point(552, 163);
            this.addressLine1TextBox.MaxLength = 35;
            this.addressLine1TextBox.Name = "addressLine1TextBox";
            this.addressLine1TextBox.Size = new System.Drawing.Size(261, 20);
            this.addressLine1TextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Zip Code";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordBindingSource, "firstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.firstNameTextBox.Location = new System.Drawing.Point(552, 79);
            this.firstNameTextBox.MaxLength = 20;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(261, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address Line 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Middle Initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address Line 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.didClickDeleteButton);
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(819, 82);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.firstNameErrorLabel.TabIndex = 29;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(819, 111);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.lastNameErrorLabel.TabIndex = 29;
            // 
            // middleInitialErrorLabel
            // 
            this.middleInitialErrorLabel.AutoSize = true;
            this.middleInitialErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.middleInitialErrorLabel.Location = new System.Drawing.Point(819, 139);
            this.middleInitialErrorLabel.Name = "middleInitialErrorLabel";
            this.middleInitialErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.middleInitialErrorLabel.TabIndex = 29;
            // 
            // addressLine1ErrorLabel
            // 
            this.addressLine1ErrorLabel.AutoSize = true;
            this.addressLine1ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.addressLine1ErrorLabel.Location = new System.Drawing.Point(819, 168);
            this.addressLine1ErrorLabel.Name = "addressLine1ErrorLabel";
            this.addressLine1ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.addressLine1ErrorLabel.TabIndex = 29;
            // 
            // addressLine2ErrorLabel
            // 
            this.addressLine2ErrorLabel.AutoSize = true;
            this.addressLine2ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.addressLine2ErrorLabel.Location = new System.Drawing.Point(819, 193);
            this.addressLine2ErrorLabel.Name = "addressLine2ErrorLabel";
            this.addressLine2ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.addressLine2ErrorLabel.TabIndex = 29;
            // 
            // stateErrorLabel
            // 
            this.stateErrorLabel.AutoSize = true;
            this.stateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.stateErrorLabel.Location = new System.Drawing.Point(819, 250);
            this.stateErrorLabel.Name = "stateErrorLabel";
            this.stateErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.stateErrorLabel.TabIndex = 29;
            // 
            // cityErrorLabel
            // 
            this.cityErrorLabel.AutoSize = true;
            this.cityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.cityErrorLabel.Location = new System.Drawing.Point(819, 222);
            this.cityErrorLabel.Name = "cityErrorLabel";
            this.cityErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.cityErrorLabel.TabIndex = 29;
            // 
            // zipErrorLabel
            // 
            this.zipErrorLabel.AutoSize = true;
            this.zipErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.zipErrorLabel.Location = new System.Drawing.Point(819, 279);
            this.zipErrorLabel.Name = "zipErrorLabel";
            this.zipErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.zipErrorLabel.TabIndex = 29;
            // 
            // phoneNumberErrorLabel
            // 
            this.phoneNumberErrorLabel.AutoSize = true;
            this.phoneNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneNumberErrorLabel.Location = new System.Drawing.Point(819, 306);
            this.phoneNumberErrorLabel.Name = "phoneNumberErrorLabel";
            this.phoneNumberErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.phoneNumberErrorLabel.TabIndex = 29;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(819, 335);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.emailErrorLabel.TabIndex = 29;
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataSource = typeof(Asg2_zxq150130.Record);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.zipErrorLabel);
            this.Controls.Add(this.addressLine1ErrorLabel);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.cityErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.stateErrorLabel);
            this.Controls.Add(this.phoneNumberErrorLabel);
            this.Controls.Add(this.addressLine2ErrorLabel);
            this.Controls.Add(this.middleInitialErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.reveiveDatePicker);
            this.Controls.Add(this.attachedProofCheckBox);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.middleInitialTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.addressLine2TextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addressLine1TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker reveiveDatePicker;
        private System.Windows.Forms.CheckBox attachedProofCheckBox;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox middleInitialTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox addressLine2TextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addressLine1TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label middleInitialErrorLabel;
        private System.Windows.Forms.Label addressLine1ErrorLabel;
        private System.Windows.Forms.Label addressLine2ErrorLabel;
        private System.Windows.Forms.Label stateErrorLabel;
        private System.Windows.Forms.Label cityErrorLabel;
        private System.Windows.Forms.Label zipErrorLabel;
        private System.Windows.Forms.Label phoneNumberErrorLabel;
        private System.Windows.Forms.Label emailErrorLabel;
    }
}

