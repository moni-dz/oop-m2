namespace oop_m2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.txtTicketMovie = new System.Windows.Forms.TextBox();
            this.txtTicketTime = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTicketDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMovie
            // 
            this.txtMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovie.Enabled = false;
            this.txtMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(212)))), ((int)(((byte)(169)))));
            this.txtMovie.Location = new System.Drawing.Point(173, 319);
            this.txtMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(469, 37);
            this.txtMovie.TabIndex = 132;
            this.txtMovie.Text = "movie name";
            this.txtMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMovie.TextChanged += new System.EventHandler(this.txtMovie_TextChanged);
            // 
            // txtDateTime
            // 
            this.txtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateTime.Enabled = false;
            this.txtDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(212)))), ((int)(((byte)(169)))));
            this.txtDateTime.Location = new System.Drawing.Point(173, 383);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(469, 37);
            this.txtDateTime.TabIndex = 133;
            this.txtDateTime.Text = "date, schedule";
            this.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateTime.TextChanged += new System.EventHandler(this.txtDateTime_TextChanged);
            // 
            // txtSeat
            // 
            this.txtSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeat.Enabled = false;
            this.txtSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(212)))), ((int)(((byte)(169)))));
            this.txtSeat.Location = new System.Drawing.Point(173, 463);
            this.txtSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(469, 37);
            this.txtSeat.TabIndex = 134;
            this.txtSeat.Text = "seat number";
            this.txtSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeat.TextChanged += new System.EventHandler(this.txtSeat_TextChanged);
            // 
            // labelCost
            // 
            this.labelCost.BackColor = System.Drawing.Color.White;
            this.labelCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(151)))));
            this.labelCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCost.Location = new System.Drawing.Point(267, 558);
            this.labelCost.Name = "labelCost";
            this.labelCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCost.Size = new System.Drawing.Size(277, 73);
            this.labelCost.TabIndex = 140;
            this.labelCost.Text = "total cost";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTicketMovie
            // 
            this.txtTicketMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTicketMovie.Enabled = false;
            this.txtTicketMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(212)))), ((int)(((byte)(169)))));
            this.txtTicketMovie.Location = new System.Drawing.Point(955, 401);
            this.txtTicketMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTicketMovie.Name = "txtTicketMovie";
            this.txtTicketMovie.Size = new System.Drawing.Size(176, 21);
            this.txtTicketMovie.TabIndex = 141;
            this.txtTicketMovie.Text = "movie name";
            this.txtTicketMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTicketMovie.TextChanged += new System.EventHandler(this.txtTicketMovie_TextChanged);
            // 
            // txtTicketTime
            // 
            this.txtTicketTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTicketTime.Enabled = false;
            this.txtTicketTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(212)))), ((int)(((byte)(169)))));
            this.txtTicketTime.Location = new System.Drawing.Point(955, 430);
            this.txtTicketTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTicketTime.Name = "txtTicketTime";
            this.txtTicketTime.Size = new System.Drawing.Size(176, 21);
            this.txtTicketTime.TabIndex = 142;
            this.txtTicketTime.Text = "schedule";
            this.txtTicketTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTicketTime.TextChanged += new System.EventHandler(this.txtTicketDateTime_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(212)))), ((int)(((byte)(169)))));
            this.textBox6.Location = new System.Drawing.Point(955, 458);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(176, 21);
            this.textBox6.TabIndex = 143;
            this.textBox6.Text = "seat number";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(151)))));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(88, 761);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(640, 33);
            this.label3.TabIndex = 144;
            this.label3.Text = " ★ just show your digital ticket for admission! ★";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTicketDate
            // 
            this.txtTicketDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.txtTicketDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTicketDate.Enabled = false;
            this.txtTicketDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.txtTicketDate.Location = new System.Drawing.Point(976, 343);
            this.txtTicketDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTicketDate.Name = "txtTicketDate";
            this.txtTicketDate.Size = new System.Drawing.Size(131, 21);
            this.txtTicketDate.TabIndex = 145;
            this.txtTicketDate.Text = "sample date";
            this.txtTicketDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTicketDate.TextChanged += new System.EventHandler(this.txtTicketDate_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1269, 958);
            this.Controls.Add(this.txtTicketDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtTicketTime);
            this.Controls.Add(this.txtTicketMovie);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.txtMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloverPass";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox txtTicketMovie;
        private System.Windows.Forms.TextBox txtTicketTime;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTicketDate;
    }
}