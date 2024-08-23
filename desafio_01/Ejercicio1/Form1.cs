using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 15000; // 15 segundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close(); // Cierra el formulario después de 15 segundos
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
