namespace AirlineTicketSales
{
    partial class FormPassanger
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxSeat = new System.Windows.Forms.TextBox();
            this.labelFlightInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 57);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(105, 144);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(91, 23);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click_1);
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(286, 144);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(75, 23);
            this.buttonCansel.TabIndex = 2;
            this.buttonCansel.Text = "Отмена";
            this.buttonCansel.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(183, 57);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxSeat
            // 
            this.textBoxSeat.Location = new System.Drawing.Point(363, 57);
            this.textBoxSeat.Name = "textBoxSeat";
            this.textBoxSeat.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeat.TabIndex = 4;
            // 
            // labelFlightInfo
            // 
            this.labelFlightInfo.AutoSize = true;
            this.labelFlightInfo.Location = new System.Drawing.Point(209, 9);
            this.labelFlightInfo.Name = "labelFlightInfo";
            this.labelFlightInfo.Size = new System.Drawing.Size(35, 13);
            this.labelFlightInfo.TabIndex = 5;
            this.labelFlightInfo.Text = "label1";
            // 
            // FormPassanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 187);
            this.Controls.Add(this.labelFlightInfo);
            this.Controls.Add(this.textBoxSeat);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormPassanger";
            this.Text = "FormPassanger";
            this.Load += new System.EventHandler(this.FormPassanger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxSeat;
        private System.Windows.Forms.Label labelFlightInfo;
    }
}