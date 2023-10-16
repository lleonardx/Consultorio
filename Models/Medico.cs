using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Medico       
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public List<Consulta> Consultas { get; set; }

        public Medico()
        {
            Consultas = new List<Consulta>();
        }

        public void ConsultarAgenda(DateTime data)
        {
            Console.WriteLine($"Agenda do Dr(a). {Nome} ({Especialidade}) para {data.ToShortDateString()}:");

            foreach(var consulta in Consultas)
            {
                if(consulta.Data.Date == data.Date)
                {
                    Console.WriteLine($"- Paciente: {consulta.Paciente.Nome}, Data: {consulta.Data}");
                }
            }
        } 

        public void AtenderPaciente(Paciente paciente, Consulta consulta)
        {
            if(Consultas.Contains(consulta))
            {
                Console.WriteLine($"Dr(a). {Nome} está atendendo o paciente {paciente.Nome}.");
            }
            else
            {
                Console.WriteLine("Essa consulta não está agendada para este médico.");
            }
        }

        public void AdicionarConsulta(Consulta consulta)
        {
            Consultas.Add(consulta);
        }
        
    }
}
