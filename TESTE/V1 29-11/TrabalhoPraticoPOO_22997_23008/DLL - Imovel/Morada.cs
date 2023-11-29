/*
 *  Class Morada
 *	Autor: Fábio Rafael Gomes Costa || Luis Pedro Pereira Freitas
 *	Contato: a22997@alunos.ipca.pt ||a23008@alunos.ipca.pt
 *	Data: 01/11/2023
*/
using Interfaces;
using System;
using System.Collections.Generic;

namespace DLLImovel
{
    public class Morada : IMoradas
    {
        #region Estado
        private int idMorada;
        private string rua; 
        private int nPorta;
        private int codPostal;
        private string localidade;
        private List<Morada> morada;

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        public Morada()
        {

        }
        
        #endregion
        #region PROPRIEDADES
        public int IdMorada
        {
            get { return idMorada; }
            set { idMorada = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public int NPorta
        {
            get { return nPorta; }
            set { nPorta = value; }
        }

        public int CodPostal
        {
            get { return codPostal; }
            set { codPostal = value; }
        }

        public string Localidade
        {
            get { return localidade; }
            set { localidade = value; }
        }
        #endregion

        #region Outros Metodos
        public bool AdicionarMorada(Morada m)
        {
            if (!morada.Contains(m))
            {
                morada.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExisteMorada(int idMorada)
        {
            foreach (Morada m in morada)
            {
                if (m.IdMorada == idMorada)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #endregion

    }
}
