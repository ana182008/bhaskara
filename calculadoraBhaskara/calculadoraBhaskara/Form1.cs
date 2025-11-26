namespace calculadoraBhaskara
{
    public partial class Form1 : Form
    {

        private TextBox ativo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtC.Enabled = true;

            txtA.ReadOnly = false;
            txtB.ReadOnly = false;
            txtC.ReadOnly = false;
        }

        private void Txt_Enter (object sender, EventArgs e)
        {
            ativo = sender as TextBox;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "3";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            ativo = txtA;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ativo = txtB;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "x";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "0";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);

            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                double raiz = Math.Sqrt(delta);
                double x1 = (-b + raiz) / (2 * a);
                double x2 = (-b + raiz) / (2 * a);
                txtX1.Text = x1.ToString();
                txtX2.Text = x2.ToString();
            }
            else
            {
                double real = -b / (2 * a);
                double imag = Math.Sqrt(delta) / (2 * a);
                txtX1.Text = $"{real} + {imag}i";
                txtX2.Text = $"{real} - {imag}i";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            ativo = txtC;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "6";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ativo != null)
                ativo.Text += "-";
        }

        private void txtDelta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
