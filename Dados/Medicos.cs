﻿/*
 * Classe Medicos
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 20-11-2023
 * POO-LESI
 */

using System.Collections.Generic;
using Objetos;


namespace Dados
{
    public static class Medicos
    {
        /// <summary>
        /// Classe Medicos
        /// </summary>
        #region ATRIBUTOS

        private static List<Medico> medicos = new List<Medico>();
        #endregion

        #region COMPORTAMENTO
        #region PROPRIEDADES

        /// <summary>

        /// <summary>
        /// Propriedade que retorna a lista da classe Medico , Medicos
        /// </summary>
        public static List<Medico> ListadeMedicos
        {
            get
            {
                return medicos;
            }
            set
            {
                medicos = value;
            }
        }
        #endregion

        #region OutrosMétodos

        /// <summary>
        /// Método para adcionar um medico da lista de medicos
        /// </summary>

        public static void AdicionarMedico(Medico medico)
        {
            medicos.Add(medico);
        }



        /// <summary>
        /// Método para remover um medico da lista de medicos
        /// </summary>

        public static void RemoverMedico(Medico medico)
        {
            medicos.Remove(medico);
        }

        #endregion
        #endregion
    }
}