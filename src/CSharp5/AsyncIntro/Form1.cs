namespace AsyncIntro
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new();
        private readonly Label label;
        private readonly Button button;

        public Form1()
        {
            label = new Label
            {
                Location = new Point(10, 20),
                Text = "Length"
            };
            button = new Button
            {
                Location = new Point(10, 50),
                Text = "Click"
            };
            button.Click += DisplayWebSiteLength;
            AutoSize = true;
            Controls.Add(label);
            Controls.Add(button);
            InitializeComponent();
        }

        async void DisplayWebSiteLength(object sender, EventArgs e)
        {
            label.Text = "Fetching...";
            string text = await client.GetStringAsync("http://csharpindepth.com");
            label.Text = text.Length.ToString();
        }
    }
}