using System.Runtime.InteropServices.Marshalling;
using System.Text;
using sistemahospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

 List<Pessoa> hospedes = new List<Pessoa>();

            Console.Write("Informe o número de hóspedes: ");
            int numeroHospedes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroHospedes; i++)
            {
                Console.Write($"Informe o nome do hóspede {i}: ");
                string nomeHospede = Console.ReadLine();
                hospedes.Add(new Pessoa(nomeHospede));
            }

            Console.Write("Informe a capacidade da suíte: ");
            int capacidadeSuite = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor da diária: ");
            decimal valorDiaria = decimal.Parse(Console.ReadLine());

            Suite suite = new Suite(tipoSuite: "Premium", capacidade: capacidadeSuite, valorDiaria: valorDiaria);

            Console.Write("Informe o número de dias de reserva: ");
            int diasReservados = int.Parse(Console.ReadLine());

            Reserva reserva = new Reserva(diasReservados);
            reserva.CadastrarSuite(suite);

            try
            {
                reserva.CadastrarHospedes(hospedes);

                Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
