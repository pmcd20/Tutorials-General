namespace DemoThread1
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
            this.btnRunThread = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.txtDemo = new System.Windows.Forms.TextBox();
            this.BtnCounter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRunThread
            // 
            this.btnRunThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunThread.Location = new System.Drawing.Point(45, 32);
            this.btnRunThread.Name = "btnRunThread";
            this.btnRunThread.Size = new System.Drawing.Size(176, 39);
            this.btnRunThread.TabIndex = 0;
            this.btnRunThread.Text = "Run long process";
            this.btnRunThread.UseVisualStyleBackColor = true;
            this.btnRunThread.Click += new System.EventHandler(this.btnRunThread_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(440, 51);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(18, 20);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "0";
            this.lblCounter.Click += new System.EventHandler(this.lblCounter_Click);
            // 
            // txtDemo
            // 
            this.txtDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemo.Location = new System.Drawing.Point(45, 96);
            this.txtDemo.Multiline = true;
            this.txtDemo.Name = "txtDemo";
            this.txtDemo.Size = new System.Drawing.Size(353, 274);
            this.txtDemo.TabIndex = 2;
            this.txtDemo.TextChanged += new System.EventHandler(this.txtDemo_TextChanged);
            // 
            // BtnCounter
            // 
            this.BtnCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCounter.Location = new System.Drawing.Point(248, 32);
            this.BtnCounter.Name = "BtnCounter";
            this.BtnCounter.Size = new System.Drawing.Size(150, 39);
            this.BtnCounter.TabIndex = 3;
            this.BtnCounter.Text = "Increment Counter";
            this.BtnCounter.UseVisualStyleBackColor = true;
            this.BtnCounter.Click += new System.EventHandler(this.BtnCounter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Counter Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quick demo to show A thread performing a long process will not cause the UI to lo" +
    "ck up ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Is also uses Delegate to come back to the  from the business class and \r\nthis exa" +
    "mple will update the UI by invoking the UI if its not on the UI thread";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCounter);
            this.Controls.Add(this.txtDemo);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnRunThread);
            this.Name = "Form1";
            this.Text = "Sample Background Thread";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunThread;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.TextBox txtDemo;
        private System.Windows.Forms.Button BtnCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

