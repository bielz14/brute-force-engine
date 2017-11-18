namespace brut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.comboBoxTypeProxy = new System.Windows.Forms.ComboBox();
            this.viewSuccesfull = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.base_label = new System.Windows.Forms.Label();
            this.base_data_label = new System.Windows.Forms.Label();
            this.proxy_label = new System.Windows.Forms.Label();
            this.proxy_data_label = new System.Windows.Forms.Label();
            this.threads_label = new System.Windows.Forms.Label();
            this.threads_data_label = new System.Windows.Forms.Label();
            this.bads_label = new System.Windows.Forms.Label();
            this.bads_data_label = new System.Windows.Forms.Label();
            this.blocked_label = new System.Windows.Forms.Label();
            this.blocked_data_label = new System.Windows.Forms.Label();
            this.errors_label = new System.Windows.Forms.Label();
            this.errors_data_label = new System.Windows.Forms.Label();
            this.trackBarThreads = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.viewSuccesfull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(59, 461);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(140, 461);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 1;
            this.btn_pause.Text = "PAUSE";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(221, 461);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(302, 461);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 3;
            this.btn_test.Text = "TEST";
            this.btn_test.UseVisualStyleBackColor = true;
            // 
            // comboBoxTypeProxy
            // 
            this.comboBoxTypeProxy.FormattingEnabled = true;
            this.comboBoxTypeProxy.Items.AddRange(new object[] {
            "HTTP",
            "Socks4",
            "Socks5"});
            this.comboBoxTypeProxy.Location = new System.Drawing.Point(59, 155);
            this.comboBoxTypeProxy.Name = "comboBoxTypeProxy";
            this.comboBoxTypeProxy.Size = new System.Drawing.Size(318, 21);
            this.comboBoxTypeProxy.TabIndex = 5;
            this.comboBoxTypeProxy.Text = "HTTP";
            // 
            // viewSuccesfull
            // 
            this.viewSuccesfull.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.viewSuccesfull.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewSuccesfull.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewSuccesfull.ColumnHeadersHeight = 30;
            this.viewSuccesfull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewSuccesfull.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.viewSuccesfull.Location = new System.Drawing.Point(59, 182);
            this.viewSuccesfull.Name = "viewSuccesfull";
            this.viewSuccesfull.ReadOnly = true;
            this.viewSuccesfull.RowHeadersWidth = 116;
            this.viewSuccesfull.Size = new System.Drawing.Size(318, 273);
            this.viewSuccesfull.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Login";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Password";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // base_label
            // 
            this.base_label.AutoSize = true;
            this.base_label.Location = new System.Drawing.Point(56, 13);
            this.base_label.Name = "base_label";
            this.base_label.Size = new System.Drawing.Size(31, 13);
            this.base_label.TabIndex = 7;
            this.base_label.Text = "Base";
            // 
            // base_data_label
            // 
            this.base_data_label.AutoSize = true;
            this.base_data_label.Location = new System.Drawing.Point(148, 13);
            this.base_data_label.Name = "base_data_label";
            this.base_data_label.Size = new System.Drawing.Size(13, 13);
            this.base_data_label.TabIndex = 8;
            this.base_data_label.Text = "0";
            // 
            // proxy_label
            // 
            this.proxy_label.AutoSize = true;
            this.proxy_label.Location = new System.Drawing.Point(56, 40);
            this.proxy_label.Name = "proxy_label";
            this.proxy_label.Size = new System.Drawing.Size(33, 13);
            this.proxy_label.TabIndex = 9;
            this.proxy_label.Text = "Proxy";
            // 
            // proxy_data_label
            // 
            this.proxy_data_label.AutoSize = true;
            this.proxy_data_label.Location = new System.Drawing.Point(148, 40);
            this.proxy_data_label.Name = "proxy_data_label";
            this.proxy_data_label.Size = new System.Drawing.Size(13, 13);
            this.proxy_data_label.TabIndex = 10;
            this.proxy_data_label.Text = "0";
            // 
            // threads_label
            // 
            this.threads_label.AutoSize = true;
            this.threads_label.Location = new System.Drawing.Point(56, 67);
            this.threads_label.Name = "threads_label";
            this.threads_label.Size = new System.Drawing.Size(46, 13);
            this.threads_label.TabIndex = 11;
            this.threads_label.Text = "Threads";
            // 
            // threads_data_label
            // 
            this.threads_data_label.AutoSize = true;
            this.threads_data_label.Location = new System.Drawing.Point(148, 67);
            this.threads_data_label.MaximumSize = new System.Drawing.Size(1000, 0);
            this.threads_data_label.Name = "threads_data_label";
            this.threads_data_label.Size = new System.Drawing.Size(13, 13);
            this.threads_data_label.TabIndex = 12;
            this.threads_data_label.Text = "0";
            // 
            // bads_label
            // 
            this.bads_label.AutoSize = true;
            this.bads_label.Location = new System.Drawing.Point(284, 13);
            this.bads_label.Name = "bads_label";
            this.bads_label.Size = new System.Drawing.Size(31, 13);
            this.bads_label.TabIndex = 13;
            this.bads_label.Text = "Bads";
            // 
            // bads_data_label
            // 
            this.bads_data_label.AutoSize = true;
            this.bads_data_label.Location = new System.Drawing.Point(364, 13);
            this.bads_data_label.Name = "bads_data_label";
            this.bads_data_label.Size = new System.Drawing.Size(13, 13);
            this.bads_data_label.TabIndex = 14;
            this.bads_data_label.Text = "0";
            // 
            // blocked_label
            // 
            this.blocked_label.AutoSize = true;
            this.blocked_label.Location = new System.Drawing.Point(284, 40);
            this.blocked_label.Name = "blocked_label";
            this.blocked_label.Size = new System.Drawing.Size(46, 13);
            this.blocked_label.TabIndex = 15;
            this.blocked_label.Text = "Blocked";
            // 
            // blocked_data_label
            // 
            this.blocked_data_label.AutoSize = true;
            this.blocked_data_label.Location = new System.Drawing.Point(364, 40);
            this.blocked_data_label.Name = "blocked_data_label";
            this.blocked_data_label.Size = new System.Drawing.Size(13, 13);
            this.blocked_data_label.TabIndex = 16;
            this.blocked_data_label.Text = "0";
            // 
            // errors_label
            // 
            this.errors_label.AutoSize = true;
            this.errors_label.Location = new System.Drawing.Point(284, 67);
            this.errors_label.Name = "errors_label";
            this.errors_label.Size = new System.Drawing.Size(34, 13);
            this.errors_label.TabIndex = 17;
            this.errors_label.Text = "Errors";
            // 
            // errors_data_label
            // 
            this.errors_data_label.AutoSize = true;
            this.errors_data_label.Location = new System.Drawing.Point(364, 67);
            this.errors_data_label.Name = "errors_data_label";
            this.errors_data_label.Size = new System.Drawing.Size(13, 13);
            this.errors_data_label.TabIndex = 18;
            this.errors_data_label.Text = "0";
            // 
            // trackBarThreads
            // 
            this.trackBarThreads.Location = new System.Drawing.Point(59, 104);
            this.trackBarThreads.Maximum = 100;
            this.trackBarThreads.Name = "trackBarThreads";
            this.trackBarThreads.Size = new System.Drawing.Size(318, 45);
            this.trackBarThreads.TabIndex = 19;
            this.trackBarThreads.Scroll += new System.EventHandler(this.trackBarThreads_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 496);
            this.Controls.Add(this.trackBarThreads);
            this.Controls.Add(this.errors_data_label);
            this.Controls.Add(this.errors_label);
            this.Controls.Add(this.blocked_data_label);
            this.Controls.Add(this.blocked_label);
            this.Controls.Add(this.bads_data_label);
            this.Controls.Add(this.bads_label);
            this.Controls.Add(this.threads_data_label);
            this.Controls.Add(this.threads_label);
            this.Controls.Add(this.proxy_data_label);
            this.Controls.Add(this.proxy_label);
            this.Controls.Add(this.base_data_label);
            this.Controls.Add(this.base_label);
            this.Controls.Add(this.viewSuccesfull);
            this.Controls.Add(this.comboBoxTypeProxy);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.viewSuccesfull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.ComboBox comboBoxTypeProxy;
        private System.Windows.Forms.Label base_label;
        private System.Windows.Forms.Label base_data_label;
        private System.Windows.Forms.Label proxy_label;
        private System.Windows.Forms.Label proxy_data_label;
        private System.Windows.Forms.Label threads_label;
        private System.Windows.Forms.Label threads_data_label;
        private System.Windows.Forms.Label bads_label;
        private System.Windows.Forms.Label bads_data_label;
        private System.Windows.Forms.Label blocked_label;
        private System.Windows.Forms.Label blocked_data_label;
        private System.Windows.Forms.Label errors_label;
        private System.Windows.Forms.Label errors_data_label;
        private System.Windows.Forms.TrackBar trackBarThreads;
        private System.Windows.Forms.DataGridView viewSuccesfull;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

