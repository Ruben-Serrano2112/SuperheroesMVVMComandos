using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesMVVM
{
    class MainWindowVM : ObservableObject
    {
        private List<Superheroe> heroes;

        private Superheroe heroeActual;

        public Superheroe HeroeActual
        {
            get { return heroeActual; }
            set 
            {
                SetProperty(ref heroeActual, value);
            }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set 
            {
                SetProperty(ref total, value);
            }
        }

        private int actual;

        public int Actual
        {
            get { return actual; }
            set 
            {
                SetProperty(ref actual, value);
            }
        }

        private RelayCommand siguienteComand;

        public RelayCommand SiguienteComand
        {
            get { return siguienteComand; }
            set { SetProperty(ref siguienteComand, value); }
        }

        private RelayCommand retrocederComand;

        public RelayCommand RetrocederComand
        {
            get { return retrocederComand; }
            set { SetProperty(ref retrocederComand, value); }
        }

        ListaSuperheroes lista = new ListaSuperheroes();

        public MainWindowVM()
        {

            heroes = lista.GetSamples();
            HeroeActual = heroes[0];
            Total = heroes.Count;
            Actual = 1;
            SiguienteComand = new RelayCommand(Siguiente);
            RetrocederComand = new RelayCommand(Anterior);
        }

        

        public void Siguiente()
        { 
            if (Actual < Total)
            {
                Actual++;
                HeroeActual = heroes[Actual-1];
            }
        }

        public void Anterior()
        {
            if (Actual > 1)
            {
                Actual--;
                HeroeActual = heroes[Actual-1];
            }
        }
    }
}
