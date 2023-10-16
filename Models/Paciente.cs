using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Paciente
    {
         public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public List<Consulta> Consultas { get; set; }

        public Paciente()
        {
            Consultas = new List<Consulta>();
        }

        public void ConsultarMedico (Medico medico)
        {
            Console.WriteLine($"{Nome} esta consultando o Dr(a). {medico.Nome} ({medico.Especialidade})");
        }
        public void MarcarConsulta (DateTime data, Medico medico)
        {
            Consulta consulta = new Consulta { Data = data, Medico = medico, Paciente = this};
            Consultas.Add(consulta);
            medico.AdicionarConsulta(consulta);
            Console.WriteLine($"{Nome} marcou uma consulta com o Dr(a). {medico.Nome}, para {data.ToShortDateString()}.");

        }
        public void RealizarConsulta (Medico medico, Consulta consulta)
        {
            if (Consultas.Contains(consulta))
            {
                Console.WriteLine($"{Nome} está realizando uma consulta com o Dr(a). {medico.Nome}.");
            }
            else
            {
                Console.WriteLine("Essa consulta não está agendada para este paciente.");
            }
        }
    }
}