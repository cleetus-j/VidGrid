
namespace VidGrid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveText = new System.Windows.Forms.Button();
            this.SpriteCoordinate = new System.Windows.Forms.RadioButton();
            this.BlockCoordinate = new System.Windows.Forms.RadioButton();
            this.RawCoord = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SpriteY = new System.Windows.Forms.Label();
            this.SpriteX = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelY8 = new System.Windows.Forms.Label();
            this.labelX8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveText);
            this.groupBox1.Controls.Add(this.SpriteCoordinate);
            this.groupBox1.Controls.Add(this.BlockCoordinate);
            this.groupBox1.Controls.Add(this.RawCoord);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.SpriteY);
            this.groupBox1.Controls.Add(this.SpriteX);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelY8);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_Y);
            this.groupBox1.Controls.Add(this.label_X);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // SaveText
            // 
            this.SaveText.Location = new System.Drawing.Point(461, 10);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(75, 23);
            this.SaveText.TabIndex = 17;
            this.SaveText.Text = "Save to txt";
            this.SaveText.UseVisualStyleBackColor = true;
            this.SaveText.Click += new System.EventHandler(this.SaveText_Click);
            this.SaveText.MouseHover += new System.EventHandler(this.SaveText_MouseHover);
            // 
            // SpriteCoordinate
            // 
            this.SpriteCoordinate.AutoSize = true;
            this.SpriteCoordinate.Location = new System.Drawing.Point(259, 50);
            this.SpriteCoordinate.Name = "SpriteCoordinate";
            this.SpriteCoordinate.Size = new System.Drawing.Size(122, 19);
            this.SpriteCoordinate.TabIndex = 16;
            this.SpriteCoordinate.TabStop = true;
            this.SpriteCoordinate.Text = "Sprite Coordinates";
            this.SpriteCoordinate.UseVisualStyleBackColor = true;
            this.SpriteCoordinate.MouseHover += new System.EventHandler(this.SpriteCoordinate_MouseHover);
            // 
            // BlockCoordinate
            // 
            this.BlockCoordinate.AutoSize = true;
            this.BlockCoordinate.Location = new System.Drawing.Point(259, 31);
            this.BlockCoordinate.Name = "BlockCoordinate";
            this.BlockCoordinate.Size = new System.Drawing.Size(121, 19);
            this.BlockCoordinate.TabIndex = 15;
            this.BlockCoordinate.TabStop = true;
            this.BlockCoordinate.Text = "Block Coordinates";
            this.BlockCoordinate.UseVisualStyleBackColor = true;
            this.BlockCoordinate.MouseHover += new System.EventHandler(this.BlockCoordinate_MouseHover);
            // 
            // RawCoord
            // 
            this.RawCoord.AutoSize = true;
            this.RawCoord.Location = new System.Drawing.Point(259, 13);
            this.RawCoord.Name = "RawCoord";
            this.RawCoord.Size = new System.Drawing.Size(114, 19);
            this.RawCoord.TabIndex = 14;
            this.RawCoord.TabStop = true;
            this.RawCoord.Text = "Raw Coordinates";
            this.RawCoord.UseVisualStyleBackColor = true;
            this.RawCoord.MouseHover += new System.EventHandler(this.RawCoord_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Grid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // SpriteY
            // 
            this.SpriteY.AutoSize = true;
            this.SpriteY.Location = new System.Drawing.Point(215, 50);
            this.SpriteY.Name = "SpriteY";
            this.SpriteY.Size = new System.Drawing.Size(38, 15);
            this.SpriteY.TabIndex = 12;
            this.SpriteY.Text = "label8";
            this.SpriteY.Visible = false;
            // 
            // SpriteX
            // 
            this.SpriteX.AutoSize = true;
            this.SpriteX.Location = new System.Drawing.Point(215, 17);
            this.SpriteX.Name = "SpriteX";
            this.SpriteX.Size = new System.Drawing.Size(38, 15);
            this.SpriteX.TabIndex = 11;
            this.SpriteX.Text = "label7";
            this.SpriteX.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "SpriteY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "SpriteX:";
            // 
            // labelY8
            // 
            this.labelY8.AutoSize = true;
            this.labelY8.Location = new System.Drawing.Point(118, 51);
            this.labelY8.Name = "labelY8";
            this.labelY8.Size = new System.Drawing.Size(38, 15);
            this.labelY8.TabIndex = 7;
            this.labelY8.Text = "label8";
            this.labelY8.Visible = false;
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Location = new System.Drawing.Point(118, 19);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(38, 15);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "label7";
            this.labelX8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Y/8:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "X/8:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "X:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(30, 50);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(38, 15);
            this.label_Y.TabIndex = 1;
            this.label_Y.Text = "label2";
            this.label_Y.Visible = false;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(30, 19);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(38, 15);
            this.label_X.TabIndex = 0;
            this.label_X.Text = "label1";
            this.label_X.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(705, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(240, 480);
            this.textBox1.TabIndex = 2;
            this.textBox1.WordWrap = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(665, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "VidGrid Screen Coordinate helper tool for Mega Drive and console developments. \"P" +
    "rogrammed\" by lv06221 (Option Co Ltd.)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 606);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "VidGrid Coordinate Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelY8;
        private System.Windows.Forms.Label labelX8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SpriteY;
        private System.Windows.Forms.Label SpriteX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton SpriteCoordinate;
        private System.Windows.Forms.RadioButton BlockCoordinate;
        private System.Windows.Forms.RadioButton RawCoord;
        private System.Windows.Forms.Button SaveText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
    }
}

