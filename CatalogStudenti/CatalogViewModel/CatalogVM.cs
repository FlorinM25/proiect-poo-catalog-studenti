using CatalogStudenti.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CatalogStudenti.CatalogViewModel
{
    public class CatalogVM
    { 
        public ObservableCollection<string> CodMatricol { get; set; }
        public ObservableCollection<string> NumeStudent { get; set; }
        public ObservableCollection<string> PreumeStudent { get; set; }
        public ObservableCollection<string> CodProiect { get; set; }
        public ObservableCollection<string> NumeProiect { get; set; }
        public ObservableCollection<string> NotaStudent { get; set; }
        public ObservableCollection<string> NumarulDeVize { get; set; }

        public CatalogVM()
        {
            CodMatricol = new ObservableCollection<string>();
            NumeStudent = new ObservableCollection<string>();
            PreumeStudent = new ObservableCollection<string>();
            CodProiect = new ObservableCollection<string>();
            NumeProiect = new ObservableCollection<string>();
            NotaStudent = new ObservableCollection<string>();
            NumarulDeVize = new ObservableCollection<string>();
        }
    }
}
