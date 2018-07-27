using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genesis_1._0
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
         
        }

  

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (menuvertical.Width == 50)
            {
                menuvertical.Visible = false;
                menuvertical.Width = 230;
                PanelAnimator2.ShowSync(menuvertical);
                LogoAnimator.ShowSync(logo);
                
            }
            else
            {
                LogoAnimator.HideSync(logo);
                menuvertical.Visible = false;
                menuvertical.Width = 50;
                PanelAnimator2.ShowSync(menuvertical);
                
            }


        }

        
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Maestro m = new Maestro();
            panel1.Controls.Add(m);
            m.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Procesos m = new Procesos();
            panel1.Controls.Add(m);
            m.BringToFront();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        { Environment.Exit(0); }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Calidad m = new Calidad();
            panel1.Controls.Add(m);
            m.BringToFront();
        }
    }
}
