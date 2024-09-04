
namespace forLab2
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
            this.matrixGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.СhartButton = new System.Windows.Forms.Button();
            this.saveFirstButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixGrid
            // 
            this.matrixGrid.AllowUserToAddRows = false;
            this.matrixGrid.AllowUserToDeleteRows = false;
            this.matrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGrid.Location = new System.Drawing.Point(29, 42);
            this.matrixGrid.Margin = new System.Windows.Forms.Padding(4);
            this.matrixGrid.Name = "matrixGrid";
            this.matrixGrid.RowHeadersWidth = 51;
            this.matrixGrid.Size = new System.Drawing.Size(524, 222);
            this.matrixGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrix 1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Text files|*.txt";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(612, 99);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(120, 28);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Enabled = false;
            this.ResultButton.Location = new System.Drawing.Point(612, 348);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(120, 28);
            this.ResultButton.TabIndex = 5;
            this.ResultButton.Text = "Result";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // СhartButton
            // 
            this.СhartButton.Enabled = false;
            this.СhartButton.Location = new System.Drawing.Point(612, 419);
            this.СhartButton.Name = "СhartButton";
            this.СhartButton.Size = new System.Drawing.Size(120, 28);
            this.СhartButton.TabIndex = 6;
            this.СhartButton.Text = "Сhart";
            this.СhartButton.UseVisualStyleBackColor = true;
            this.СhartButton.Click += new System.EventHandler(this.СhartButton_Click);
            // 
            // saveFirstButton
            // 
            this.saveFirstButton.Enabled = false;
            this.saveFirstButton.Location = new System.Drawing.Point(612, 166);
            this.saveFirstButton.Name = "saveFirstButton";
            this.saveFirstButton.Size = new System.Drawing.Size(120, 28);
            this.saveFirstButton.TabIndex = 7;
            this.saveFirstButton.Text = "Save first";
            this.saveFirstButton.UseVisualStyleBackColor = true;
            this.saveFirstButton.Click += new System.EventHandler(this.SaveFirstButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 498);
            this.Controls.Add(this.saveFirstButton);
            this.Controls.Add(this.СhartButton);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrixGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrixGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button СhartButton;
        private System.Windows.Forms.Button saveFirstButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

