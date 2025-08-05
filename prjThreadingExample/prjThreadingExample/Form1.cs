namespace prjThreadingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Start_Click(object sender, EventArgs e)
        {

            Task<int> task = new Task<int>(Read);
            task.Start();
            lbl_Status.Text = "File Processing .... Asb Wag.....";
           
            int count = await task;
            lbl_Count.Text = count.ToString();
            lbl_Status.Text = "Number of chars in the files";

        }



        public static int Read()
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(@"Products.txt"))
            {
                string fileContent = reader.ReadToEnd();
                count = fileContent.Length;
                Thread.Sleep(5000);
            }
            return count;

        }

    }
}
