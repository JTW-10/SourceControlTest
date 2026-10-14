namespace SourceControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateAddition_Click(object sender, EventArgs e)
        {
            string additionNum1 = txtNum1Addition.Text;
            string additionNum2 = txtNum2Addition.Text;

            double additionResult = Convert.ToDouble(additionNum1) + Convert.ToDouble(additionNum2);
            txtResultAddition.Text = Convert.ToString(additionResult);
        }
    }
}
