using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_Cơ_Sở_65130410
{
    public partial class Form1 : Form
    {
        int[] arr;
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Font = new Font("Segoe UI", 10);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Minh họa giải thuật sắp xếp";

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n = (int)numSize.Value;
            arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = rd.Next(10, 300);

            DrawArray();
        }

        void DrawArray(int a = -1, int b = -1)
        {
            if (arr == null || arr.Length == 0) return;

            panelDraw.Refresh();
            Graphics g = panelDraw.CreateGraphics();
            int w = panelDraw.Width / arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                Brush br = Brushes.Blue;
                if (i == a || i == b) br = Brushes.Red;

                g.FillRectangle(
                    br,
                    i * w + 3,
                    panelDraw.Height - arr[i],
                    w - 6,
                    arr[i]
                );

            }
        }


        async Task Delay()
        {
            await Task.Delay(200);
        }

        async Task QuickSort(int l, int r)
        {
            if (l >= r) return;

            int pivot = arr[(l + r) / 2];
            int i = l, j = r;

            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;

                if (i <= j)
                {
                    Swap(i, j);
                    DrawArray(i, j);
                    await Delay();
                    i++;
                    j--;
                }
            }

            await QuickSort(l, j);
            await QuickSort(i, r);
        }

        async Task HeapSort()
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                await Heapify(n, i);

            for (int i = n - 1; i > 0; i--)
            {
                Swap(0, i);
                DrawArray(0, i);
                await Delay();
                await Heapify(i, 0);
            }
        }

        async Task Heapify(int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] > arr[largest]) largest = l;
            if (r < n && arr[r] > arr[largest]) largest = r;

            if (largest != i)
            {
                Swap(i, largest);
                DrawArray(i, largest);
                await Delay();
                await Heapify(n, largest);
            }
        }

        async Task MergeSort(int l, int r)
        {
            if (l >= r) return;

            int m = (l + r) / 2;
            await MergeSort(l, m);
            await MergeSort(m + 1, r);
            await Merge(l, m, r);
        }

        async Task Merge(int l, int m, int r)
        {
            int[] temp = new int[r - l + 1];
            int i = l, j = m + 1, k = 0;

            while (i <= m && j <= r)
                temp[k++] = arr[i] < arr[j] ? arr[i++] : arr[j++];

            while (i <= m) temp[k++] = arr[i++];
            while (j <= r) temp[k++] = arr[j++];

            for (int x = 0; x < temp.Length; x++)
            {
                arr[l + x] = temp[x];
                DrawArray(l + x, -1);
                await Delay();
            }
        }

        void Swap(int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }

        private async void btnQuickSort_Click(object sender, EventArgs e)
        {
            await QuickSort(0, arr.Length - 1);
            lblStatus.Text = "Quick Sort xong";
        }

        private async void btnHeapSort_Click(object sender, EventArgs e)
        {
            await HeapSort();
            lblStatus.Text = "Heap Sort xong";
        }

        private async void btnMergeSort_Click(object sender, EventArgs e)
        {
            await MergeSort(0, arr.Length - 1);
            lblStatus.Text = "Merge Sort xong";
        }
        void StyleButton(Button b, Color c)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = c;
            b.ForeColor = Color.White;
            b.Height = 38;
            StyleButton(btnRandom, Color.FromArgb(52, 152, 219));
            StyleButton(btnQuickSort, Color.FromArgb(46, 204, 113));
            StyleButton(btnHeapSort, Color.FromArgb(241, 196, 15));
            StyleButton(btnMergeSort, Color.FromArgb(155, 89, 182));

        }

    }
}
