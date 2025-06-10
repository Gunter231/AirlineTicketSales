namespace AirlineTicketSales
{
    partial class FormSoldTickets
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
            this.labelFlightInfo = new System.Windows.Forms.Label();
            this.listBoxTickets = new System.Windows.Forms.ListBox();
            this.labelTotalPassengers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFlightInfo
            // 
            this.labelFlightInfo.AutoSize = true;
            this.labelFlightInfo.Location = new System.Drawing.Point(322, 64);
            this.labelFlightInfo.Name = "labelFlightInfo";
            this.labelFlightInfo.Size = new System.Drawing.Size(35, 13);
            this.labelFlightInfo.TabIndex = 0;
            this.labelFlightInfo.Text = "label1";
            // 
            // listBoxTickets
            // 
            this.listBoxTickets.FormattingEnabled = true;
            this.listBoxTickets.Location = new System.Drawing.Point(285, 150);
            this.listBoxTickets.Name = "listBoxTickets";
            this.listBoxTickets.Size = new System.Drawing.Size(120, 95);
            this.listBoxTickets.TabIndex = 1;
            // 
            // labelTotalPassengers
            // 
            this.labelTotalPassengers.AutoSize = true;
            this.labelTotalPassengers.Location = new System.Drawing.Point(322, 13);
            this.labelTotalPassengers.Name = "labelTotalPassengers";
            this.labelTotalPassengers.Size = new System.Drawing.Size(35, 13);
            this.labelTotalPassengers.TabIndex = 2;
            this.labelTotalPassengers.Text = "label1";
            // 
            // FormSoldTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalPassengers);
            this.Controls.Add(this.listBoxTickets);
            this.Controls.Add(this.labelFlightInfo);
            this.Name = "FormSoldTickets";
            this.Text = "FormSoldTickets";
            this.Load += new System.EventHandler(this.FormSoldTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFlightInfo;
        private System.Windows.Forms.ListBox listBoxTickets;
        private System.Windows.Forms.Label labelTotalPassengers;
    }
}