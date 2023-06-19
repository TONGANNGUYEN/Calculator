namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtBox1.Text);
            int b = int.Parse(txtBox2.Text);
            int kq = a + b;
            lbKetQua.Text = kq.ToString();
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtBox1.Text);
            int b = int.Parse(txtBox2.Text);
            int kq = a - b;
            lbKetQua.Text = kq.ToString();
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtBox1.Text);
            int b = int.Parse(txtBox2.Text);
            int kq = a * b;
            lbKetQua.Text = kq.ToString();
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtBox1.Text);
            int b = int.Parse(txtBox2.Text);
            if (b != 0)
                lbKetQua.Text = String.Format("{0:0.##}", (double)a / b);
            else
                lbKetQua.Text = "Divide By Zero Fault";
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}