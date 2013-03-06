namespace Android_File_Tools
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDecompile = new System.Windows.Forms.Button();
            this.btnDirectOpen = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAbout, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDecompile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDirectOpen, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 185);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDecompile
            // 
            this.btnDecompile.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnDecompile.Location = new System.Drawing.Point(3, 3);
            this.btnDecompile.Name = "btnDecompile";
            this.btnDecompile.Size = new System.Drawing.Size(136, 86);
            this.btnDecompile.TabIndex = 0;
            this.btnDecompile.Text = "转换为JAR";
            this.btnDecompile.UseVisualStyleBackColor = true;
            this.btnDecompile.Click += new System.EventHandler(this.btnDecompile_Click);
            // 
            // btnDirectOpen
            // 
            this.btnDirectOpen.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnDirectOpen.Location = new System.Drawing.Point(145, 3);
            this.btnDirectOpen.Name = "btnDirectOpen";
            this.btnDirectOpen.Size = new System.Drawing.Size(136, 86);
            this.btnDirectOpen.TabIndex = 1;
            this.btnDirectOpen.Text = "转换并打开";
            this.btnDirectOpen.UseVisualStyleBackColor = true;
            this.btnDirectOpen.Click += new System.EventHandler(this.btnDirectOpen_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoEllipsis = true;
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblPath.Location = new System.Drawing.Point(-2, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(91, 17);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Show File Path";
            // 
            // lblType
            // 
            this.lblType.AutoEllipsis = true;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblType.Location = new System.Drawing.Point(-2, 26);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Show Type";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnExit.Location = new System.Drawing.Point(145, 95);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 86);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnAbout.Location = new System.Drawing.Point(3, 95);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(136, 86);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android File Tools";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnDecompile;
        private System.Windows.Forms.Button btnDirectOpen;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
    }
}

