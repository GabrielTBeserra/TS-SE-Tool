﻿namespace TS_SE_Tool
{
    partial class FormAddCustomFolder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCustomPathDir = new System.Windows.Forms.Label();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddCustomPath = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonGameTypeETS2 = new System.Windows.Forms.RadioButton();
            this.radioButtonGameTypeATS = new System.Windows.Forms.RadioButton();
            this.buttonEditCPlist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.folderBrowserDialogAddCustomFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomPathDir
            // 
            this.labelCustomPathDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomPathDir.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCustomPathDir, 3);
            this.labelCustomPathDir.Location = new System.Drawing.Point(3, 38);
            this.labelCustomPathDir.Name = "labelCustomPathDir";
            this.labelCustomPathDir.Size = new System.Drawing.Size(72, 13);
            this.labelCustomPathDir.TabIndex = 0;
            this.labelCustomPathDir.Text = "Choose folder";
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChooseFolder.Location = new System.Drawing.Point(3, 3);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(113, 24);
            this.buttonChooseFolder.TabIndex = 1;
            this.buttonChooseFolder.Text = "Choose folder";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder type";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Unknown";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButtonFolderType_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 91);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "save Folder";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtonFolderType_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "profile Folder";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtonFolderType_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "root Folder";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonFolderType_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tableLayoutPanel1.Controls.Add(this.buttonChooseFolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCustomPathDir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddCustomPath, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditCPlist, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 281);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonAddCustomPath
            // 
            this.buttonAddCustomPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddCustomPath.Enabled = false;
            this.buttonAddCustomPath.Location = new System.Drawing.Point(3, 254);
            this.buttonAddCustomPath.Name = "buttonAddCustomPath";
            this.buttonAddCustomPath.Size = new System.Drawing.Size(113, 24);
            this.buttonAddCustomPath.TabIndex = 3;
            this.buttonAddCustomPath.Text = "ADD";
            this.buttonAddCustomPath.UseVisualStyleBackColor = true;
            this.buttonAddCustomPath.Click += new System.EventHandler(this.buttonAddCustomPath_Click);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 3);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game type";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonGameTypeETS2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonGameTypeATS, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonGameTypeETS2
            // 
            this.radioButtonGameTypeETS2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonGameTypeETS2.AutoSize = true;
            this.radioButtonGameTypeETS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonGameTypeETS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGameTypeETS2.Location = new System.Drawing.Point(3, 3);
            this.radioButtonGameTypeETS2.Name = "radioButtonGameTypeETS2";
            this.radioButtonGameTypeETS2.Size = new System.Drawing.Size(174, 35);
            this.radioButtonGameTypeETS2.TabIndex = 0;
            this.radioButtonGameTypeETS2.TabStop = true;
            this.radioButtonGameTypeETS2.Text = "ETS 2";
            this.radioButtonGameTypeETS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonGameTypeETS2.UseVisualStyleBackColor = true;
            this.radioButtonGameTypeETS2.CheckedChanged += new System.EventHandler(this.radioButtonFolderType_CheckedChanged);
            // 
            // radioButtonGameTypeATS
            // 
            this.radioButtonGameTypeATS.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonGameTypeATS.AutoSize = true;
            this.radioButtonGameTypeATS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonGameTypeATS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGameTypeATS.Location = new System.Drawing.Point(183, 3);
            this.radioButtonGameTypeATS.Name = "radioButtonGameTypeATS";
            this.radioButtonGameTypeATS.Size = new System.Drawing.Size(175, 35);
            this.radioButtonGameTypeATS.TabIndex = 1;
            this.radioButtonGameTypeATS.TabStop = true;
            this.radioButtonGameTypeATS.Text = "ATS";
            this.radioButtonGameTypeATS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonGameTypeATS.UseVisualStyleBackColor = true;
            this.radioButtonGameTypeATS.CheckedChanged += new System.EventHandler(this.radioButtonFolderType_CheckedChanged);
            // 
            // buttonEditCPlist
            // 
            this.buttonEditCPlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditCPlist.Location = new System.Drawing.Point(257, 3);
            this.buttonEditCPlist.Name = "buttonEditCPlist";
            this.buttonEditCPlist.Size = new System.Drawing.Size(113, 24);
            this.buttonEditCPlist.TabIndex = 5;
            this.buttonEditCPlist.Text = "Edit list";
            this.buttonEditCPlist.UseVisualStyleBackColor = true;
            this.buttonEditCPlist.Click += new System.EventHandler(this.buttonEditCPlist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.Del});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(376, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 4);
            this.dataGridView1.Size = new System.Drawing.Size(295, 245);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.MinimumWidth = 200;
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 200;
            // 
            // Del
            // 
            this.Del.HeaderText = "Delete";
            this.Del.MinimumWidth = 50;
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Text = "Delete";
            this.Del.UseColumnTextForButtonValue = true;
            this.Del.Width = 50;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(257, 254);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 24);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormAddCustomFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 281);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCustomFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Custom folders";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCustomPathDir;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonAddCustomPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAddCustomFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonGameTypeETS2;
        private System.Windows.Forms.RadioButton radioButtonGameTypeATS;
        private System.Windows.Forms.Button buttonEditCPlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.Button buttonSave;
    }
}