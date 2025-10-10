using Login.Models;

namespace Login.Repositorios.Contrato
{
    public interface IClienteRepositorio
    {

        Cliente Login(string Email, string Senha);

        void Cadastrar (Cliente cliente);
        void Atualizar (Cliente cliente);

        void Ativar (int id);
        void Desativar (int id);
        void Excluir (int id);

        Cliente ObterCliente(int id);

        Cliente BuscaCpfCliente (string CPF);

        Cliente BuscaEmailCliente(string email);
        IEnumerable<Cliente> ObterTodosClientes();
    }
}
