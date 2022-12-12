namespace BoutilierLab4
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
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSelectLocation = new System.Windows.Forms.GroupBox();
            this.chkFlightIncluded = new System.Windows.Forms.CheckBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTripInformation = new System.Windows.Forms.GroupBox();
            this.lblTripInformation = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpBook.SuspendLayout();
            this.grpSelectLocation.SuspendLayout();
            this.grpTripInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.lblPrice);
            this.grpBook.Controls.Add(this.label3);
            this.grpBook.Controls.Add(this.btnBook);
            this.grpBook.Controls.Add(this.btnReset);
            this.grpBook.Controls.Add(this.grpSelectLocation);
            this.grpBook.Controls.Add(this.radCash);
            this.grpBook.Controls.Add(this.radCreditCard);
            this.grpBook.Controls.Add(this.txtPeople);
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Location = new System.Drawing.Point(11, 24);
            this.grpBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBook.Name = "grpBook";
            this.grpBook.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBook.Size = new System.Drawing.Size(187, 300);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(54, 232);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(127, 22);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(87, 261);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 32);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 261);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpSelectLocation
            // 
            this.grpSelectLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpSelectLocation.Controls.Add(this.chkFlightIncluded);
            this.grpSelectLocation.Controls.Add(this.radMexico);
            this.grpSelectLocation.Controls.Add(this.radFlorida);
            this.grpSelectLocation.Controls.Add(this.radCuba);
            this.grpSelectLocation.Location = new System.Drawing.Point(6, 49);
            this.grpSelectLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelectLocation.Name = "grpSelectLocation";
            this.grpSelectLocation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelectLocation.Size = new System.Drawing.Size(154, 128);
            this.grpSelectLocation.TabIndex = 1;
            this.grpSelectLocation.TabStop = false;
            this.grpSelectLocation.Text = "Select Location";
            // 
            // chkFlightIncluded
            // 
            this.chkFlightIncluded.AutoCheck = false;
            this.chkFlightIncluded.AutoSize = true;
            this.chkFlightIncluded.Checked = true;
            this.chkFlightIncluded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlightIncluded.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFlightIncluded.Enabled = false;
            this.chkFlightIncluded.Location = new System.Drawing.Point(7, 98);
            this.chkFlightIncluded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFlightIncluded.Name = "chkFlightIncluded";
            this.chkFlightIncluded.Size = new System.Drawing.Size(122, 19);
            this.chkFlightIncluded.TabIndex = 1;
            this.chkFlightIncluded.TabStop = false;
            this.chkFlightIncluded.Text = "Flight Included";
            this.chkFlightIncluded.UseVisualStyleBackColor = true;
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.Location = new System.Drawing.Point(6, 72);
            this.radMexico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(71, 19);
            this.radMexico.TabIndex = 2;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = true;
            this.radMexico.CheckedChanged += new System.EventHandler(this.radMexico_CheckedChanged);
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.Location = new System.Drawing.Point(7, 48);
            this.radFlorida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(71, 19);
            this.radFlorida.TabIndex = 1;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = true;
            this.radFlorida.CheckedChanged += new System.EventHandler(this.radFlorida_CheckedChanged);
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.Location = new System.Drawing.Point(7, 22);
            this.radCuba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(59, 19);
            this.radCuba.TabIndex = 0;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = true;
            this.radCuba.CheckedChanged += new System.EventHandler(this.radCuba_CheckedChanged);
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(6, 208);
            this.radCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(58, 19);
            this.radCash.TabIndex = 3;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Location = new System.Drawing.Point(6, 182);
            this.radCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(101, 19);
            this.radCreditCard.TabIndex = 2;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            // 
            // txtPeople
            // 
            this.txtPeople.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeople.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPeople.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPeople.Location = new System.Drawing.Point(69, 19);
            this.txtPeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 23);
            this.txtPeople.TabIndex = 0;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "People:";
            // 
            // grpTripInformation
            // 
            this.grpTripInformation.Controls.Add(this.lblTripInformation);
            this.grpTripInformation.Controls.Add(this.btnConfirm);
            this.grpTripInformation.Location = new System.Drawing.Point(215, 24);
            this.grpTripInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTripInformation.Name = "grpTripInformation";
            this.grpTripInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTripInformation.Size = new System.Drawing.Size(267, 300);
            this.grpTripInformation.TabIndex = 1;
            this.grpTripInformation.TabStop = false;
            this.grpTripInformation.Text = "Trip Information";
            // 
            // lblTripInformation
            // 
            this.lblTripInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTripInformation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripInformation.Location = new System.Drawing.Point(6, 19);
            this.lblTripInformation.Name = "lblTripInformation";
            this.lblTripInformation.Size = new System.Drawing.Size(255, 235);
            this.lblTripInformation.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(101, 261);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 32);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(494, 336);
            this.Controls.Add(this.grpTripInformation);
            this.Controls.Add(this.grpBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by Michelle Boutilier";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpSelectLocation.ResumeLayout(false);
            this.grpSelectLocation.PerformLayout();
            this.grpTripInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSelectLocation;
        private System.Windows.Forms.CheckBox chkFlightIncluded;
        private System.Windows.Forms.RadioButton radMexico;
        private System.Windows.Forms.RadioButton radFlorida;
        private System.Windows.Forms.RadioButton radCuba;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTripInformation;
        private System.Windows.Forms.Label lblTripInformation;
        private System.Windows.Forms.Button btnConfirm;
    }
}

