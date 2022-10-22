namespace Timer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime StartTime;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "�����")
            {
                button1.Text = "����";
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "�����";
                timer1.Enabled = false;
            }

            StartTime = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            // ������ � ����, ���� ������ 0.
            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            // �������������� ����������� � ������� ���� �������.
            int tenths = elapsed.Milliseconds / 100;

            // �������� ���������� �����.
            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00") + ":" +
                tenths.ToString("0");

            label1.Text = text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "�����";
            timer1.Enabled = false;
            label1.Text = "00:00:00:0";
        }
    }
}