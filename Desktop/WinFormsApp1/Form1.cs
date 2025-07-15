using WinFormsApp1.Core;
using WinFormsApp1.Core.GitHub;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;

        public Form1()
        {
            InitializeComponent();
            parser=new ParserWorker<string[]>(new GitParser());
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;

        }

       

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("Все супер!");
        }
        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listTitle.Items.AddRange(arg2);
        }

       

        private void button_start_Click(object sender, EventArgs e)
        {
            parser.Settings = new GitSettings((int)numericUpDown1.Value,(int)numericUpDown2.Value);
            parser.Start();


        }
        private void button_stop_Click(object sender, EventArgs e)
        {
            parser.Stop();
        }
    }
}
