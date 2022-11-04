using Superheroes.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.VistaModelo
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private Superheroe heroeActual;
        public Superheroe HeroeActual
        {
            get { return heroeActual; }
            set
            {
                heroeActual = value;
                this.NotifyPropertyChanged("HeroeActual");
            }
        }

        private int _totalHeroes;
        public int TotalHeroes
        {
            get { return _totalHeroes; }
            set
            {
                _totalHeroes = value;
                this.NotifyPropertyChanged("TotalHeroes");
            }
        }

        private int _posicion;
        public int Posicion
        {
            get { return _posicion; }
            set
            {
                _posicion = value;
                this.NotifyPropertyChanged("Posicion");
            }
        }

        private List<Superheroe> lista = Superheroe.GetSamples();

        public MainWindowVM()
        {
            this.Posicion = 1;
            this.HeroeActual = lista[Posicion-1];
            this.TotalHeroes = lista.Count;
        }

        public void Siguiente()
        {
            if (Posicion < TotalHeroes)
            {
                Posicion++;
                HeroeActual = lista[Posicion-1];
            }

        }

        public void Anterior()
        {
            if (Posicion > 1)
            {
                Posicion--;
                HeroeActual = lista[Posicion-1];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
