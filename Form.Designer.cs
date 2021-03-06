
namespace osuezmapsdelete
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.FileList = new System.Windows.Forms.RichTextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DiffBox = new System.Windows.Forms.TextBox();
            this.SensitiveBox = new System.Windows.Forms.CheckBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchB = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.LabelShow = new System.Windows.Forms.Label();
            this.Logged = new System.Windows.Forms.Label();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DiffRatioButton = new System.Windows.Forms.RadioButton();
            this.TitleRatioButton = new System.Windows.Forms.RadioButton();
            this.CreatorRatioButton = new System.Windows.Forms.RadioButton();
            this.DragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileList
            // 
            this.FileList.BackColor = System.Drawing.Color.Gray;
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FileList.DetectUrls = false;
            this.FileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileList.ForeColor = System.Drawing.Color.White;
            this.FileList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FileList.Location = new System.Drawing.Point(297, 29);
            this.FileList.Name = "FileList";
            this.FileList.ReadOnly = true;
            this.FileList.Size = new System.Drawing.Size(881, 419);
            this.FileList.TabIndex = 3;
            this.FileList.Text = "";
            this.FileList.WordWrap = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(92, 225);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Mass delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButonClick);
            // 
            // DiffBox
            // 
            this.DiffBox.BackColor = System.Drawing.Color.White;
            this.DiffBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiffBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiffBox.Location = new System.Drawing.Point(62, 96);
            this.DiffBox.Name = "DiffBox";
            this.DiffBox.Size = new System.Drawing.Size(149, 22);
            this.DiffBox.TabIndex = 0;
            // 
            // SensitiveBox
            // 
            this.SensitiveBox.AutoSize = true;
            this.SensitiveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SensitiveBox.ForeColor = System.Drawing.Color.White;
            this.SensitiveBox.Location = new System.Drawing.Point(43, 202);
            this.SensitiveBox.Name = "SensitiveBox";
            this.SensitiveBox.Size = new System.Drawing.Size(180, 17);
            this.SensitiveBox.TabIndex = 1;
            this.SensitiveBox.Text = "I want to delete those beatmaps.";
            this.SensitiveBox.UseVisualStyleBackColor = true;
            this.SensitiveBox.CheckedChanged += new System.EventHandler(this.SensitiveBox_CheckedChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchLabel.ForeColor = System.Drawing.Color.White;
            this.SearchLabel.Location = new System.Drawing.Point(89, 77);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 16);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Difficulty search:";
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.White;
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchB.Location = new System.Drawing.Point(213, 96);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(45, 22);
            this.SearchB.TabIndex = 6;
            this.SearchB.Text = "Show";
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(12, 376);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(268, 23);
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar1.TabIndex = 9;
            // 
            // LabelShow
            // 
            this.LabelShow.ForeColor = System.Drawing.Color.White;
            this.LabelShow.Location = new System.Drawing.Point(12, 360);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(268, 13);
            this.LabelShow.TabIndex = 10;
            this.LabelShow.Text = "Click \"Show\" to see the progress and maps.";
            this.LabelShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logged
            // 
            this.Logged.AutoSize = true;
            this.Logged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Logged.ForeColor = System.Drawing.Color.White;
            this.Logged.Location = new System.Drawing.Point(3, 3);
            this.Logged.Name = "Logged";
            this.Logged.Size = new System.Drawing.Size(0, 20);
            this.Logged.TabIndex = 11;
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.DimGray;
            this.DragPanel.Controls.Add(this.CloseIcon);
            this.DragPanel.Controls.Add(this.Logged);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(1180, 27);
            this.DragPanel.TabIndex = 12;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // CloseIcon
            // 
            this.CloseIcon.BackColor = System.Drawing.Color.DimGray;
            this.CloseIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseIcon.BackgroundImage")));
            this.CloseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseIcon.Location = new System.Drawing.Point(1154, 6);
            this.CloseIcon.Name = "CloseIcon";
            this.CloseIcon.Size = new System.Drawing.Size(17, 17);
            this.CloseIcon.TabIndex = 13;
            this.CloseIcon.TabStop = false;
            this.CloseIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseIcon_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreatorRatioButton);
            this.panel1.Controls.Add(this.TitleRatioButton);
            this.panel1.Controls.Add(this.DiffRatioButton);
            this.panel1.Location = new System.Drawing.Point(7, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 27);
            this.panel1.TabIndex = 13;
            // 
            // DiffRatioButton
            // 
            this.DiffRatioButton.AutoSize = true;
            this.DiffRatioButton.Checked = true;
            this.DiffRatioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiffRatioButton.ForeColor = System.Drawing.Color.White;
            this.DiffRatioButton.Location = new System.Drawing.Point(5, 3);
            this.DiffRatioButton.Name = "DiffRatioButton";
            this.DiffRatioButton.Size = new System.Drawing.Size(75, 20);
            this.DiffRatioButton.TabIndex = 0;
            this.DiffRatioButton.Text = "Difficulty";
            this.DiffRatioButton.UseVisualStyleBackColor = true;
            this.DiffRatioButton.CheckedChanged += new System.EventHandler(this.DiffRatioButton_CheckedChanged);
            // 
            // TitleRatioButton
            // 
            this.TitleRatioButton.AutoSize = true;
            this.TitleRatioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleRatioButton.ForeColor = System.Drawing.Color.White;
            this.TitleRatioButton.Location = new System.Drawing.Point(110, 3);
            this.TitleRatioButton.Name = "TitleRatioButton";
            this.TitleRatioButton.Size = new System.Drawing.Size(52, 20);
            this.TitleRatioButton.TabIndex = 1;
            this.TitleRatioButton.Text = "Title";
            this.TitleRatioButton.UseVisualStyleBackColor = true;
            this.TitleRatioButton.CheckedChanged += new System.EventHandler(this.TitleRatioButton_CheckedChanged);
            // 
            // CreatorRatioButton
            // 
            this.CreatorRatioButton.AutoSize = true;
            this.CreatorRatioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreatorRatioButton.ForeColor = System.Drawing.Color.White;
            this.CreatorRatioButton.Location = new System.Drawing.Point(206, 3);
            this.CreatorRatioButton.Name = "CreatorRatioButton";
            this.CreatorRatioButton.Size = new System.Drawing.Size(70, 20);
            this.CreatorRatioButton.TabIndex = 2;
            this.CreatorRatioButton.Text = "Creator";
            this.CreatorRatioButton.UseVisualStyleBackColor = true;
            this.CreatorRatioButton.CheckedChanged += new System.EventHandler(this.CreatorRatioButton_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.LabelShow);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SensitiveBox);
            this.Controls.Add(this.DiffBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FileList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "osuEZMapsRemover";
            this.Load += new System.EventHandler(this.Form_Load);
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FileList;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DiffBox;
        private System.Windows.Forms.CheckBox SensitiveBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Label LabelShow;
        private System.Windows.Forms.Label Logged;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton DiffRatioButton;
        private System.Windows.Forms.RadioButton CreatorRatioButton;
        private System.Windows.Forms.RadioButton TitleRatioButton;
    }
}

