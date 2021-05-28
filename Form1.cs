using System;
using System.IO;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidGrid
{
    public partial class Form1 : Form
    {
        bool ison;

        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            RawCoord.Checked = true;
            textBox1.AcceptsReturn = true;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files | *.jpg;*.jpeg;*.gif;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                if (pictureBox1.Image.Width % 8 != 0 | pictureBox1.Image.Height % 8 != 0)
                {
                    MessageBox.Show("Warning:The picture is not 8 by 8.");
                }

                label_X.Visible = true;
                label_Y.Visible = true;
                labelX8.Visible = true;
                labelY8.Visible = true;
                SpriteX.Visible = true;
                SpriteY.Visible = true;
                button2.Visible = true;

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            Point point = mouseEventArgs.Location;
            label_X.Text = Convert.ToString(mouseEventArgs.X);
            label_Y.Text = Convert.ToString(mouseEventArgs.Y);
            labelX8.Text = Convert.ToString(mouseEventArgs.X / 8);
            labelY8.Text = Convert.ToString(mouseEventArgs.Y / 8);
            SpriteX.Text = Convert.ToString(mouseEventArgs.X + 128);
            SpriteY.Text = Convert.ToString(mouseEventArgs.Y + 128);
            if ( e.Button == MouseButtons.Left )
            {
                var PointX = mouseEventArgs.X;
                var PointY = mouseEventArgs.Y;
                StringBuilder stringBuilder = new StringBuilder();
                if (RawCoord.Checked == true)
                {
                    stringBuilder.Append("DataInt ");
                    stringBuilder.Append(Convert.ToString(PointX));
                    stringBuilder.Append(",");
                    stringBuilder.Append(Convert.ToString(PointY));
                    stringBuilder.Append(Environment.NewLine);

                    textBox1.AppendText(Convert.ToString(stringBuilder));
                }
                else if (BlockCoordinate.Checked == true)
                {
                    stringBuilder.Append("Data ");
                    stringBuilder.Append(labelX8.Text);
                    stringBuilder.Append(",");
                    stringBuilder.Append(labelY8.Text);
                    stringBuilder.Append(Environment.NewLine);
                    textBox1.AppendText(Convert.ToString(stringBuilder));

                }
                else if (SpriteCoordinate.Checked == true)
                {
                    stringBuilder.Append("Data ");
                    stringBuilder.Append(SpriteX.Text);
                    stringBuilder.Append(",");
                    stringBuilder.Append(SpriteY.Text);
                    stringBuilder.Append(Environment.NewLine);
                    textBox1.AppendText(Convert.ToString(stringBuilder));

                }

            }


        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (Graphics g = pictureBox1.CreateGraphics())
            {
                //g.Clear(Color.Transparent);
                Pen p = new Pen(Color.Red, 1.0f);

                for (int i = 0; i < 479; i += 8)
                {
                    g.DrawLine(p, 0, i, 659, i);
                }
                for (int i = 0; i < 639; i += 8)
                {
                    g.DrawLine(p, i, 0, i, 639);
                }



            }
        }//Draws the grid on the screen.

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            Point point = mouseEventArgs.Location;
            
            if (e.Button == MouseButtons.Left)
            {
                var PointX = mouseEventArgs.X;
                var PointY = mouseEventArgs.Y;
                StringBuilder stringBuilder = new StringBuilder();
                if (RawCoord.Checked == true)
                {
                    stringBuilder.Append("DataInt ");
                    stringBuilder.Append(Convert.ToString(PointX));
                    stringBuilder.Append(",");
                    stringBuilder.Append(Convert.ToString(PointY));
                    stringBuilder.Append(Environment.NewLine);
                    textBox1.AppendText(Convert.ToString(stringBuilder));
                    
                }
                else if (BlockCoordinate.Checked == true)
                {
                    stringBuilder.Append("Data ");
                    stringBuilder.Append(labelX8.Text);
                    stringBuilder.Append(",");
                    stringBuilder.Append(labelY8.Text);
                    stringBuilder.Append(Environment.NewLine);
                    textBox1.AppendText(Convert.ToString(stringBuilder));

                }
                else if (SpriteCoordinate.Checked == true)
                {
                    stringBuilder.Append("Data ");
                    stringBuilder.Append(SpriteX.Text);
                    stringBuilder.Append(",");
                    stringBuilder.Append(SpriteY.Text);
                    stringBuilder.Append(Environment.NewLine);
                    textBox1.AppendText(Convert.ToString(stringBuilder));

                }

            }

        }

        private void SaveText_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"c:\";
            saveFileDialog.Title = "Save Coordinate list";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = false;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Other Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            
            {
                //textBox1.Text = saveFileDialog.FileName;
                string name = saveFileDialog.FileName;
                File.WriteAllText(name, textBox1.Text);
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            //toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 300;
            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;
            //toolTip1.SetToolTip(this.SaveText, "Saves the content of the Textbox.");
            //toolTip1.Show("Saves the content of the Textbox.", SaveText);
        }

        private void SaveText_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Saves the content of the Textbox.", SaveText);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Draws an eight by eight grid over the loaded picture.", button2);
        }

        private void RawCoord_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Gives the raw coordinates starting from 0,0.", RawCoord);
        }

        private void BlockCoordinate_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Gets the eight by eight block count.", BlockCoordinate);
        }

        private void SpriteCoordinate_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Gives the Coordinates for a MD screen, which starts at 128,128.", SpriteCoordinate);
        }
    }
}
