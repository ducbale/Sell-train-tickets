namespace pbl3
{
    partial class employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnout = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.PictureBox();
            this.ticket = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.infor = new System.Windows.Forms.PictureBox();
            this.train = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.train)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(339, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 51);
            this.label5.TabIndex = 8;
            this.label5.Text = "WELLCOME TO DANANG RAILWAY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên";
            // 
            // btnout
            // 
            this.btnout.Location = new System.Drawing.Point(793, 22);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(75, 23);
            this.btnout.TabIndex = 14;
            this.btnout.Text = "logout";
            this.btnout.UseVisualStyleBackColor = true;
            // 
            // customer
            // 
            this.customer.Image = ((System.Drawing.Image)(resources.GetObject("customer.Image")));
            this.customer.Location = new System.Drawing.Point(715, 226);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(159, 128);
            this.customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customer.TabIndex = 18;
            this.customer.TabStop = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // ticket
            // 
            this.ticket.Image = ((System.Drawing.Image)(resources.GetObject("ticket.Image")));
            this.ticket.Location = new System.Drawing.Point(528, 226);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(181, 128);
            this.ticket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ticket.TabIndex = 15;
            this.ticket.TabStop = false;
            this.ticket.Click += new System.EventHandler(this.ticket_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(359, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // infor
            // 
            this.infor.Image = ((System.Drawing.Image)(resources.GetObject("infor.Image")));
            this.infor.Location = new System.Drawing.Point(528, 92);
            this.infor.Name = "infor";
            this.infor.Size = new System.Drawing.Size(181, 128);
            this.infor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infor.TabIndex = 17;
            this.infor.TabStop = false;
            this.infor.Click += new System.EventHandler(this.infor_Click);
            // 
            // train
            // 
            this.train.Image = ((System.Drawing.Image)(resources.GetObject("train.Image")));
            this.train.Location = new System.Drawing.Point(715, 92);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(159, 128);
            this.train.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.train.TabIndex = 16;
            this.train.TabStop = false;
            // 
            // employee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(950, 528);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.infor);
            this.Controls.Add(this.train);
            this.Controls.Add(this.ticket);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Name = "employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.train)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.PictureBox ticket;
        private System.Windows.Forms.PictureBox customer;
        private System.Windows.Forms.PictureBox infor;
        private System.Windows.Forms.PictureBox train;
    }
}

