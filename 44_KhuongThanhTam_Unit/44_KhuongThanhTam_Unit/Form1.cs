namespace _44_KhuongThanhTam_Unit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnh_Click(object sender, EventArgs e)
        {
            string a = txtnum.Text;
            int KQ = 0;
            _44_Tam_Caculation c = new _44_Tam_Caculation();
            KQ = c.Chon("BinaryToDecimal", a, 0);
            txtresult.Text = KQ.ToString();
        }

        private void btTh_Nh_Click(object sender, EventArgs e)
        {
            string a = txtnum.Text;
            int decimalNumber = int.Parse(a);
            string KQ;
            _44_Tam_Caculation c = new _44_Tam_Caculation();
            KQ = c.Chon("DecimalToBinary", " ",
            decimalNumber).ToString();
            txtresult.Text = KQ;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
        }
    }
}
