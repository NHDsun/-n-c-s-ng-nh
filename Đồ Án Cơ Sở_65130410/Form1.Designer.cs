namespace Đồ_Án_Cơ_Sở_65130410
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
            this.panelDraw = new System.Windows.Forms.Panel();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDraw
            // 
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDraw.Location = new System.Drawing.Point(61, 74);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(428, 164);
            this.panelDraw.TabIndex = 0;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(61, 303);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Start";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(158, 303);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(75, 23);
            this.btnQuickSort.TabIndex = 1;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Location = new System.Drawing.Point(259, 303);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(75, 23);
            this.btnHeapSort.TabIndex = 2;
            this.btnHeapSort.Text = "HeapSort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(357, 303);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(82, 23);
            this.btnMergeSort.TabIndex = 3;
            this.btnMergeSort.Text = "MergeSort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(61, 255);
            this.numSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(120, 22);
            this.numSize.TabIndex = 4;
            this.numSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(58, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Loại sắp xếp";
            // 
            // txtExplain
            // 
            this.txtExplain.BackColor = System.Drawing.Color.White;
            this.txtExplain.Location = new System.Drawing.Point(515, 74);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ReadOnly = true;
            this.txtExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(273, 164);
            this.txtExplain.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mô tả";
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(477, 303);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(86, 23);
            this.btnBubbleSort.TabIndex = 8;
            this.btnBubbleSort.Text = "BubbleSort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExplain);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.panelDraw);
            this.Name = "Form1";
            this.Text = "Đồ Án NHD_65130410";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBubbleSort;
    }
}

