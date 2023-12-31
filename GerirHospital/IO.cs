﻿/*
 * Classe Custo
 * Tiago Ferreira
 * a26005@alunos.ipca.pt
 * 14-11-2023
 * POO-LESI
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Objetos;

namespace GerirHospital
{
    /// <summary>
    /// Classe Input/Output
    /// </summary>
    public class IO
    {
        #region Médico
        /// <summary>
        /// Método que imprime as consultas que o medico especifico irá ter
        /// </summary>
        public static void MostrarConsultasMedico(List<Consulta> consultas, int idMedico)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.MedicoID == idMedico)
                {
                    Console.WriteLine($"Data: {consulta.GetData()}");
                    Console.WriteLine($"Descrição: {consulta.GetDescricao()}");
                    Console.WriteLine($"idMédico: {idMedico}");
                    Console.WriteLine("------------------------------");
                }
            }
        }

        /// <summary>
        /// Método que mostra as consultas que o medico tem agendadas
        /// </summary>
        public static void ConsultasAgendadasMedico(int idMedico, List<Consulta> consultas)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.MedicoID == idMedico && DateTime.Now <= consulta.data)
                {
                    Console.WriteLine("Data da consulta: " + consulta.GetData()); //consulta.data.ToString("dd/MM/yyyy HH:mm"));
                }
            }
        }

        /// <summary>
        /// Método que imprime informacoes do Medico de acordo com o ID
        /// </summary>
        public static void InfoMedico(int id, List<Medico> lista)
        {
            List<Medico> medicos = lista;
            Medico medicoEncontrado = medicos.FirstOrDefault(p => p.MedicoID == id);

            if (medicoEncontrado != null)
            {
                Console.WriteLine("Informações do Medico:");
                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Nome: {medicoEncontrado.Nome}");
                Console.WriteLine($"Data de Nascimento: {medicoEncontrado.DataNasc.ToShortDateString()}");
                Console.WriteLine($"Especialidade: {medicoEncontrado.Especialidade}");
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado.");
            }
        }
        #endregion

        #region Paciente
        /// <summary>
        /// Método que imprime as consultas que o paciente especifico irá ter
        /// </summary>
        public static void MostrarConsultasPaciente(List<Consulta> consultas, int nus)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.nus == nus)
                {
                    Console.WriteLine($"Data: {consulta.GetData()}");
                    Console.WriteLine($"Descrição: {consulta.GetDescricao()}");
                    Console.WriteLine($"Nus: {nus}");
                    Console.WriteLine("------------------------------");
                }
            }
        }

        /// <summary>
        /// Método que imprime as doencas que o paciente contém
        /// </summary>
        public static void DoencasPaciente(int nus, List<Paciente> lista)
        {
            List<Paciente> pacientes = lista;
            Paciente pacienteEncontrado = pacientes.FirstOrDefault(p => p.nus == nus);
            if(pacienteEncontrado == null)
            {
                Console.WriteLine("Paciente nao encontrado");
            }
            List<string> doencas = pacienteEncontrado.doencas;
            if (pacienteEncontrado.doencas.Count != 0)
            {
                foreach (var doenca in doencas)
                {
                    {
                        Console.WriteLine("Doença: " + doenca);
                    }
                }
            }
            else
            {
                Console.WriteLine("O paciente nao contem doencas");
            }
            
        }

        /// <summary>
        /// Método que imprime informacoes do paciente de acordo com o Nr de Utente de Saude
        /// </summary>
        public static void InfoPaciente(int nus, List<Paciente> lista)
        {
            List<Paciente> pacientes = lista;
            Paciente pacienteEncontrado = pacientes.FirstOrDefault(p => p.nus == nus);

            if (pacienteEncontrado != null)
            {
                Console.WriteLine("Informações do Paciente:");
                Console.WriteLine($"NUS: {nus}");
                Console.WriteLine($"Nome: {pacienteEncontrado.Nome}");
                Console.WriteLine($"Data de Nascimento: {pacienteEncontrado.DataNasc.ToShortDateString()}");
                Console.WriteLine($"Idade: {pacienteEncontrado.Idade}");
                Console.WriteLine($"Sexo: {pacienteEncontrado.Sexo}");
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado.");
            }
        }

        /// <summary>
        /// Método que mostra as consultas que o paciente tem agendadas
        /// </summary>
        public static void ConsultasAgendadasPaciente(int NUS, List<Consulta> consultas)
        {
            foreach (Consulta consulta in consultas)
            {
                if (consulta.nus == NUS && DateTime.Now <= consulta.data)
                {
                    Console.WriteLine("Data da consulta: " + consulta.GetData()); //consulta.data.ToString("dd/MM/yyyy HH:mm"));
                }
            }
        }

        #endregion

        #region Histórico
        /// <summary>
        /// Método que todas as cirurgias
        /// </summary>
        public static void HistoricoCirurgias(List<Cirurgia> cirurgias)
        {
            foreach (Cirurgia cirurgia in cirurgias)
            {
                Console.WriteLine($"Nome: {cirurgia.nome}");
                Console.WriteLine($"Data: {cirurgia.data.ToShortDateString()}");
                Console.WriteLine($"Nr utente de saude: {cirurgia.nus}");
                Console.WriteLine($"idMédico: {cirurgia.MedicoID}");
                Console.WriteLine("------------------------------");
            }
        }

        /// <summary>
        /// Método que imprime todos os internamentos
        /// </summary>
        public static void HistoricoInternamentos(List<Internamento> internamentos)
        {
            foreach (Internamento internamento in internamentos)
            {
                Console.WriteLine($"Nome: {internamento.motivo}");
                Console.WriteLine($"Data de Inicio: {internamento.datai.ToShortDateString()}");
                if (internamento.dataf > internamento.datai)
                {
                    TimeSpan diferenca = internamento.dataf - internamento.datai;
                    int nrDias = diferenca.Days;
                    Console.WriteLine($"Data final: {internamento.dataf.ToShortDateString()}");
                    Console.WriteLine($"Nr de dias: {nrDias}");
                }
                Console.WriteLine($"Nr utente de saude: {internamento.nus}");
                Console.WriteLine($"idMédico: {internamento.MedicoID}");
                Console.WriteLine("------------------------------");
            }
        }

        /// <summary>
        /// Método que imprime todos os diagnosticos
        /// </summary>
        public static void HistoricoDiagnosticos(List<Diagnostico> diagnosticos)
        {
            foreach (Diagnostico diagnostico in diagnosticos)
            {
                Console.WriteLine($"Descricao: {diagnostico.Descricao}");
                Console.WriteLine($"Data: {diagnostico.DataD.ToShortDateString()}");
                Console.WriteLine($"Nr utente de saude: {diagnostico.nus}");
                Console.WriteLine($"idMédico: {diagnostico.MedicoID}");
                Console.WriteLine("------------------------------");
            }
        }

        /// <summary>
        /// Método que imprime todos os exames
        /// </summary>
        public static void HistoricoExames(List<Exame> exames)
        {
            foreach (Exame exame in exames)
            {
                Console.WriteLine($"Nome: {exame.nome}");
                Console.WriteLine($"Data: {exame.data.ToShortDateString()}");
                Console.WriteLine($"Nr utente de saude: {exame.nus}");
                Console.WriteLine($"idMédico: {exame.MedicoID}");
                Console.WriteLine($"Resultado: {exame.resultado}");
                Console.WriteLine("------------------------------");
            }
        }
        #endregion

        #region Custo
        public static void ImprimeCusto(double custo, int NUS)
        {
            Console.WriteLine($"O custo do paciente com nrUtente : {NUS} foi {custo}");
        }
        #endregion
    }
}