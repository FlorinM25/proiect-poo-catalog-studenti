using CatalogStudenti.CatalogViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatalogStudenti
{
    public partial class AdaugaDatele : Form
    {   
        public CatalogVM context { get; set; }
        public AdaugaDatele(CatalogVM con)
        {
            InitializeComponent();
            context = con;
        }

        public void adaugaDateleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datele au fost adaugate in Catalog");

            context.NumeStudent.Add(NumeStudentTxt.Text);
            context.PreumeStudent.Add(prenumeStudentTxt.Text);
            context.NotaStudent.Add(NotaStudentTxt.Text);
            context.CodMatricol.Add(CodStudentTxt.Text);
            context.NumeProiect.Add(NumeMaterieTxt.Text);
            context.CodProiect.Add(CodProiectTxt.Text);
            context.NumarulDeVize.Add(nrDeVizeTxt.Text);

            context.NumeStudent.Add("-----------------");
            context.PreumeStudent.Add("-----------------");
            context.NotaStudent.Add("-----------------");
            context.CodMatricol.Add("-----------------");
            context.NumeProiect.Add("-----------------");
            context.CodProiect.Add("-----------------");
            context.NumarulDeVize.Add("-----------------");
        }

        private void AdaugaDatele_Load(object sender, EventArgs e)
        {

        }

        private void TitleBlockLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
