using Interfaces;

namespace Interfaces
{
    public interface IImovel
    {
        /// <summary>
        /// Cria um imovel
        /// </summary>
        /// <returns></returns>
        bool AdicionarImovel();
        /// <summary>
        /// Verifica a existencia de um Imovel
        /// </summary>
        /// <returns></returns>
        bool ExisteImovel ();
        /// <summary>
        /// Criar uma morada
        /// </summary>
        /// <param name="m">Parametro atribuido</param>
        /// <returns></returns>
        bool AdicionarMorada();
        /// <summary>
        /// Verifica a existencia de uma morada
        /// </summary>
        /// <param name="idMorada">Número identificativo de uma morada</param>
        /// <returns></returns>
        bool ExisteMorada();
        

    }
}
