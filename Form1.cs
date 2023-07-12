namespace codeChallenge5
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn_MathV1_Click(object sender, EventArgs e)
        {
            MathVersion1 mathOperations = new MathVersion1();
            mathOperations.StartPosition = FormStartPosition.Manual;
            mathOperations.Location = this.Location;
            mathOperations.Show();
            this.Hide();
        }

        private void btn_MathV2_Click(object sender, EventArgs e)
        {
            MathVersion2 mathV2 = new MathVersion2();
            mathV2.StartPosition = FormStartPosition.Manual;
            mathV2.Location = this.Location;
            mathV2.Show();
            this.Hide();
        }

        private void btn_FPC_Click(object sender, EventArgs e)
        {
            FontPropertyChanger FPC = new FontPropertyChanger();
            FPC.StartPosition = FormStartPosition.Manual;
            FPC.Location = this.Location;
            FPC.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}