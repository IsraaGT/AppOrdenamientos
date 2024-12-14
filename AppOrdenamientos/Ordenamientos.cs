using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrdenamientos
{
    using System;
    using System.Collections.Generic;

    public class Ordenamientos
    {
        // Ordena por ID ascendente (Bubble Sort)
        public void BubbleSort(ref List<Estudiante> estudiantes)
        {
            for (int i = 0; i < estudiantes.Count - 1; i++)
            {
                for (int j = 0; j < estudiantes.Count - i - 1; j++)
                {
                    if (estudiantes[j].ID > estudiantes[j + 1].ID)
                    {
                        var temp = estudiantes[j];
                        estudiantes[j] = estudiantes[j + 1];
                        estudiantes[j + 1] = temp;
                    }
                }
            }
        }

        // Ordena por ID descendente (Quick Sort)
        public void QuickSort(ref List<Estudiante> estudiantes)
        {
            QuickSort(estudiantes, 0, estudiantes.Count - 1);
        }

        private void QuickSort(List<Estudiante> estudiantes, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(estudiantes, low, high);
                QuickSort(estudiantes, low, pi - 1);
                QuickSort(estudiantes, pi + 1, high);
            }
        }

        private int Partition(List<Estudiante> estudiantes, int low, int high)
        {
            var pivot = estudiantes[high].ID;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (estudiantes[j].ID > pivot)
                {
                    i++;
                    var temp = estudiantes[i];
                    estudiantes[i] = estudiantes[j];
                    estudiantes[j] = temp;
                }
            }

            var temp1 = estudiantes[i + 1];
            estudiantes[i + 1] = estudiantes[high];
            estudiantes[high] = temp1;

            return i + 1;
        }

        // Ordena por Nombre ascendente (Merge Sort)
        public void MergeSort(ref List<Estudiante> estudiantes)
        {
            MergeSort(estudiantes, 0, estudiantes.Count - 1);
        }

        private void MergeSort(List<Estudiante> estudiantes, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(estudiantes, left, mid);
                MergeSort(estudiantes, mid + 1, right);
                Merge(estudiantes, left, mid, right);
            }
        }

        private void Merge(List<Estudiante> estudiantes, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            var leftList = new List<Estudiante>();
            var rightList = new List<Estudiante>();

            for (int i = 0; i < n1; i++)
                leftList.Add(estudiantes[left + i]);
            for (int j = 0; j < n2; j++)
                rightList.Add(estudiantes[mid + 1 + j]);

            int k = left;
            int i1 = 0, i2 = 0;

            while (i1 < n1 && i2 < n2)
            {
                if (string.Compare(leftList[i1].Nombre, rightList[i2].Nombre) <= 0)
                {
                    estudiantes[k++] = leftList[i1++];
                }
                else
                {
                    estudiantes[k++] = rightList[i2++];
                }
            }

            while (i1 < n1)
                estudiantes[k++] = leftList[i1++];

            while (i2 < n2)
                estudiantes[k++] = rightList[i2++];
        }

        // Ordena por Nombre descendente (Insertion Sort)
        public void InsertionSort(ref List<Estudiante> estudiantes)
        {
            for (int i = 1; i < estudiantes.Count; i++)
            {
                var key = estudiantes[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(estudiantes[j].Nombre, key.Nombre) < 0)
                {
                    estudiantes[j + 1] = estudiantes[j];
                    j--;
                }
                estudiantes[j + 1] = key;
            }
        }

        // Ordena por Edad ascendente (Selection Sort)
        public void SelectionSort(ref List<Estudiante> estudiantes)
        {
            for (int i = 0; i < estudiantes.Count - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < estudiantes.Count; j++)
                {
                    if (estudiantes[j].Edad < estudiantes[minIdx].Edad)
                    {
                        minIdx = j;
                    }
                }

                var temp = estudiantes[minIdx];
                estudiantes[minIdx] = estudiantes[i];
                estudiantes[i] = temp;
            }
        }

        // Ordena por Edad descendente (Heap Sort)
        public void HeapSort(ref List<Estudiante> estudiantes)
        {
            int n = estudiantes.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(estudiantes, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                var temp = estudiantes[0];
                estudiantes[0] = estudiantes[i];
                estudiantes[i] = temp;
                Heapify(estudiantes, i, 0);
            }
        }

        private void Heapify(List<Estudiante> estudiantes, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && estudiantes[left].Edad > estudiantes[largest].Edad)
                largest = left;

            if (right < n && estudiantes[right].Edad > estudiantes[largest].Edad)
                largest = right;

            if (largest != i)
            {
                var temp = estudiantes[i];
                estudiantes[i] = estudiantes[largest];
                estudiantes[largest] = temp;

                Heapify(estudiantes, n, largest);
            }
        }
    }
}
