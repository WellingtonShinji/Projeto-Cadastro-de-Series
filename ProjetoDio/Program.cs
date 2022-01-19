using System;
using ProjetoDio.Classes;
using ProjetoDio.Enum;

namespace ProjetoDio
{
    class Program
    {
        static RepositorioSeries repositorio = new RepositorioSeries();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoDesejada();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":

                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        LimparTela();
                        break;
                    case "X":
                        Sair();
                        break;

                }
            }
        }
        private static void ListarSeries()
        {
            System.Console.WriteLine("Listar Series");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma Série Cadastrada");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.RetornaExcluido();
                System.Console.WriteLine("#ID {0}: - {1} ", serie.RetornaId(), serie.RetornaTitulo(), (excluido ? "Excluido" : " "));
            }
        }
        private static void AtualizarSerie()
        {
            System.Console.WriteLine("DIGITE O ID DA SÉRIE");
            int indiceSerie = int.Parse(System.Console.ReadLine());

            foreach (int numero in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("#ID {0}-{1} ", numero, Enum.GetName(typeof(Genero)), numero);
            }
            System.Console.WriteLine("DIGITE O GENERO DAS OPÇOES ACIMA");
            int entradaGenero = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("DIGITE O TITULO DA SÉRIE");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("DIGITE O ANO DA SÉRIE");
            int entradaAno = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("DIGITE A DESCRIÇÃO");
            string entradaDescricao = Console.ReadLine();

            Series AtualizarSerie = new Series(id: repositorio.ProximoId(),
                                         genero: (Genero)entradaGenero,
                                         titulo: entradaTitulo,
                                         ano: entradaAno,
                                         descricao: entradaDescricao);
            repositorio.Atualizar(indiceSerie, AtualizarSerie);

        }
        private static void ExcluirSerie()
        {
            System.Console.WriteLine("DIGITEO ID DA SÉRIE QUE GOSTARIA DE EXCLUIR");
            int idserie = int.Parse(Console.ReadLine());
            repositorio.Deletar(idserie);
        }
        private static void VisualizarSerie()
        {
            System.Console.WriteLine("DIGITE O ID DA SÉRIE");
            int idserie = int.Parse(Console.ReadLine());
            var series = repositorio.RetornarPorId(idserie);
            System.Console.WriteLine(series);

        }
        private static void LimparTela()
        {
            return;
        }
        private static void InserirSerie()
        {
            foreach (int numero in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("#ID {0}-{1} ", numero, Enum.GetName(typeof(Genero)), numero);
            }
            System.Console.WriteLine("DIGITE O GENÊRO ENTRE AS OPÇÕES ACIMA !! ");
            int entradaGenero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("DIGITE O TÍTULO DA SÉRIE !! ");
            string entradaTitulo = (Console.ReadLine());
            System.Console.WriteLine("DIGITE O ANO DA SÉRIE !! ");
            int entradaAno = int.Parse(Console.ReadLine());
            System.Console.WriteLine("DIGITE A DESCRIÇÃO DA SÉRIE !! ");
            string entradaDecricao = (Console.ReadLine());
            Series NovaSerie = new Series(id: repositorio.ProximoId(),
                                          genero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDecricao);
            repositorio.Criar(NovaSerie);
        }
        private static string ObterOpcaoDesejada()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Bem Vindo Ao EtoFlix ");
            System.Console.WriteLine("Informe a Opção Desejada");
            System.Console.WriteLine("1 - Listar Series");
            System.Console.WriteLine("2 - Inserir Nova Serie");
            System.Console.WriteLine("3 - Atualizar Series");
            System.Console.WriteLine("4 - Excluir Serie");
            System.Console.WriteLine("5 - Visualizar Serie");
            System.Console.WriteLine("C - Limpar Tela");
            System.Console.WriteLine("S - Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
        private static void Sair()
        {
            Environment.Exit(0);
        }
    }
}
