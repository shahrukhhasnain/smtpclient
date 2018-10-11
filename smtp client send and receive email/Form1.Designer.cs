namespace smtp_client_send_and_receive_email
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
            this.TOtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SUBJECTtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MESSAGEtextBox = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.SENDbutton = new System.Windows.Forms.Button();
            this.RECEIVEbutton = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TO";
            // 
            // TOtextBox
            // 
            this.TOtextBox.Location = new System.Drawing.Point(89, 22);
            this.TOtextBox.Name = "TOtextBox";
            this.TOtextBox.Size = new System.Drawing.Size(472, 20);
            this.TOtextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SUBJECT";
            // 
            // SUBJECTtextBox
            // 
            this.SUBJECTtextBox.Location = new System.Drawing.Point(89, 50);
            this.SUBJECTtextBox.Name = "SUBJECTtextBox";
            this.SUBJECTtextBox.Size = new System.Drawing.Size(472, 20);
            this.SUBJECTtextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "MESSAGE";
            // 
            // MESSAGEtextBox
            // 
            this.MESSAGEtextBox.Location = new System.Drawing.Point(89, 79);
            this.MESSAGEtextBox.Multiline = true;
            this.MESSAGEtextBox.Name = "MESSAGEtextBox";
            this.MESSAGEtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MESSAGEtextBox.Size = new System.Drawing.Size(472, 78);
            this.MESSAGEtextBox.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(373, 197);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(188, 198);
            this.webBrowser.TabIndex = 2;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Sender,
            this.DateTime,
            this.body});
            this.dataGrid.Location = new System.Drawing.Point(12, 197);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(345, 186);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // SENDbutton
            // 
            this.SENDbutton.Location = new System.Drawing.Point(477, 163);
            this.SENDbutton.Name = "SENDbutton";
            this.SENDbutton.Size = new System.Drawing.Size(75, 23);
            this.SENDbutton.TabIndex = 3;
            this.SENDbutton.Text = "SEND";
            this.SENDbutton.UseVisualStyleBackColor = true;
            this.SENDbutton.Click += new System.EventHandler(this.SENDbutton_Click);
            // 
            // RECEIVEbutton
            // 
            this.RECEIVEbutton.Location = new System.Drawing.Point(477, 401);
            this.RECEIVEbutton.Name = "RECEIVEbutton";
            this.RECEIVEbutton.Size = new System.Drawing.Size(75, 23);
            this.RECEIVEbutton.TabIndex = 4;
            this.RECEIVEbutton.Text = "RECEIVE";
            this.RECEIVEbutton.UseVisualStyleBackColor = true;
            this.RECEIVEbutton.Click += new System.EventHandler(this.RECEIVEbutton_Click);
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // Sender
            // 
            this.Sender.DataPropertyName = "sender";
            this.Sender.HeaderText = "Sender";
            this.Sender.Name = "Sender";
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "Date";
            this.DateTime.HeaderText = "DateTime";
            this.DateTime.Name = "DateTime";
            // 
            // body
            // 
            this.body.DataPropertyName = "body";
            this.body.HeaderText = "body";
            this.body.Name = "body";
            this.body.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 435);
            this.Controls.Add(this.RECEIVEbutton);
            this.Controls.Add(this.SENDbutton);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.MESSAGEtextBox);
            this.Controls.Add(this.SUBJECTtextBox);
            this.Controls.Add(this.TOtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TOtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SUBJECTtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MESSAGEtextBox;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button SENDbutton;
        private System.Windows.Forms.Button RECEIVEbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn body;
    }
}

