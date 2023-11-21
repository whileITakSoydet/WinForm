namespace MouseChecked
{
    public partial class MouseForm : Form
    {
        private bool _controlIsDown = false;
        public MouseForm()
        {
            InitializeComponent();
        }

        private void MouseForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (_controlIsDown)
            {
                this.Close();
            }
            var hight = this.Height;
            var width = this.Width;
            if (e.Button == MouseButtons.Right)
            {
                this.Text = $"Current position x= {e.Location.X}; y= {e.Location.Y}" +
                    $" Max x= {hight} y= {width}";
            }
            if (e.Button == MouseButtons.Left)
            {
                if ((e.Location.X == 50 || e.Location.Y == 50) ||
                    (e.Location.X == (width - 50) || e.Location.Y == (hight - 50)))
                {
                    MessageBox.Show("Mouse is on border rectangle");
                }
                else if ((e.Location.X > 50 && e.Location.Y > 50) &&
                    (e.Location.X < (width - 50) && e.Location.Y < (hight - 50)))
                {
                    MessageBox.Show("Mouse is into rectangle");
                }
                else
                {
                    MessageBox.Show("Mouse is out rectangle");
                }
            }
        }

        private void MouseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                _controlIsDown = true;
            }
        }

        private void MouseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                _controlIsDown = false;
            }
        }
    }
}
