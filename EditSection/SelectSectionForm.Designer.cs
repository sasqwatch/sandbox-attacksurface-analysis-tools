﻿namespace EditSection
{
    partial class SelectSectionForm
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
            System.Windows.Forms.Label lblFilter;
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.treeViewProcesses = new System.Windows.Forms.TreeView();
            this.checkBoxOpenReadonly = new System.Windows.Forms.CheckBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new System.Drawing.Point(11, 11);
            lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new System.Drawing.Size(43, 17);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Filter:";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(201, 539);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(351, 539);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // treeViewProcesses
            // 
            this.treeViewProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewProcesses.Location = new System.Drawing.Point(-1, 39);
            this.treeViewProcesses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewProcesses.Name = "treeViewProcesses";
            this.treeViewProcesses.Size = new System.Drawing.Size(651, 491);
            this.treeViewProcesses.TabIndex = 2;
            this.treeViewProcesses.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewProcesses_BeforeExpand);
            // 
            // checkBoxOpenReadonly
            // 
            this.checkBoxOpenReadonly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOpenReadonly.AutoSize = true;
            this.checkBoxOpenReadonly.Location = new System.Drawing.Point(494, 544);
            this.checkBoxOpenReadonly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxOpenReadonly.Name = "checkBoxOpenReadonly";
            this.checkBoxOpenReadonly.Size = new System.Drawing.Size(137, 21);
            this.checkBoxOpenReadonly.TabIndex = 3;
            this.checkBoxOpenReadonly.Text = "Open Read-Only";
            this.checkBoxOpenReadonly.UseVisualStyleBackColor = true;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.AcceptsReturn = true;
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(65, 7);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(476, 22);
            this.textBoxFilter.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(551, 5);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 28);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // SelectSectionForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(652, 582);
            this.ControlBox = false;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(lblFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.checkBoxOpenReadonly);
            this.Controls.Add(this.treeViewProcesses);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectSectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Process Section";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TreeView treeViewProcesses;
        private System.Windows.Forms.CheckBox checkBoxOpenReadonly;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button btnApply;
    }
}