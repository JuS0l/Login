using Login.Models;
using Newtonsoft.Json;
using Login.Libraries.Sessao;

namespace Login.Libraries.Login
{
    public class LoginColaborador
    {
        private string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;

        public LoginColaborador(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        public void Login(Colaborador colaborador)
        {
            string ColaboradorJSONString = JsonConvert.SerializeObject(colaborador);
            _sessao.Cadastrar(Key, ColaboradorJSONString);
        }

        public Colaborador getColaborador()
        {
            if (_sessao.Existe(Key))
            {
                string colaboradorJSONString = _sessao.Consultar(Key);
                return JsonConvert.DeserializeObject<Colaborador>(colaboradorJSONString);
            }
            else
            {
                return null;
            }
        }
    }
}
