using Calculator1.Entities;

namespace Calculator1
{
    public enum Sign
    {
        null0, addition, difference, multiplication, division
    }

    public partial class MainForm : Form
    {
        double nr1;
        double nr2;
        bool b1;
        Sign sign;

        public MainForm()
        {
            InitializeComponent();
            nr1 = 0;
            nr2 = 0;
            sign = Sign.null0;
            lv1.Font = new Font("Arial", 16, FontStyle.Regular);
            // Assuming listView1 is the name of your ListView control

            // Set AutoResizeColumns property to ColumnContent
            lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            // Hide column headers
            lv1.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click_1(object sender, EventArgs e)
        {
            if (sign == Sign.null0)
            {
                nr1 = nr1 * 10 + 1;
                lv1.Items.Clear();
                lv1.Items.Add(nr1.ToString());
            }
            else
            {
                nr2 = nr2 * 10 + 1;
                lv1.Items.Clear();
                lv1.Items.Add(nr2.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bteq_Click(object sender, EventArgs e)
        {
            Computation result = new Computation();
            if (sign == Sign.addition)
            {
                result.add(nr1, nr2);
            }
            else if (sign == Sign.difference)
            {
                result.diff(nr1, nr2);
            }
            else if (sign == Sign.multiplication)
            {
                result.multiply(nr1, nr2);
            }
            else
            {
                result.divide(nr1, nr2);
            }
            nr1 = result.getResult();
            sign = Sign.null0;
            lv1.Items.Clear();
            lv1.Items.Add(result.getResult().ToString());
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            sign = Sign.difference;
            lv1.Items.Clear();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (sign == Sign.null0)
            {
                nr1 = nr1 * 10 + 2;
                lv1.Items.Clear();
                lv1.Items.Add(nr1.ToString());
            }
            else
            {
                nr2 = nr2 * 10 + 2;
                lv1.Items.Clear();
                lv1.Items.Add(nr2.ToString());
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (sign == Sign.null0)
            {
                nr1 = nr1 * 10 + 3;
                lv1.Items.Clear();
                lv1.Items.Add(nr1.ToString());
            }
            else
            {
                nr2 = nr2 * 10 + 3;
                lv1.Items.Clear();
                lv1.Items.Add(nr2.ToString());
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (sign == Sign.null0)
            {
                nr1 = nr1 * 10 + 4;
                lv1.Items.Clear();
                lv1.Items.Add(nr1.ToString());
            }
            else
            {
                nr2 = nr2 * 10 + 4;
                lv1.Items.Clear();
                lv1.Items.Add(nr2.ToString());
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (sign == Sign.null0)
            {
                nr1 = nr1 * 10 + 5;
                lv1.Items.Clear();
                lv1.Items.Add(nr1.ToString());
            }
            else
            {
                nr2 = nr2 * 10 + 5;
                lv1.Items.Clear();
                lv1.Items.Add(nr2.ToString());
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (sign == Sign.null0)
            {
                nr1 = nr1 * 10 + 6;
                lv1.Items.Clear();
                lv1.Items.Add(nr1.ToString());
            }
            else
            {
                nr2 = nr2 * 10 + 6;
                lv1.Items.Clear();
                lv1.Items.Add(nr2.ToString());
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (sign == Sign.null0)
            {
                nr1 = nr1 * 10 + 7;
                lv1.Items.Clear();
                lv1.Items.Add(nr1.ToString());
            }
            else
            {
                nr2 = nr2 * 10 + 7;
                lv1.Items.Clear();
                lv1.Items.Add(nr2.ToString());
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (sign == Sign.null0)
            {
                nr1 = nr1 * 10 + 8;
                lv1.Items.Clear();
                lv1.Items.Add(nr1.ToString());
            }
            else
            {
                nr2 = nr2 * 10 + 8;
                lv1.Items.Clear();
                lv1.Items.Add(nr2.ToString());
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (sign == Sign.null0)
            {
                nr1 = nr1 * 10 + 9;
                lv1.Items.Clear();
                lv1.Items.Add(nr1.ToString());
            }
            else
            {
                nr2 = nr2 * 10 + 9;
                lv1.Items.Clear();
                lv1.Items.Add(nr2.ToString());
            }
        }

        private void btmul_Click(object sender, EventArgs e)
        {
            sign = Sign.multiplication;
            lv1.Items.Clear();
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            sign = Sign.division;
            lv1.Items.Clear();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            sign = Sign.addition;
            lv1.Items.Clear();
        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            // Hide column headers
            lv1.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            nr1 = 0;
            nr2 = 0;
            sign = Sign.null0;
            lv1.Items.Clear();
        }
    }
}