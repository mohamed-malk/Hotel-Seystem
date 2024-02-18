using Plotly.NET;

namespace Hotel_System_Front.User_Control
{
    public partial class Reports : UserControl
    {
        private readonly InformationRepo _informationReport;
      
        public Reports()
        {
            InitializeComponent();
            _informationReport = new InformationRepo();
        }
        private void UC_Feedback_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _informationReport.Report(DateTime.Now.Month);

                Dictionary<string, float> insights = _informationReport.Insights(DateTime.Now.Month);
                totalLb.Text = insights["Total Income"].ToString();
                actualLb.Text = insights["Actual Income"].ToString();
                outLb.Text = insights["Out Income"].ToString();

                var customerCat = _informationReport.ClientsCategory();
                var topTen = _informationReport.TopRooms(10);
                var lastTen = _informationReport.LastRooms(10);

                List<string> members = new List<string>();
                List<int> clients = new List<int>();

                foreach (var member in customerCat)
                {
                    members.Add(member.MemberShipName);
                    clients.Add(member.ClientsNumber);
                }

                Chart2D.Chart.Column<int, string, string, string, string>(clients, members).Show();

                Chart2D.Chart.Column<int, int, string, string, string>(topTen).Show();
                Chart2D.Chart.Column<int, int, string, string, string>(lastTen).Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
