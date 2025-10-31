using Login.Models;

namespace Login.Repositorios.Contrato
{
    public class IColaboradorRepositorio
    {
        // Login Colaboraador
        Colaborador Login(string Email, string Senha);

        // Cadastrar Colaborador
        void Cadastrar(Colaborador colaborador);

        //Atualizar colaborador
        void Atualizar(Colaborador colaborador);

        //Atualizar senha Colaborador
        void AtualizarSenha(Colaborador colaborador);

        // Excluir Colabolardor
        void Excluir(int Id);

        // Obter colaborador por Id
        Colaborador ObterColaborador(int Id);

        // Obter colaborador por E-mail
        List<Colaborador> ObterColaboradorPorEmail(string email);

        // Obter todos colaborador
        IEnumerable<Colaborador> ObterTodosColaboradores();

        // Obter todos colaborador com paginação 
        //IPagedList<Colaborador> ObterTodosColaboradores(int? pagina);
    }
}
}
