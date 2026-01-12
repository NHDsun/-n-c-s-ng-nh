using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
namespace Đồ_Án_Cơ_Sở_65130410
{
    public partial class Form1 : Form
    {
        bool isSorting = false;
        bool isFromExcel = false;
        ToolTip barToolTip;
        int hoverIndex = -1;
        int quickRunning = 0;
        bool isSorted = false;
        int[] arr;
        string[] labels;
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
            barToolTip = new ToolTip();
            barToolTip.InitialDelay = 200;
            barToolTip.ReshowDelay = 100;
            barToolTip.AutoPopDelay = 5000;
            barToolTip.ShowAlways = true;
            panelDraw.MouseMove += panelDraw_MouseMove;
            panelDraw.MouseLeave += panelDraw_MouseLeave;
            numSize.Minimum = 5;
            numSize.Maximum = 20;
            numSize.Value = 10;
            this.Font = new Font("Segoe UI", 10);
            this.StartPosition = FormStartPosition.CenterScreen;
            panelDraw.BackColor = Color.White;
            panelDraw.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.ForeColor = Color.White;
            lblStatus.Text = "Sẵn sàng";
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (CheckSorting()) return;
            isFromExcel = false;
            isSorted = false;
            int n = (int)numSize.Value;
            arr = new int[n];

            int maxH = panelDraw.Height - 20;
            int step = maxH / n;

            for (int i = 0; i < n; i++)
                arr[i] = step * (i + 1);

            for (int i = n - 1; i > 0; i--)
            {
                int j = rd.Next(0, i + 1);
                int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            }

            DrawArray();
            isSorted = false;
            lblStatus.Text = "Đã sinh mảng lộn xộn";
            isSorted = false;

        }

        void DrawArray(int a = -1, int b = -1)
        {
            if (arr == null || arr.Length == 0) return;

            panelDraw.Refresh();
            Graphics g = panelDraw.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int w = panelDraw.Width / arr.Length;
            int maxValue = arr.Max();
            int maxHeight = panelDraw.Height - 30;

            for (int i = 0; i < arr.Length; i++)
            {
                int h = (int)((arr[i] * 1.0 / maxValue) * maxHeight);

                int x = i * w + 4;
                int y = panelDraw.Height - h;
                int width = w - 8;

                Color c1 = Color.FromArgb(52, 152, 219);
                Color c2 = Color.FromArgb(41, 128, 185);

                if (isSorted)
                {
                    c1 = Color.FromArgb(46, 204, 113);
                    c2 = Color.FromArgb(39, 174, 96);
                }
                else if (i == a || i == b)
                {
                    c1 = Color.FromArgb(231, 76, 60);
                    c2 = Color.FromArgb(192, 57, 43);
                }

                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int r = 6;
                    path.AddArc(x, y, r, r, 180, 90);
                    path.AddArc(x + width - r, y, r, r, 270, 90);
                    path.AddArc(x + width - r, y + h - r, r, r, 0, 90);
                    path.AddArc(x, y + h - r, r, r, 90, 90);
                    path.CloseFigure();

                    using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                        new Rectangle(x, y, width, h),
                        c1,
                        c2,
                        90f))
                    {
                        g.FillPath(brush, path);
                    }
                }

                string valueText = arr[i].ToString();
                Font font = new Font("Segoe UI", 9, FontStyle.Bold);
                SizeF valueSize = g.MeasureString(valueText, font);

                float valueX = x + (width - valueSize.Width) / 2;
                float valueY = y - valueSize.Height - 2;

                if (valueY >= 0)
                    g.DrawString(valueText, font, Brushes.Black, valueX, valueY);

                string indexText = i.ToString();
                SizeF indexSize = g.MeasureString(indexText, font);

                float indexX = x + (width - indexSize.Width) / 2;
                float indexY = panelDraw.Height - indexSize.Height;

                g.DrawString(indexText, font, Brushes.Gray, indexX, indexY);
            }
        }

        async Task Delay()
        {
            await Task.Delay(200);
        }

        void Explain(string text)
        {
            txtExplain.Text = text;
        }

        void Swap(int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;

            if (labels != null)
            {
                string s = labels[i];
                labels[i] = labels[j];
                labels[j] = s;
            }
        }


        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
        
            if (isSorting)
            {
                CheckSorting();
                return;
            }

            if (!CheckArray()) return;

            isSorting = true;
            isSorted = false;
        Explain(
                "Bubble Sort hoạt động bằng cách so sánh từng cặp phần tử liền kề trong mảng. " +
                "Nếu phần tử đứng trước lớn hơn phần tử đứng sau thì chúng sẽ được hoán đổi vị trí. " +
                "Sau mỗi vòng lặp, phần tử lớn nhất sẽ dần được đẩy về cuối mảng. " +
                "Quá trình này lặp lại cho đến khi toàn bộ mảng được sắp xếp theo thứ tự tăng dần."
            );
            ShowComparison("Bubble");
            lblStatus.Text = "Bubble Sort đang chạy";
            BubbleSort();
        }

        private async void BubbleSort()
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    DrawArray(j, j + 1);
                    await Delay();

                    if (arr[j] > arr[j + 1])
                    {
                        Swap(j, j + 1);
                        DrawArray(j, j + 1);
                        await Delay();
                    }
                }
            }
            isSorted = true;
            lblStatus.Text = "Bubble Sort xong";
            isSorting = false;
            DrawAllGreen();
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            isSorted = false;
            if (!CheckArray()) return;
            if (isSorting)
            {
                CheckSorting();
                return;
            }
            isSorting = true;

            Explain(
                "Quick Sort chọn một phần tử làm chốt (pivot) để phân chia mảng. " +
                "Các phần tử nhỏ hơn pivot được đưa về bên trái, các phần tử lớn hơn pivot được đưa về bên phải. " +
                "Sau khi phân hoạch xong, thuật toán tiếp tục áp dụng đệ quy cho từng mảng con cho đến khi mảng được sắp xếp hoàn chỉnh."
            );
            ShowComparison("Quick");
            lblStatus.Text = "Quick Sort đang chạy";
            QuickSort(0, arr.Length - 1);
        }
        async void QuickSort(int l, int r)
        {
            quickRunning++;
            if (l < r)
            {
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

                if (l < j) QuickSort(l, j);
                if (i < r) QuickSort(i, r);
            }

            quickRunning--;

            if (quickRunning == 0)
            {
                lblStatus.Text = "Quick Sort xong";
                isSorting = false;
                isSorted = true;
                DrawAllGreen();
            }
        }

        private async void btnHeapSort_Click(object sender, EventArgs e)
        {
            if (!CheckArray()) return;

            if (isSorting)
            {
                CheckSorting();
                return;
            }

            isSorting = true;
            isSorted = false;

            Explain(
                "Heap Sort bắt đầu bằng việc xây dựng cấu trúc heap từ mảng ban đầu, " +
                "trong đó phần tử lớn nhất luôn nằm ở gốc heap. " +
                "Sau đó, phần tử lớn nhất được hoán đổi với phần tử cuối mảng và loại khỏi heap. " +
                "Heap được điều chỉnh lại để tiếp tục tìm phần tử lớn nhất tiếp theo."
            );
            ShowComparison("Heap");
            lblStatus.Text = "Heap Sort đang chạy";

            try
            {
                await HeapSort();
            }
            finally
            {
                isSorting = false;
                isSorted = true;

                lblStatus.Text = "Heap Sort xong";
                DrawArray();
            }
        }


        private async Task HeapSort()
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


        private async Task Heapify(int n, int i)
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

        private async void btnMergeSort_Click(object sender, EventArgs e)
        {
            if (isSorting)
            {
                CheckSorting();
                return;
            }

            if (!CheckArray()) return;

            isSorting = true;
            isSorted = false;

            Explain(
                "Merge Sort hoạt động theo nguyên lý chia để trị. " +
                "Mảng ban đầu được chia thành các mảng con nhỏ hơn cho đến khi mỗi mảng chỉ còn một phần tử. " +
                "Sau đó, các mảng con được trộn lại với nhau theo thứ tự tăng dần để tạo thành mảng đã được sắp xếp."
            );
            ShowComparison("Merge");
            lblStatus.Text = "Merge Sort đang chạy";

            await MergeSort(0, arr.Length - 1);

            isSorted = true;
            isSorting = false;

            lblStatus.Text = "Merge Sort xong";
            DrawArray();
        }

        private async Task MergeSort(int l, int r)
        {
            if (l >= r) return;

            int m = (l + r) / 2;

            await MergeSort(l, m);
            await MergeSort(m + 1, r);
            await Merge(l, m, r);
        }

        private async Task Merge(int l, int m, int r)
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

        bool CheckArray()
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng sinh mảng trước khi thực hiện sắp xếp.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }
            return true;
        }

        void ShowComparison(string algo)
        {
            if (algo == "Bubble")
                txtExplain.Text +=
                    "\r\n\r\nSo sánh với các thuật toán khác:\r\n" +
                    "- Bubble Sort có cách hoạt động đơn giản nhất, dễ hiểu và dễ quan sát từng bước.\r\n" +
                    "- Tuy nhiên, độ phức tạp O(n²) khiến thuật toán này chậm khi số phần tử tăng.\r\n" +
                    "- Quick Sort, Merge Sort và Heap Sort có hiệu suất tốt hơn với O(n log n).\r\n" +
                    "- Bubble Sort phù hợp để minh họa nguyên lý sắp xếp hơn là sử dụng trong thực tế.";

            if (algo == "Quick")
                txtExplain.Text +=
                    "\r\n\r\nSo sánh với các thuật toán khác:\r\n" +
                    "- Quick Sort nhanh hơn Bubble Sort trong hầu hết các trường hợp.\r\n" +
                    "- Thuật toán hoạt động hiệu quả nhờ chia mảng theo pivot.\r\n" +
                    "- Tuy nhiên, Quick Sort không ổn định như Merge Sort.\r\n" +
                    "- Trong một số trường hợp xấu, Quick Sort có thể chậm hơn Heap Sort.";

            if (algo == "Merge")
                txtExplain.Text +=
                    "\r\n\r\nSo sánh với các thuật toán khác:\r\n" +
                    "- Merge Sort luôn đảm bảo độ phức tạp O(n log n) trong mọi trường hợp.\r\n" +
                    "- Thuật toán ổn định, giữ nguyên thứ tự các phần tử bằng nhau.\r\n" +
                    "- So với Quick Sort, Merge Sort tốn thêm bộ nhớ phụ.\r\n" +
                    "- So với Heap Sort, Merge Sort dễ hiểu và dễ minh họa hơn.";

            if (algo == "Heap")
                txtExplain.Text +=
                    "\r\n\r\nSo sánh với các thuật toán khác:\r\n" +
                    "- Heap Sort có hiệu suất ổn định O(n log n), không phụ thuộc dữ liệu đầu vào.\r\n" +
                    "- Không cần bộ nhớ phụ như Merge Sort.\r\n" +
                    "- Khó hiểu hơn Bubble Sort và Quick Sort do dựa trên cấu trúc heap.\r\n" +
                    "- Phù hợp với các bài toán yêu cầu hiệu suất ổn định.";
        }


        void DrawAllGreen()
        {
            if (arr == null || arr.Length == 0) return;

            panelDraw.Refresh();
            Graphics g = panelDraw.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int w = panelDraw.Width / arr.Length;
            int maxValue = arr.Max();
            int maxHeight = panelDraw.Height - 30;

            for (int i = 0; i < arr.Length; i++)
            {
                int h = (int)((arr[i] * 1.0 / maxValue) * maxHeight);

                int x = i * w + 6;
                int y = panelDraw.Height - h - 6;
                int width = w - 12;

                Rectangle rect = new Rectangle(x, y, width, h);
                Rectangle shadowRect = new Rectangle(x + 3, y + 3, width, h);

                using (Brush shadow = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
                {
                    g.FillRectangle(shadow, shadowRect);
                }

                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int r = 8;
                    path.AddArc(x, y, r, r, 180, 90);
                    path.AddArc(x + width - r, y, r, r, 270, 90);
                    path.AddArc(x + width - r, y + h - r, r, r, 0, 90);
                    path.AddArc(x, y + h - r, r, r, 90, 90);
                    path.CloseFigure();

                    using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                        rect,
                        Color.FromArgb(46, 204, 113),
                        Color.FromArgb(39, 174, 96),
                        90f))
                    {
                        g.FillPath(brush, path);
                    }

                    using (Pen border = new Pen(Color.FromArgb(30, 130, 76), 1))
                    {
                        g.DrawPath(border, path);
                    }
                }
                string valueText = arr[i].ToString();
                Font font = new Font("Segoe UI", 9, FontStyle.Bold);
                SizeF size = g.MeasureString(valueText, font);

                float tx = x + (width - size.Width) / 2;
                float ty = y - size.Height - 2;

                if (ty >= 0)
                    g.DrawString(valueText, font, Brushes.Black, tx, ty);
            }
        }


        private void btnNhapTay_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Chưa nhập dữ liệu!");
                    return;
                }

                string[] parts = input.Split(',')
                                      .Where(p => !string.IsNullOrWhiteSpace(p))
                                      .ToArray();

                arr = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i].Trim(), out arr[i]) || arr[i] <= 0)
                    {
                        MessageBox.Show($"Giá trị không hợp lệ: {parts[i]}");
                        return;
                    }
                }
                isFromExcel = false;
                isSorted = false;
                DrawArray();
                lblStatus.Text = "Đã nhập dữ liệu thủ công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (CheckSorting()) return;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.xlsx)|*.xlsx";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet ds = reader.AsDataSet();
                    DataTable table = ds.Tables[0];

                    int n = table.Rows.Count;

                    arr = new int[n];
                    labels = new string[n];

                    for (int i = 0; i < n; i++)
                    {
                        labels[i] = table.Rows[i][0].ToString();
                        arr[i] = Convert.ToInt32(table.Rows[i][1]);
                    }
                }
            }
            isFromExcel = true;
            isSorted = false;
            DrawArray();
            lblStatus.Text = "Đã nhập dữ liệu từ Excel (.xlsx)";
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isFromExcel|| arr == null || labels == null || arr.Length == 0) return;

            int w = panelDraw.Width / arr.Length;
            int index = e.X / w;

            if (index < 0 || index >= arr.Length)
            {
                barToolTip.Hide(panelDraw);
                hoverIndex = -1;
                return;
            }

            if (hoverIndex != index)
            {
                hoverIndex = index;

                string text =
                    labels[index] +
                    "\nVị trí: " + index +
                    "\nTrạng thái: " + (isSorted ? "Đã sắp xếp" : "Chưa sắp xếp");

                barToolTip.Show(text, panelDraw, e.X + 15, e.Y + 15);
            }
        }

        private void panelDraw_MouseLeave(object sender, EventArgs e)
        {
            barToolTip.Hide(panelDraw);
            hoverIndex = -1;
        }
        bool CheckSorting()
        {
            if (isSorting)
            {
                MessageBox.Show(
                    "Dữ liệu đang được sắp xếp, vui lòng đợi!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return true;
            }
            return false;
        }

    }
}

