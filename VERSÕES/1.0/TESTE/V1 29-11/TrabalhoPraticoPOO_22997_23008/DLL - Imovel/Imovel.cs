/*
 *  Class Imovel
 *	Autor: Fábio Rafael Gomes Costa || Luis Pedro Pereira Freitas
 *	Contato: a22997@alunos.ipca.pt ||a23008@alunos.ipca.pt
 *	Data: 01/11/2023
*/

using Interfaces;
using System.Collections.Generic;

namespace DLLImovel
{
    public class Imovel : IImoveis
    {
        #region ATRIBUTOS
        private int idPredial;
        private string estadoPredial;
        private int valorAluguer;
        private int valorPredial;
        

        #endregion
        #region COMPORTAMENTO

        #region CONSTRUTORES
        public Imovel()
        {
            idPredial = 0;
            estadoPredial = "";
            valorAluguer = 0;
            valorPredial = 0;
        }

        public Imovel(string estadoPredial, int idPredial, int valorAluguer, int valorPredial, List<Morada> morada)
        {
            this.estadoPredial = estadoPredial;
            this.idPredial = idPredial;
            this.valorAluguer = valorAluguer;
            this.valorPredial = valorPredial;
            this.morada = morada;
        }


        #endregion
        #region PROPRIEDADES
        public int IdPredial
        {
           get { return idPredial ; }
           set { idPredial = value  ; }
        }
        public string EstadoPredial 
        {
            get { return estadoPredial; }
            set { estadoPredial = value; }
        }
        public int ValorAluguer
        {
            get { return valorAluguer ; }
            set { valorAluguer = value ;}
        }
        public int ValorPredial
        {
            get { return valorPredial ; }
            set { valorPredial = value ; }
        }

        #endregion

        #region OUTROS METODOS

        

        #endregion
        #endregion



    }
}

        


