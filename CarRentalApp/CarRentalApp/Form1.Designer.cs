namespace CarRentalApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustumerName = new System.Windows.Forms.Label();
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.lbDateRented = new System.Windows.Forms.Label();
            this.lbDateReturned = new System.Windows.Forms.Label();
            this.cbTypeOfBox = new System.Windows.Forms.ComboBox();
            this.lbTypeOfCar = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbCost = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(12, 91);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(250, 20);
            this.tbCustomerName.TabIndex = 1;
            // 
            // lbCustumerName
            // 
            this.lbCustumerName.AutoSize = true;
            this.lbCustumerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustumerName.Location = new System.Drawing.Point(9, 72);
            this.lbCustumerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustumerName.Name = "lbCustumerName";
            this.lbCustumerName.Size = new System.Drawing.Size(122, 17);
            this.lbCustumerName.TabIndex = 2;
            this.lbCustumerName.Text = "Customer Name";
            // 
            // dtpDateRented
            // 
            this.dtpDateRented.Location = new System.Drawing.Point(12, 154);
            this.dtpDateRented.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(250, 20);
            this.dtpDateRented.TabIndex = 3;
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.Location = new System.Drawing.Point(286, 154);
            this.dtpDateReturned.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(250, 20);
            this.dtpDateReturned.TabIndex = 4;
            // 
            // lbDateRented
            // 
            this.lbDateRented.AutoSize = true;
            this.lbDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateRented.Location = new System.Drawing.Point(9, 135);
            this.lbDateRented.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateRented.Name = "lbDateRented";
            this.lbDateRented.Size = new System.Drawing.Size(99, 17);
            this.lbDateRented.TabIndex = 5;
            this.lbDateRented.Text = "Date Rented";
            // 
            // lbDateReturned
            // 
            this.lbDateReturned.AutoSize = true;
            this.lbDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateReturned.Location = new System.Drawing.Point(283, 135);
            this.lbDateReturned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateReturned.Name = "lbDateReturned";
            this.lbDateReturned.Size = new System.Drawing.Size(114, 17);
            this.lbDateReturned.TabIndex = 6;
            this.lbDateReturned.Text = "Date Returned";
            // 
            // cbTypeOfBox
            // 
            this.cbTypeOfBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTypeOfBox.FormattingEnabled = true;
            this.cbTypeOfBox.Location = new System.Drawing.Point(12, 227);
            this.cbTypeOfBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTypeOfBox.Name = "cbTypeOfBox";
            this.cbTypeOfBox.Size = new System.Drawing.Size(250, 21);
            this.cbTypeOfBox.TabIndex = 7;
            // 
            // lbTypeOfCar
            // 
            this.lbTypeOfCar.AutoSize = true;
            this.lbTypeOfCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeOfCar.Location = new System.Drawing.Point(9, 208);
            this.lbTypeOfCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTypeOfCar.Name = "lbTypeOfCar";
            this.lbTypeOfCar.Size = new System.Drawing.Size(96, 17);
            this.lbTypeOfCar.TabIndex = 8;
            this.lbTypeOfCar.Text = "Type Of Car";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(439, 303);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 44);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(283, 72);
            this.lbCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(40, 17);
            this.lbCost.TabIndex = 11;
            this.lbCost.Text = "Cost";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(286, 91);
            this.tbCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(250, 20);
            this.tbCost.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbTypeOfCar);
            this.Controls.Add(this.cbTypeOfBox);
            this.Controls.Add(this.lbDateReturned);
            this.Controls.Add(this.lbDateRented);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.dtpDateRented);
            this.Controls.Add(this.lbCustumerName);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lbCustumerName;
        private System.Windows.Forms.DateTimePicker dtpDateRented;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.Label lbDateRented;
        private System.Windows.Forms.Label lbDateReturned;
        private System.Windows.Forms.ComboBox cbTypeOfBox;
        private System.Windows.Forms.Label lbTypeOfCar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.TextBox tbCost;
    }
}

