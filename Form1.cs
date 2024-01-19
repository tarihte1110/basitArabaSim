namespace CarProject
{
    public partial class Form1 : Form
    {
        bool isGasOpen = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Gas_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = true;
        }

        private void brake_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGasOpen)
            {
                Car.Location = new Point(Car.Location.X, Car.Location.Y - 6);
            }

        }

    }
}