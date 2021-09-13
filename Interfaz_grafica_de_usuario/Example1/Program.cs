using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Program : Form
    {
        bool Dir1, Dir2;
        Button button1;
        private Timer timer1;
        private System.ComponentModel.IContainer components;
        // Inicializando
        public Program()
        {
            InitializeComponent();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-==-=-=-==-=-=-==-=-=-==-=-=-==-=-=-==-=-=-=\n" +
                "Programa hecho por Eduardo Campos\n" +
                "Basado en C# Code Academy\n " +
                "=-=-=-==-=-=-==-=-=-==-=-=-==-=-=-==-=-=-==-=-=-=");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 231);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 128);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(890, 589);
            this.Controls.Add(this.button1);
            this.Name = "Program";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz hecho click.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Dir1 == true)
            {
                button1.Left += 5;
            }
            else if (Dir1 == false)
            {
                button1.Left -= 5;
            }

            if (Dir2 == true)
            {
                button1.Top -= 5;
            }
            else if (Dir2 == false)
            {
                button1.Top += 5;
            }

            if (button1.Left <= this.ClientRectangle.Left)
            {
                Dir1 = true;
            }

            if (button1.Left + button1.Width >= this.ClientRectangle.Right)
            {
                Dir1 = false;
            }

            if (button1.Top <= this.ClientRectangle.Top)
            {
                Dir2 = false;
            }

            if (button1.Top >= this.ClientRectangle.Bottom)
            {
                Dir2 = true;
            }
        }
    }
}
