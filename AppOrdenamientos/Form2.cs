using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppOrdenamientos
{
    public partial class Form2 : Form
    {
        private List<Estudiante> estudiantes;

        private Ordenamientos ordenamientos;

        public Form2()
        {
            InitializeComponent();
            estudiantes = new List<Estudiante>();
            ordenamientos = new Ordenamientos();

            Archivo archivo = new Archivo();
            estudiantes = archivo.LeerEstudiantes(); 

            dataGridView.DataSource = estudiantes;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rbBubbleSort.Checked)
            {
                ordenamientos.BubbleSort(ref estudiantes);
            }
            else if (rbQuickSort.Checked)
            {
                ordenamientos.QuickSort(ref estudiantes);
            }
            else if (rbMergeSort.Checked)
            {
                ordenamientos.MergeSort(ref estudiantes);
            }
            else if (rbInsertionSort.Checked)
            {
                ordenamientos.InsertionSort(ref estudiantes);
            }
            else if (rbSelectionSort.Checked)
            {
                ordenamientos.SelectionSort(ref estudiantes);
            }
            else if (rbHeapSort.Checked)
            {
                ordenamientos.HeapSort(ref estudiantes);
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = estudiantes;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
