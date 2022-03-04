namespace CS_CodePresenter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_currentProject = new System.Windows.Forms.Label();
            this.tb_projectName = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_import = new System.Windows.Forms.Button();
            this.lb_actionList = new System.Windows.Forms.ListBox();
            this.tb_hotkeyRec = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_hotkeyPlay = new System.Windows.Forms.Label();
            this.tb_hotkeyPlay = new System.Windows.Forms.TextBox();
            this.lbl_hotkeyRec = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.cb_topmost = new System.Windows.Forms.CheckBox();
            this.cb_delete = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_currentProject
            // 
            this.lbl_currentProject.AutoSize = true;
            this.lbl_currentProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_currentProject.Location = new System.Drawing.Point(14, 15);
            this.lbl_currentProject.Name = "lbl_currentProject";
            this.lbl_currentProject.Size = new System.Drawing.Size(90, 15);
            this.lbl_currentProject.TabIndex = 0;
            this.lbl_currentProject.Text = "Current project:";
            // 
            // tb_projectName
            // 
            this.tb_projectName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_projectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_projectName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_projectName.Location = new System.Drawing.Point(110, 12);
            this.tb_projectName.Name = "tb_projectName";
            this.tb_projectName.Size = new System.Drawing.Size(217, 23);
            this.tb_projectName.TabIndex = 1;
            this.tb_projectName.Text = "unnamed_project";
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_export.Location = new System.Drawing.Point(333, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_import.FlatAppearance.BorderSize = 0;
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_import.Location = new System.Drawing.Point(414, 12);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 23);
            this.btn_import.TabIndex = 3;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // lb_actionList
            // 
            this.lb_actionList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lb_actionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_actionList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_actionList.FormattingEnabled = true;
            this.lb_actionList.ItemHeight = 15;
            this.lb_actionList.Location = new System.Drawing.Point(12, 41);
            this.lb_actionList.Name = "lb_actionList";
            this.lb_actionList.Size = new System.Drawing.Size(728, 527);
            this.lb_actionList.TabIndex = 4;
            // 
            // tb_hotkeyRec
            // 
            this.tb_hotkeyRec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_hotkeyRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_hotkeyRec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_hotkeyRec.Location = new System.Drawing.Point(114, 3);
            this.tb_hotkeyRec.Name = "tb_hotkeyRec";
            this.tb_hotkeyRec.Size = new System.Drawing.Size(83, 23);
            this.tb_hotkeyRec.TabIndex = 5;
            this.tb_hotkeyRec.Text = "F1";
            this.tb_hotkeyRec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_hotkeyRec_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_hotkeyPlay);
            this.panel1.Controls.Add(this.tb_hotkeyPlay);
            this.panel1.Controls.Add(this.lbl_hotkeyRec);
            this.panel1.Controls.Add(this.tb_hotkeyRec);
            this.panel1.Location = new System.Drawing.Point(746, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 56);
            this.panel1.TabIndex = 6;
            // 
            // lbl_hotkeyPlay
            // 
            this.lbl_hotkeyPlay.AutoSize = true;
            this.lbl_hotkeyPlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_hotkeyPlay.Location = new System.Drawing.Point(3, 34);
            this.lbl_hotkeyPlay.Name = "lbl_hotkeyPlay";
            this.lbl_hotkeyPlay.Size = new System.Drawing.Size(71, 15);
            this.lbl_hotkeyPlay.TabIndex = 8;
            this.lbl_hotkeyPlay.Text = "Play hotkey:";
            // 
            // tb_hotkeyPlay
            // 
            this.tb_hotkeyPlay.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_hotkeyPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_hotkeyPlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_hotkeyPlay.Location = new System.Drawing.Point(114, 32);
            this.tb_hotkeyPlay.Name = "tb_hotkeyPlay";
            this.tb_hotkeyPlay.Size = new System.Drawing.Size(83, 23);
            this.tb_hotkeyPlay.TabIndex = 7;
            this.tb_hotkeyPlay.Text = "F2";
            this.tb_hotkeyPlay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_hotkeyPlay_KeyDown);
            // 
            // lbl_hotkeyRec
            // 
            this.lbl_hotkeyRec.AutoSize = true;
            this.lbl_hotkeyRec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_hotkeyRec.Location = new System.Drawing.Point(3, 5);
            this.lbl_hotkeyRec.Name = "lbl_hotkeyRec";
            this.lbl_hotkeyRec.Size = new System.Drawing.Size(86, 15);
            this.lbl_hotkeyRec.TabIndex = 6;
            this.lbl_hotkeyRec.Text = "Record hotkey:";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(746, 77);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(200, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete selected";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_info.Location = new System.Drawing.Point(746, 478);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(171, 90);
            this.lbl_info.TabIndex = 8;
            this.lbl_info.Text = "*Recorded line will be added\r\n     under selected item\r\n\r\n*It is recommended to u" +
    "se FN\r\n     keys as hotkeys (will prevent\r\n     default event)";
            // 
            // cb_topmost
            // 
            this.cb_topmost.AutoSize = true;
            this.cb_topmost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_topmost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_topmost.Location = new System.Drawing.Point(746, 106);
            this.cb_topmost.Name = "cb_topmost";
            this.cb_topmost.Size = new System.Drawing.Size(165, 19);
            this.cb_topmost.TabIndex = 9;
            this.cb_topmost.Text = "Keep window above others";
            this.cb_topmost.UseVisualStyleBackColor = true;
            this.cb_topmost.CheckedChanged += new System.EventHandler(this.cb_topmost_CheckedChanged);
            // 
            // cb_delete
            // 
            this.cb_delete.AutoSize = true;
            this.cb_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_delete.Location = new System.Drawing.Point(746, 131);
            this.cb_delete.Name = "cb_delete";
            this.cb_delete.Size = new System.Drawing.Size(132, 19);
            this.cb_delete.TabIndex = 10;
            this.cb_delete.Text = "Delete line on record";
            this.cb_delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(958, 581);
            this.Controls.Add(this.cb_delete);
            this.Controls.Add(this.cb_topmost);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_actionList);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.tb_projectName);
            this.Controls.Add(this.lbl_currentProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Presenter Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_currentProject;
        private TextBox tb_projectName;
        private Button btn_export;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_import;
        private ListBox lb_actionList;
        private TextBox tb_hotkeyRec;
        private Panel panel1;
        private Label lbl_hotkeyPlay;
        private TextBox tb_hotkeyPlay;
        private Label lbl_hotkeyRec;
        private Button btn_delete;
        private Label lbl_info;
        private CheckBox cb_topmost;
        private CheckBox cb_delete;
    }
}