namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirst.Text);
            int b = Convert.ToInt32(txtSecond.Text);
            txtResult.Text = (a + b).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirst.Text);
            int b = Convert.ToInt32(txtSecond.Text);

            if (b != 0)  // Check to avoid division by zero
            {
                float r = (float)a / b;
                txtResult.Text = r.ToString();
            }
            else
            {
                txtResult.Text = "Error: Division by zero!";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirst.Text);
            int b = Convert.ToInt32(txtSecond.Text);
            txtResult.Text = (a - b).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirst.Text);
            int b = Convert.ToInt32(txtSecond.Text);
            txtResult.Text = (a * b).ToString();
        }
    }
}
