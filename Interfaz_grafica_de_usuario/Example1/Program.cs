using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Example1
{
    public  partial class Program : Form
    {
        private Button button1;

        public Program()
        {
            InitializeComponent();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-==-=-=-==-=-=-==-=-=-==-=-=-==-=-=-==-=-=-=\n" +
                "Programa hecho por Eduardo Campos\n" +
                "Basado en C# Code Academy\n" +
                "=-=-=-==-=-=-==-=-=-==-=-=-==-=-=-==-=-=-==-=-=-=");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hola mundo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.button1);
            this.Name = "Program";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz hecho click.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
