
namespace ThreePartTimer
{
    partial class MainForm
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
            this.t1_label = new System.Windows.Forms.Label();
            this.t3_label = new System.Windows.Forms.Label();
            this.t2_label = new System.Windows.Forms.Label();
            this.dynam_t1_label = new System.Windows.Forms.Label();
            this.dynam_t2_label = new System.Windows.Forms.Label();
            this.dynam_t3_label = new System.Windows.Forms.Label();
            this.t1_startstop_btn = new System.Windows.Forms.Button();
            this.t2_startstop_btn = new System.Windows.Forms.Button();
            this.t3_startstop_btn = new System.Windows.Forms.Button();
            this.t3_reset_btn = new System.Windows.Forms.Button();
            this.t2_reset_btn = new System.Windows.Forms.Button();
            this.t1_reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t1_label
            // 
            this.t1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1_label.ForeColor = System.Drawing.SystemColors.Window;
            this.t1_label.Location = new System.Drawing.Point(18, 17);
            this.t1_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.t1_label.Name = "t1_label";
            this.t1_label.Size = new System.Drawing.Size(330, 55);
            this.t1_label.TabIndex = 1;
            this.t1_label.Text = "Timer 1  Label";
            this.t1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t3_label
            // 
            this.t3_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3_label.ForeColor = System.Drawing.SystemColors.Window;
            this.t3_label.Location = new System.Drawing.Point(944, 17);
            this.t3_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.t3_label.Name = "t3_label";
            this.t3_label.Size = new System.Drawing.Size(330, 55);
            this.t3_label.TabIndex = 2;
            this.t3_label.Text = "Timer 3  Label";
            this.t3_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t2_label
            // 
            this.t2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2_label.ForeColor = System.Drawing.SystemColors.Window;
            this.t2_label.Location = new System.Drawing.Point(484, 17);
            this.t2_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.t2_label.Name = "t2_label";
            this.t2_label.Size = new System.Drawing.Size(330, 55);
            this.t2_label.TabIndex = 3;
            this.t2_label.Text = "Timer 2  Label";
            this.t2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dynam_t1_label
            // 
            this.dynam_t1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynam_t1_label.ForeColor = System.Drawing.SystemColors.Window;
            this.dynam_t1_label.Location = new System.Drawing.Point(116, 98);
            this.dynam_t1_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dynam_t1_label.Name = "dynam_t1_label";
            this.dynam_t1_label.Size = new System.Drawing.Size(135, 44);
            this.dynam_t1_label.TabIndex = 4;
            this.dynam_t1_label.Text = "00:00";
            this.dynam_t1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dynam_t2_label
            // 
            this.dynam_t2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynam_t2_label.ForeColor = System.Drawing.SystemColors.Window;
            this.dynam_t2_label.Location = new System.Drawing.Point(582, 98);
            this.dynam_t2_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dynam_t2_label.Name = "dynam_t2_label";
            this.dynam_t2_label.Size = new System.Drawing.Size(135, 44);
            this.dynam_t2_label.TabIndex = 5;
            this.dynam_t2_label.Text = "00:00";
            this.dynam_t2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dynam_t3_label
            // 
            this.dynam_t3_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynam_t3_label.ForeColor = System.Drawing.SystemColors.Window;
            this.dynam_t3_label.Location = new System.Drawing.Point(1042, 98);
            this.dynam_t3_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dynam_t3_label.Name = "dynam_t3_label";
            this.dynam_t3_label.Size = new System.Drawing.Size(135, 44);
            this.dynam_t3_label.TabIndex = 6;
            this.dynam_t3_label.Text = "00:00";
            this.dynam_t3_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t1_startstop_btn
            // 
            this.t1_startstop_btn.Location = new System.Drawing.Point(105, 167);
            this.t1_startstop_btn.Margin = new System.Windows.Forms.Padding(6);
            this.t1_startstop_btn.Name = "t1_startstop_btn";
            this.t1_startstop_btn.Size = new System.Drawing.Size(156, 37);
            this.t1_startstop_btn.TabIndex = 7;
            this.t1_startstop_btn.Text = "Start";
            this.t1_startstop_btn.UseVisualStyleBackColor = true;
            this.t1_startstop_btn.Click += new System.EventHandler(this.t1_startstop_btn_Click);
            // 
            // t2_startstop_btn
            // 
            this.t2_startstop_btn.Location = new System.Drawing.Point(571, 167);
            this.t2_startstop_btn.Margin = new System.Windows.Forms.Padding(6);
            this.t2_startstop_btn.Name = "t2_startstop_btn";
            this.t2_startstop_btn.Size = new System.Drawing.Size(156, 37);
            this.t2_startstop_btn.TabIndex = 8;
            this.t2_startstop_btn.Text = "Start";
            this.t2_startstop_btn.UseVisualStyleBackColor = true;
            this.t2_startstop_btn.Click += new System.EventHandler(this.t2_startstop_btn_Click);
            // 
            // t3_startstop_btn
            // 
            this.t3_startstop_btn.Location = new System.Drawing.Point(1031, 167);
            this.t3_startstop_btn.Margin = new System.Windows.Forms.Padding(6);
            this.t3_startstop_btn.Name = "t3_startstop_btn";
            this.t3_startstop_btn.Size = new System.Drawing.Size(156, 37);
            this.t3_startstop_btn.TabIndex = 9;
            this.t3_startstop_btn.Text = "Start";
            this.t3_startstop_btn.UseVisualStyleBackColor = true;
            this.t3_startstop_btn.Click += new System.EventHandler(this.t3_startstop_btn_Click);
            // 
            // t3_reset_btn
            // 
            this.t3_reset_btn.Location = new System.Drawing.Point(1031, 208);
            this.t3_reset_btn.Margin = new System.Windows.Forms.Padding(6);
            this.t3_reset_btn.Name = "t3_reset_btn";
            this.t3_reset_btn.Size = new System.Drawing.Size(156, 37);
            this.t3_reset_btn.TabIndex = 12;
            this.t3_reset_btn.Text = "Reset";
            this.t3_reset_btn.UseVisualStyleBackColor = true;
            this.t3_reset_btn.Click += new System.EventHandler(this.t3_reset_btn_Click);
            // 
            // t2_reset_btn
            // 
            this.t2_reset_btn.Location = new System.Drawing.Point(571, 208);
            this.t2_reset_btn.Margin = new System.Windows.Forms.Padding(6);
            this.t2_reset_btn.Name = "t2_reset_btn";
            this.t2_reset_btn.Size = new System.Drawing.Size(156, 37);
            this.t2_reset_btn.TabIndex = 11;
            this.t2_reset_btn.Text = "Reset";
            this.t2_reset_btn.UseVisualStyleBackColor = true;
            this.t2_reset_btn.Click += new System.EventHandler(this.t2_reset_btn_Click);
            // 
            // t1_reset_btn
            // 
            this.t1_reset_btn.Location = new System.Drawing.Point(105, 208);
            this.t1_reset_btn.Margin = new System.Windows.Forms.Padding(6);
            this.t1_reset_btn.Name = "t1_reset_btn";
            this.t1_reset_btn.Size = new System.Drawing.Size(156, 37);
            this.t1_reset_btn.TabIndex = 10;
            this.t1_reset_btn.Text = "Reset";
            this.t1_reset_btn.UseVisualStyleBackColor = true;
            this.t1_reset_btn.Click += new System.EventHandler(this.t1_reset_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1331, 267);
            this.Controls.Add(this.t3_reset_btn);
            this.Controls.Add(this.t2_reset_btn);
            this.Controls.Add(this.t1_reset_btn);
            this.Controls.Add(this.t3_startstop_btn);
            this.Controls.Add(this.t2_startstop_btn);
            this.Controls.Add(this.t1_startstop_btn);
            this.Controls.Add(this.dynam_t3_label);
            this.Controls.Add(this.dynam_t2_label);
            this.Controls.Add(this.dynam_t1_label);
            this.Controls.Add(this.t2_label);
            this.Controls.Add(this.t3_label);
            this.Controls.Add(this.t1_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Three Part Timer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label t1_label;
        private System.Windows.Forms.Label t3_label;
        private System.Windows.Forms.Label t2_label;
        private System.Windows.Forms.Label dynam_t1_label;
        private System.Windows.Forms.Label dynam_t2_label;
        private System.Windows.Forms.Label dynam_t3_label;
        private System.Windows.Forms.Button t1_startstop_btn;
        private System.Windows.Forms.Button t2_startstop_btn;
        private System.Windows.Forms.Button t3_startstop_btn;
        private System.Windows.Forms.Button t3_reset_btn;
        private System.Windows.Forms.Button t2_reset_btn;
        private System.Windows.Forms.Button t1_reset_btn;
    }
}

