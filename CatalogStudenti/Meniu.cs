using CatalogStudenti.CatalogViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogStudenti
{
    public partial class Meniu : Form
    {
        public CatalogVM context { get; set; }

        public Meniu()
        {
            InitializeComponent();
            context = new CatalogVM();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CatalogClick(object sender, EventArgs e)
        {
            var Catalog = new Catalog(context);
            Catalog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void StudentButtonMeniu_Click(object sender, EventArgs e)
        {

        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            
        }

        private void adaugadatelebuton_Click(object sender, EventArgs e)
        {
            var AdaugaDatele = new AdaugaDatele(context);
            AdaugaDatele.Show();
        }

        private void MeniuLabel_Click(object sender, EventArgs e)
        {

        }

        private void logoLabel_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBlock_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
