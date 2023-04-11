using CatalogStudenti.CatalogViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogStudenti
{
    public partial class Catalog : Form
    {
        CatalogVM context { get; set; }
        
        public Catalog(CatalogVM con)
        {
           
            
                InitializeComponent();
                context = con;
                CodMatricolListBox.DataSource = context.CodMatricol;
                StudentListBox.DataSource = context.NumeStudent;
                prenumeStudentListBox.DataSource = context.PreumeStudent;
                CodProiectListBox.DataSource = context.CodProiect;
                ProiectCatalogListBox.DataSource = context.NumeProiect;
                notaStudentListBox.DataSource = context.NotaStudent;
                NrDeVizeListBox.DataSource = context.NumarulDeVize;

                context = con;
         }
        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void CodMatricolListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stergeButton_Click(object sender, EventArgs e)
        {
            context.NumeStudent.RemoveAt(StudentListBox.SelectedIndex);
            context.PreumeStudent.RemoveAt(StudentListBox.SelectedIndex);
            context.NotaStudent.RemoveAt(StudentListBox.SelectedIndex);
            context.CodMatricol.RemoveAt(StudentListBox.SelectedIndex);
            context.NumeProiect.RemoveAt(StudentListBox.SelectedIndex);
            context.CodProiect.RemoveAt(StudentListBox.SelectedIndex);
            context.NumarulDeVize.RemoveAt(NrDeVizeListBox.SelectedIndex);

            context.NumeStudent.RemoveAt(StudentListBox.SelectedIndex);
            context.PreumeStudent.RemoveAt(StudentListBox.SelectedIndex);
            context.NotaStudent.RemoveAt(StudentListBox.SelectedIndex);
            context.CodMatricol.RemoveAt(StudentListBox.SelectedIndex);
            context.NumeProiect.RemoveAt(StudentListBox.SelectedIndex);
            context.CodProiect.RemoveAt(StudentListBox.SelectedIndex);
            context.NumarulDeVize.RemoveAt(NrDeVizeListBox.SelectedIndex);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Catalog refresh = new Catalog(context);
            refresh.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
