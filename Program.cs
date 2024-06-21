using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Victor", sobrenome:"Vargas");
Pessoa p2 = new Pessoa(nome: "Julieta", sobrenome:"Ferreira");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 100);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 7);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("\nBem vindo a SuaEstadia.Com");
Console.WriteLine("Reserva efetuada com sucesso!");
Console.WriteLine($"\nQuantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"\nNome dos hospedes:\n{p1.NomeCompleto} e {p2.NomeCompleto}\n");
Console.WriteLine($"Permanencia de {reserva.DiasReservados} dias.");
Console.WriteLine($"Valor diária: R${reserva.CalcularValorDiaria()},00");