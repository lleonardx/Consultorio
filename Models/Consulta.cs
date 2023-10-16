using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Consulta
    {
        public DateTime Data { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
    }
}