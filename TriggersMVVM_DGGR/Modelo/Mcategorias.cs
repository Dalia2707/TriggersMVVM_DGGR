using System;
using System.Collections.Generic;
using System.Text;
using TriggersMVVM_DGGR.VistaModelo;

namespace TriggersMVVM_DGGR.Modelo
{
    public class Mcategorias : BaseViewModel
    {
        public string descripccion { get; set; }
        public int numeroItem { get; set; }
        public string imagen { get; set; }

        //Objetos que interactuan con la interfaz
        public string _backgroundColor;
        public string _textColor;
        public bool _selected;

        public string backgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }
        public string textColor
        {
            get { return _textColor; }
            set { SetValue(ref _textColor, value); }
        }
        public bool selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }
    }
}
