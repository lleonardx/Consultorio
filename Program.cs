using Consultorio.Models;

ConsultorioMedico consultorio = new ConsultorioMedico();

// * Criar Pacientes
Paciente paciente1 = new Paciente { Nome = "João", Idade = 30, Endereco = "Rua A, 123", Telefone = "123-456-7890" };
Paciente paciente2 = new Paciente { Nome = "Maria", Idade = 25, Endereco = "Rua B, 456", Telefone = "987-654-3210" };
Paciente paciente3 = new Paciente { Nome = "Lucas", Idade = 45, Endereco = "Rua C, 789", Telefone = "555-555-5555" };
Paciente paciente4 = new Paciente { Nome = "Marcos", Idade = 27, Endereco = "Rua D, 000", Telefone = "777-666-5353" };
Paciente paciente5 = new Paciente { Nome = "Rosa", Idade = 55, Endereco = "Rua E, 12", Telefone = "999-999-9999" };

//* Criar Medicos
Medico medico1 = new Medico { Nome = "Carlos", Especialidade = "Cardiologia" };
Medico medico2 = new Medico { Nome = "Ana", Especialidade = "Pediatria" };
Medico medico3 = new Medico { Nome = "Armando", Especialidade = "Oftalmologista" };

//* Adicionar pacientes e medicos ao consultorio
consultorio.AdicionarPaciente(paciente1);
consultorio.AdicionarPaciente(paciente2);
consultorio.AdicionarPaciente(paciente3);
consultorio.AdicionarPaciente(paciente4);
consultorio.AdicionarPaciente(paciente5);
consultorio.AdicionarMedico(medico1);
consultorio.AdicionarMedico(medico2);
consultorio.AdicionarMedico(medico3);

// * Marcar Conultas
Console.WriteLine("Consultas Marcadas.");
paciente1.MarcarConsulta(DateTime.Now.AddDays(2), medico1);
paciente2.MarcarConsulta(DateTime.Now.AddDays(3), medico2);
paciente3.MarcarConsulta(DateTime.Now.AddDays(5), medico3);
paciente4.MarcarConsulta(DateTime.Now.AddDays(3), medico2);
paciente5.MarcarConsulta(DateTime.Now.AddDays(5), medico3);
Console.WriteLine("\n-------------------------------------------------");

// * Realizar Consultas
Console.WriteLine("Consultas em Andamento.");
Consulta consulta1 = paciente1.Consultas[0];
paciente1.RealizarConsulta(medico1, consulta1);

Consulta consulta2 = paciente2.Consultas[0];
paciente2.RealizarConsulta(medico2, consulta2);

Consulta consulta3 = paciente3.Consultas[0];
paciente3.RealizarConsulta(medico3, consulta3);

Consulta consulta4 = paciente4.Consultas[0];
paciente4.RealizarConsulta(medico2, consulta4);

Consulta consulta5 = paciente5.Consultas[0];
paciente5.RealizarConsulta(medico3, consulta5);
Console.WriteLine("\n-------------------------------------------------");

// * Consultar a agenda 
Console.WriteLine("Agenda dos Medicos: ");
medico1.ConsultarAgenda(DateTime.Now.AddDays(2));
Console.WriteLine("-------------------------------------------------");
medico2.ConsultarAgenda(DateTime.Now.AddDays(3));
Console.WriteLine("-------------------------------------------------");
medico3.ConsultarAgenda(DateTime.Now.AddDays(5));
Console.WriteLine("-------------------------------------------------");

Console.ReadLine();