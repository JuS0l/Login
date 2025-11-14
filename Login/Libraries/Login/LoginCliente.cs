using Login.Models;
using Newtonsoft.Json;
using Login.Libraries.Sessao;

namespace Login.Libraries.Login
{
    public class LoginCliente
    {
        private string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;

        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        public void Login(Cliente cliente)
        {
            string ClienteJSONString = JsonConvert.SerializeObject(cliente);
            _sessao.Cadastrar(Key, ClienteJSONString);
        }

        public Cliente getCliente()
        {
            if (_sessao.Existe(Key))
            {
                string clienteJSONString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Cliente>(clienteJSONString);
            }
            else
            {
                return null;
            }
        }
    }
}
