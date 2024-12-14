namespace AppOrdenamientos
{
    partial class Form2
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            rbBubbleSort = new RadioButton();
            rbQuickSort = new RadioButton();
            rbMergeSort = new RadioButton();
            rbInsertionSort = new RadioButton();
            rbSelectionSort = new RadioButton();
            rbHeapSort = new RadioButton();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(776, 322);
            dataGridView.TabIndex = 0;
            // 
            // rbBubbleSort
            // 
            rbBubbleSort.Location = new Point(1, 355);
            rbBubbleSort.Name = "rbBubbleSort";
            rbBubbleSort.Size = new Size(92, 24);
            rbBubbleSort.TabIndex = 1;
            rbBubbleSort.Text = "Bubble Sort (Ascendente ID)";
            // 
            // rbQuickSort
            // 
            rbQuickSort.Location = new Point(99, 355);
            rbQuickSort.Name = "rbQuickSort";
            rbQuickSort.Size = new Size(104, 24);
            rbQuickSort.TabIndex = 2;
            rbQuickSort.Text = "Quick Sort (Descendente ID)";
            // 
            // rbMergeSort
            // 
            rbMergeSort.Location = new Point(209, 355);
            rbMergeSort.Name = "rbMergeSort";
            rbMergeSort.Size = new Size(104, 24);
            rbMergeSort.TabIndex = 3;
            rbMergeSort.Text = "Merge Sort (Ascendente Nombre)";
            // 
            // rbInsertionSort
            // 
            rbInsertionSort.Location = new Point(319, 355);
            rbInsertionSort.Name = "rbInsertionSort";
            rbInsertionSort.Size = new Size(104, 24);
            rbInsertionSort.TabIndex = 4;
            rbInsertionSort.Text = "Insertion Sort (Descendente Nombre)";
            // 
            // rbSelectionSort
            // 
            rbSelectionSort.Location = new Point(429, 355);
            rbSelectionSort.Name = "rbSelectionSort";
            rbSelectionSort.Size = new Size(104, 24);
            rbSelectionSort.TabIndex = 5;
            rbSelectionSort.Text = "Selection Sort (Ascendente Edad)";
            // 
            // rbHeapSort
            // 
            rbHeapSort.Location = new Point(539, 355);
            rbHeapSort.Name = "rbHeapSort";
            rbHeapSort.Size = new Size(92, 24);
            rbHeapSort.TabIndex = 6;
            rbHeapSort.Text = "Heap Sort (Descendente Edad)";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(680, 340);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(108, 54);
            btnOrdenar.TabIndex = 7;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 409);
            Controls.Add(dataGridView);
            Controls.Add(rbBubbleSort);
            Controls.Add(rbQuickSort);
            Controls.Add(rbMergeSort);
            Controls.Add(rbInsertionSort);
            Controls.Add(rbSelectionSort);
            Controls.Add(rbHeapSort);
            Controls.Add(btnOrdenar);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton rbBubbleSort;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbMergeSort;
        private System.Windows.Forms.RadioButton rbInsertionSort;
        private System.Windows.Forms.RadioButton rbSelectionSort;
        private System.Windows.Forms.RadioButton rbHeapSort;
        private System.Windows.Forms.Button btnOrdenar;
        
    }
}
