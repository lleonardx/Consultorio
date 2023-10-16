using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class ConsultorioMedico
    {
        public List<Paciente> Pacientes = new List<Paciente>();
        public List<Medico> Medicos = new List<Medico>();

        public ConsultorioMedico()
        {
            Pacientes = new List<Paciente>();
            Medicos = new List<Medico>();
        }

        public void AdicionarPaciente(Paciente paciente)
        {
            Pacientes.Add(paciente);
        }
        public void RemoverPaciente(Paciente paciente)
        {
            Pacientes.Remove(paciente);
        }
        public List<Paciente> ListarPacientes()
        {
            return Pacientes;
        }

        
        public void AdicionarMedico(Medico medico)
        {
            Medicos.Add(medico);
        }
        public void RemoverMedico(Medico medico)
        {
            Medicos.Remove(medico);
        }
        public List<Medico> ListarMedicos()
        {
            return Medicos;
        } 
    }
}