namespace Mosaic
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
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.mosaicPanel = new System.Windows.Forms.Panel();
            this.penColorPanel = new System.Windows.Forms.Panel();
            this.mosaicLevelComboBox = new System.Windows.Forms.ComboBox();
            this.penSizeComboBox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.backColorPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1137, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1056, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // mosaicPanel
            // 
            this.mosaicPanel.BackColor = System.Drawing.Color.White;
            this.mosaicPanel.Location = new System.Drawing.Point(12, 32);
            this.mosaicPanel.Name = "mosaicPanel";
            this.mosaicPanel.Size = new System.Drawing.Size(1200, 800);
            this.mosaicPanel.TabIndex = 0;
            this.mosaicPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mosaicPanel_MouseDown);
            this.mosaicPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mosaicPanel_MouseMove);
            this.mosaicPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mosaicPanel_MouseUp);
            // 
            // penColorPanel
            // 
            this.penColorPanel.BackColor = System.Drawing.Color.Black;
            this.penColorPanel.Location = new System.Drawing.Point(176, 5);
            this.penColorPanel.Name = "penColorPanel";
            this.penColorPanel.Size = new System.Drawing.Size(26, 23);
            this.penColorPanel.TabIndex = 4;
            this.penColorPanel.Click += new System.EventHandler(this.penColorPanel_Click);
            // 
            // mosaicLevelComboBox
            // 
            this.mosaicLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mosaicLevelComboBox.FormattingEnabled = true;
            this.mosaicLevelComboBox.Location = new System.Drawing.Point(437, 5);
            this.mosaicLevelComboBox.Name = "mosaicLevelComboBox";
            this.mosaicLevelComboBox.Size = new System.Drawing.Size(64, 21);
            this.mosaicLevelComboBox.TabIndex = 6;
            // 
            // penSizeComboBox
            // 
            this.penSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.penSizeComboBox.FormattingEnabled = true;
            this.penSizeComboBox.Location = new System.Drawing.Point(266, 6);
            this.penSizeComboBox.Name = "penSizeComboBox";
            this.penSizeComboBox.Size = new System.Drawing.Size(64, 21);
            this.penSizeComboBox.TabIndex = 7;
            this.penSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.penSizeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pen color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mosaic level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pen size:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(518, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Use absolute center";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // backColorPanel
            // 
            this.backColorPanel.BackColor = System.Drawing.Color.White;
            this.backColorPanel.Location = new System.Drawing.Point(76, 5);
            this.backColorPanel.Name = "backColorPanel";
            this.backColorPanel.Size = new System.Drawing.Size(26, 23);
            this.backColorPanel.TabIndex = 5;
            this.backColorPanel.Click += new System.EventHandler(this.backColorPanel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Back color:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 843);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backColorPanel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.penSizeComboBox);
            this.Controls.Add(this.mosaicLevelComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.penColorPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mosaicPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mosaic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mosaicPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel penColorPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mosaicLevelComboBox;
        private System.Windows.Forms.ComboBox penSizeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel backColorPanel;
        private System.Windows.Forms.Label label4;
    }
}

