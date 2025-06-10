namespace AirlineTicketSales
{
    partial class AirTicketOffice
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAvailableFlights = new System.Windows.Forms.ListBox();
            this.listBoxSelectedFlights = new System.Windows.Forms.ListBox();
            this.buttonAddFlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAvailableFlights
            // 
            this.listBoxAvailableFlights.FormattingEnabled = true;
            this.listBoxAvailableFlights.Location = new System.Drawing.Point(49, 49);
            this.listBoxAvailableFlights.Name = "listBoxAvailableFlights";
            this.listBoxAvailableFlights.Size = new System.Drawing.Size(245, 251);
            this.listBoxAvailableFlights.TabIndex = 0;
            this.listBoxAvailableFlights.SelectedIndexChanged += new System.EventHandler(this.listBoxAvailableFlights_SelectedIndexChanged);
            // 
            // listBoxSelectedFlights
            // 
            this.listBoxSelectedFlights.FormattingEnabled = true;
            this.listBoxSelectedFlights.Location = new System.Drawing.Point(559, 49);
            this.listBoxSelectedFlights.Name = "listBoxSelectedFlights";
            this.listBoxSelectedFlights.Size = new System.Drawing.Size(190, 251);
            this.listBoxSelectedFlights.TabIndex = 1;
            // 
            // buttonAddFlight
            // 
            this.buttonAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddFlight.Location = new System.Drawing.Point(103, 331);
            this.buttonAddFlight.Name = "buttonAddFlight";
            this.buttonAddFlight.Size = new System.Drawing.Size(141, 43);
            this.buttonAddFlight.TabIndex = 2;
            this.buttonAddFlight.Text = "Добавить рейс";
            this.buttonAddFlight.UseVisualStyleBackColor = true;
            this.buttonAddFlight.Click += new System.EventHandler(this.buttonAddFlight_Click);
            // 
            // AirTicketOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddFlight);
            this.Controls.Add(this.listBoxSelectedFlights);
            this.Controls.Add(this.listBoxAvailableFlights);
            this.Name = "AirTicketOffice";
            this.Text = "AirTicketOffice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailableFlights;
        private System.Windows.Forms.ListBox listBoxSelectedFlights;
        private System.Windows.Forms.Button buttonAddFlight;
    }
}

