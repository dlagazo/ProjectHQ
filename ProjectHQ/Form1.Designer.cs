namespace ProjectHQ
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
            this.components = new System.ComponentModel.Container();
            this.spCom = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.rtfData = new System.Windows.Forms.RichTextBox();
            this.rtfOutbox = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // spCom
            // 
            this.spCom.BaudRate = 57600;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(119, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(13, 13);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "COM1";
            // 
            // rtfData
            // 
            this.rtfData.Location = new System.Drawing.Point(13, 40);
            this.rtfData.Name = "rtfData";
            this.rtfData.ReadOnly = true;
            this.rtfData.Size = new System.Drawing.Size(325, 349);
            this.rtfData.TabIndex = 2;
            this.rtfData.Text = "";
            // 
            // rtfOutbox
            // 
            this.rtfOutbox.Location = new System.Drawing.Point(341, 40);
            this.rtfOutbox.Name = "rtfOutbox";
            this.rtfOutbox.Size = new System.Drawing.Size(325, 70);
            this.rtfOutbox.TabIndex = 3;
            this.rtfOutbox.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(591, 116);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 401);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtfOutbox);
            this.Controls.Add(this.rtfData);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort spCom;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.RichTextBox rtfData;
        private System.Windows.Forms.RichTextBox rtfOutbox;
        private System.Windows.Forms.Button btnSend;
    }
}

