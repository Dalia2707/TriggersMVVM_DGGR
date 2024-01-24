using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TriggersMVVM_DGGR.Modelo;

namespace TriggersMVVM_DGGR.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias()
                {
                    descripccion = "Cena",
                    numeroItem =4512,
                    imagen="https://i.ibb.co/s1dHhGv/pokebola.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias()
                {
                    descripccion="Hotel",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/s1dHhGv/pokebola.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias()
                {
                    descripccion="Fiesta",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/s1dHhGv/pokebola.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias()
                {
                    descripccion="Flores",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/s1dHhGv/pokebola.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
            };
        }
    }
}
