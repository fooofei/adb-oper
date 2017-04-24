namespace AdbOper
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
            this.listDevices = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtAdbLocation = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.txtAdbHistory = new CCWin.SkinControl.SkinTextBox();
            this.btnReboot = new CCWin.SkinControl.SkinButton();
            this.btnRebootbootloader = new CCWin.SkinControl.SkinButton();
            this.btnRebootRecovery = new CCWin.SkinControl.SkinButton();
            this.btnClean = new CCWin.SkinControl.SkinButton();
            this.skinTextBox1.SuspendLayout();
            this.skinTextBox2.SuspendLayout();
            this.txtAdbHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDevices
            // 
            this.listDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listDevices.FullRowSelect = true;
            this.listDevices.HideSelection = false;
            this.listDevices.Location = new System.Drawing.Point(15, 173);
            this.listDevices.Name = "listDevices";
            this.listDevices.ShowItemToolTips = true;
            this.listDevices.Size = new System.Drawing.Size(104, 110);
            this.listDevices.TabIndex = 5;
            this.listDevices.UseCompatibleStateImageBehavior = false;
            this.listDevices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Devices";
            this.columnHeader1.Width = 100;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(8, 36);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(275, 17);
            this.skinLabel1.TabIndex = 6;
            this.skinLabel1.Text = "Here is Adb.exe Local Path On Your Windows.";
            // 
            // txtAdbLocation
            // 
            this.txtAdbLocation.Location = new System.Drawing.Point(15, 52);
            this.txtAdbLocation.Name = "txtAdbLocation";
            this.txtAdbLocation.Size = new System.Drawing.Size(423, 21);
            this.txtAdbLocation.TabIndex = 7;
            this.txtAdbLocation.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtAdbLocation.WaterText = "";
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.AllowDrop = true;
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Location = new System.Drawing.Point(15, 84);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.Size = new System.Drawing.Size(195, 80);
            // 
            // skinTextBox1.BaseText
            // 
            this.skinTextBox1.SkinTxt.AllowDrop = true;
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.ReadOnly = true;
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(185, 70);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "\r\nDrag APK File Here\r\n   To Install";
            this.skinTextBox1.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.SkinTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDragInstall_DragDrop);
            this.skinTextBox1.SkinTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDragInstall_DragEnter);
            this.skinTextBox1.TabIndex = 0;
            this.skinTextBox1.TabStop = false;
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.AllowDrop = true;
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Location = new System.Drawing.Point(243, 84);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.Size = new System.Drawing.Size(195, 80);
            // 
            // skinTextBox2.BaseText
            // 
            this.skinTextBox2.SkinTxt.AllowDrop = true;
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Multiline = true;
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.ReadOnly = true;
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(185, 70);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.Text = "\r\nDrag APK File Here\r\n    To Uninstall";
            this.skinTextBox2.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.SkinTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDragUninstall_DragDrop);
            this.skinTextBox2.SkinTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDragUninstall_DragEnter);
            this.skinTextBox2.TabIndex = 0;
            this.skinTextBox2.TabStop = false;
            this.skinTextBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDragUninstall_DragDrop);
            this.skinTextBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDragUninstall_DragEnter);
            // 
            // txtAdbHistory
            // 
            this.txtAdbHistory.AllowDrop = true;
            this.txtAdbHistory.BackColor = System.Drawing.Color.Transparent;
            this.txtAdbHistory.Icon = null;
            this.txtAdbHistory.IconIsButton = false;
            this.txtAdbHistory.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtAdbHistory.Location = new System.Drawing.Point(132, 173);
            this.txtAdbHistory.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdbHistory.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtAdbHistory.MouseBack = null;
            this.txtAdbHistory.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtAdbHistory.Name = "txtAdbHistory";
            this.txtAdbHistory.NormlBack = null;
            this.txtAdbHistory.Padding = new System.Windows.Forms.Padding(5);
            this.txtAdbHistory.Size = new System.Drawing.Size(306, 110);
            // 
            // txtAdbHistory.BaseText
            // 
            this.txtAdbHistory.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdbHistory.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdbHistory.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtAdbHistory.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtAdbHistory.SkinTxt.Multiline = true;
            this.txtAdbHistory.SkinTxt.Name = "BaseText";
            this.txtAdbHistory.SkinTxt.ReadOnly = true;
            this.txtAdbHistory.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdbHistory.SkinTxt.Size = new System.Drawing.Size(296, 100);
            this.txtAdbHistory.SkinTxt.TabIndex = 0;
            this.txtAdbHistory.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtAdbHistory.SkinTxt.WaterText = "";
            this.txtAdbHistory.TabIndex = 10;
            // 
            // btnReboot
            // 
            this.btnReboot.BackColor = System.Drawing.Color.Transparent;
            this.btnReboot.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnReboot.DownBack = null;
            this.btnReboot.Location = new System.Drawing.Point(11, 294);
            this.btnReboot.MouseBack = null;
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.NormlBack = null;
            this.btnReboot.Size = new System.Drawing.Size(101, 30);
            this.btnReboot.TabIndex = 11;
            this.btnReboot.Text = "Reboot Phone";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnRebootbootloader
            // 
            this.btnRebootbootloader.BackColor = System.Drawing.Color.Transparent;
            this.btnRebootbootloader.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRebootbootloader.DownBack = null;
            this.btnRebootbootloader.Location = new System.Drawing.Point(126, 294);
            this.btnRebootbootloader.MouseBack = null;
            this.btnRebootbootloader.Name = "btnRebootbootloader";
            this.btnRebootbootloader.NormlBack = null;
            this.btnRebootbootloader.Size = new System.Drawing.Size(116, 30);
            this.btnRebootbootloader.TabIndex = 11;
            this.btnRebootbootloader.Text = "Reboot Bootloader";
            this.btnRebootbootloader.UseVisualStyleBackColor = true;
            this.btnRebootbootloader.Click += new System.EventHandler(this.btnRebootbootloader_Click);
            // 
            // btnRebootRecovery
            // 
            this.btnRebootRecovery.BackColor = System.Drawing.Color.Transparent;
            this.btnRebootRecovery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRebootRecovery.DownBack = null;
            this.btnRebootRecovery.Location = new System.Drawing.Point(254, 294);
            this.btnRebootRecovery.MouseBack = null;
            this.btnRebootRecovery.Name = "btnRebootRecovery";
            this.btnRebootRecovery.NormlBack = null;
            this.btnRebootRecovery.Size = new System.Drawing.Size(115, 30);
            this.btnRebootRecovery.TabIndex = 11;
            this.btnRebootRecovery.Text = "Reboot Recovery";
            this.btnRebootRecovery.UseVisualStyleBackColor = true;
            this.btnRebootRecovery.Click += new System.EventHandler(this.btnRebootRecovery_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClean.DownBack = null;
            this.btnClean.Location = new System.Drawing.Point(376, 294);
            this.btnClean.MouseBack = null;
            this.btnClean.Name = "btnClean";
            this.btnClean.NormlBack = null;
            this.btnClean.Size = new System.Drawing.Size(71, 30);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 337);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.skinTextBox2);
            this.Controls.Add(this.skinTextBox1);
            this.Controls.Add(this.btnRebootRecovery);
            this.Controls.Add(this.btnRebootbootloader);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.txtAdbHistory);
            this.Controls.Add(this.txtAdbLocation);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.listDevices);
            this.Name = "Form1";
            this.Shadow = false;
            this.ShowBorder = false;
            this.Special = false;
            this.Text = "Adb Install & Uninstall";
            this.skinTextBox1.ResumeLayout(false);
            this.skinTextBox1.PerformLayout();
            this.skinTextBox2.ResumeLayout(false);
            this.skinTextBox2.PerformLayout();
            this.txtAdbHistory.ResumeLayout(false);
            this.txtAdbHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listDevices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox txtAdbLocation;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinTextBox txtAdbHistory;
        private CCWin.SkinControl.SkinButton btnReboot;
        private CCWin.SkinControl.SkinButton btnRebootbootloader;
        private CCWin.SkinControl.SkinButton btnRebootRecovery;
        private CCWin.SkinControl.SkinButton btnClean;
    }
}

