using Login.Libraries.Login;
using Login.Models;
using Login.Models.Constantes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Login.Libraries.Filtro
{
    public class ColaboradorAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        private string _tipoColaboradorAutorizado;

        public ColaboradorAutorizacaoAttribute(string TipoColaboradorAutorizado = ColaboradorTipoConstante.Comum)
        {
            _tipoColaboradorAutorizado = TipoColaboradorAutorizado;
        }

        LoginColaborador _loginColaborador;

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginColaborador = (LoginColaborador)context.HttpContext.RequestServices.GetService(typeof(LoginColaborador));
            AppLoginAspCoreA.Models.Colaborador colaborador = _loginColaborador.getColaborador();
            if (colaborador == null)
            {
                context.Result = new RedirectToActionResult("Login", "Nome", null);
            }
            else
            {
                if (colaborador.Type == ColaboradorTipoConstante.Comum && _tipoColaboradorAutorizado == ColaboradorTipoConstante.Gerente)
                {
                    context.Result = new ForbidResult();
                }
            }
        }
    }
}
