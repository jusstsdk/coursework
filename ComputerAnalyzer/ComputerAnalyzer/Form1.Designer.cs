namespace ComputerAnalyzer
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
            this.hardwareComboBox = new System.Windows.Forms.ComboBox();
            this.hardwareGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hardwareComboBox
            // 
            this.hardwareComboBox.FormattingEnabled = true;
            this.hardwareComboBox.Location = new System.Drawing.Point(12, 28);
            this.hardwareComboBox.Name = "hardwareComboBox";
            this.hardwareComboBox.Size = new System.Drawing.Size(121, 23);
            this.hardwareComboBox.TabIndex = 2;
            this.hardwareComboBox.SelectedIndexChanged += new System.EventHandler(this.hardwareComboBox_SelectedIndexChanged);
            // 
            // hardwareGridView
            // 
            this.hardwareGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.hardwareGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hardwareGridView.Location = new System.Drawing.Point(12, 76);
            this.hardwareGridView.Name = "hardwareGridView";
            this.hardwareGridView.RowTemplate.Height = 25;
            this.hardwareGridView.Size = new System.Drawing.Size(600, 307);
            this.hardwareGridView.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 474);
            this.Controls.Add(this.hardwareGridView);
            this.Controls.Add(this.hardwareComboBox);
            this.Name = "Form1";
            this.Text = "ComputerAnalyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hardwareGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox hardwareComboBox;
        private DataGridView hardwareGridView;
    }
}