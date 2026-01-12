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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnNhapTay = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDraw
            // 
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDraw.Location = new System.Drawing.Point(26, 24);
            this.panelDraw.Margin = new System.Windows.Forms.Padding(2);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(377, 170);
            this.panelDraw.TabIndex = 0;
            // 
            // btnRandom
            // 
            this.btnRandom.AutoSize = true;
            this.btnRandom.Location = new System.Drawing.Point(26, 246);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(96, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Tạo Ngẫu Nhiên";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.AutoSize = true;
            this.btnQuickSort.Location = new System.Drawing.Point(142, 246);
            this.btnQuickSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(64, 23);
            this.btnQuickSort.TabIndex = 1;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.AutoSize = true;
            this.btnHeapSort.Location = new System.Drawing.Point(226, 246);
            this.btnHeapSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(62, 23);
            this.btnHeapSort.TabIndex = 2;
            this.btnHeapSort.Text = "HeapSort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.AutoSize = true;
            this.btnMergeSort.Location = new System.Drawing.Point(303, 246);
            this.btnMergeSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(66, 23);
            this.btnMergeSort.TabIndex = 3;
            this.btnMergeSort.Text = "MergeSort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(30, 207);
            this.numSize.Margin = new System.Windows.Forms.Padding(2);
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
            this.numSize.Size = new System.Drawing.Size(90, 20);
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
            this.lblStatus.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblStatus.Location = new System.Drawing.Point(27, 9);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Loại sắp xếp";
            // 
            // txtExplain
            // 
            this.txtExplain.BackColor = System.Drawing.Color.White;
            this.txtExplain.Location = new System.Drawing.Point(407, 24);
            this.txtExplain.Margin = new System.Windows.Forms.Padding(2);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ReadOnly = true;
            this.txtExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(182, 170);
            this.txtExplain.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mô tả";
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.AutoSize = true;
            this.btnBubbleSort.Location = new System.Drawing.Point(385, 246);
            this.btnBubbleSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(69, 23);
            this.btnBubbleSort.TabIndex = 8;
            this.btnBubbleSort.Text = "BubbleSort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(476, 214);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(142, 207);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(193, 20);
            this.txtInput.TabIndex = 10;
            // 
            // btnNhapTay
            // 
            this.btnNhapTay.AutoSize = true;
            this.btnNhapTay.Location = new System.Drawing.Point(358, 205);
            this.btnNhapTay.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapTay.Name = "btnNhapTay";
            this.btnNhapTay.Size = new System.Drawing.Size(65, 23);
            this.btnNhapTay.TabIndex = 11;
            this.btnNhapTay.Text = "Nhập Tay";
            this.btnNhapTay.UseVisualStyleBackColor = true;
            this.btnNhapTay.Click += new System.EventHandler(this.btnNhapTay_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.AutoSize = true;
            this.btnImportExcel.Location = new System.Drawing.Point(30, 291);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(88, 24);
            this.btnImportExcel.TabIndex = 13;
            this.btnImportExcel.Text = "Nhập Từ Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnNhapTay);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Đồ Án NHD_65130410";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnNhapTay;
        private System.Windows.Forms.Button btnImportExcel;
    }
}

