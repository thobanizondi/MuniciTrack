namespace MuniciTrack
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // private void button2_Click(object sender, EventArgs e)
        // {

        /// <summary>
        /// }
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ReportIssues_Click(object sender, EventArgs e)
        {
            //project name: MuniciTrack Report Issues button click event
            var reportIssue = new ReportIssues();
            reportIssue.Show();


        }

        private void EventsAndAnnouncements_Click(object sender, EventArgs e)
        {
            //project name: MuniciTrack Events and Announcements button click event
            MessageBox.Show("Feature coming soon!");


        }

        private void ServiceRequestStatus_Click(object sender, EventArgs e)
        {
            //project name: MuniciTrack Service Request Status button click event
            MessageBox.Show("Feature coming soon!");


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //project name: MuniciTrack closing
            Application.Exit();

        }
    }
}
