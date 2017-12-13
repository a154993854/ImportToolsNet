namespace ImportToolsNet.Base
{
    partial class Frm_ypinfo_Base
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
            this.panel_head = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_openfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_import = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_path = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DGV_Choose = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel_head.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_import)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Choose)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.groupBox1);
            this.panel_head.Location = new System.Drawing.Point(1, 2);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(1097, 60);
            this.panel_head.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_openfile);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Bt_openfile
            // 
            this.Bt_openfile.Location = new System.Drawing.Point(15, 16);
            this.Bt_openfile.Name = "Bt_openfile";
            this.Bt_openfile.Size = new System.Drawing.Size(150, 23);
            this.Bt_openfile.TabIndex = 0;
            this.Bt_openfile.Text = "打开文件";
            this.Bt_openfile.UseVisualStyleBackColor = true;
            this.Bt_openfile.Click += new System.EventHandler(this.Bt_openfile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(1, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 466);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_import);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 463);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据";
            // 
            // DGV_import
            // 
            this.DGV_import.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_import.Location = new System.Drawing.Point(3, 20);
            this.DGV_import.Name = "DGV_import";
            this.DGV_import.RowTemplate.Height = 23;
            this.DGV_import.Size = new System.Drawing.Size(775, 437);
            this.DGV_import.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_path);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Location = new System.Drawing.Point(3, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 74);
            this.panel2.TabIndex = 2;
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(6, 6);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(0, 12);
            this.lb_path.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 41);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(728, 23);
            this.progressBar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.DGV_Choose);
            this.panel3.Location = new System.Drawing.Point(794, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 566);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始传输";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV_Choose
            // 
            this.DGV_Choose.AllowUserToAddRows = false;
            this.DGV_Choose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Choose.Location = new System.Drawing.Point(3, 3);
            this.DGV_Choose.Name = "DGV_Choose";
            this.DGV_Choose.RowTemplate.Height = 23;
            this.DGV_Choose.Size = new System.Drawing.Size(298, 454);
            this.DGV_Choose.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(1, 540);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(784, 94);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Frm_ypinfo_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 646);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_head);
            this.Name = "Frm_ypinfo_Base";
            this.Text = "Frm_ypinfo_Base";
            this.panel_head.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_import)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Choose)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Bt_openfile;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_import;
        private System.Windows.Forms.DataGridView DGV_Choose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}