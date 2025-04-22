using MyCommonLib;

namespace MainProjct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime("1995/3/21");
            string age = new TestMethod().GetAgeByYear(date);
            MessageBox.Show(new TestMethod().GetString("¤p©ú"));
            MessageBox.Show(age, "Age", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
