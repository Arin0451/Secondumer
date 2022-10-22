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
            if (button1.Text == "Старт")
            {
                button1.Text = "Стоп";
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "Старт";
                timer1.Enabled = false;
            }

            StartTime = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            // Начнем с дней, если больше 0.
            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            // Преобразование миллисекунд в десятые доли секунды.
            int tenths = elapsed.Milliseconds / 100;

            // Запишите оставшееся время.
            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00") + ":" +
                tenths.ToString("0");

            label1.Text = text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "Старт";
            timer1.Enabled = false;
            label1.Text = "00:00:00:0";
        }
    }
}