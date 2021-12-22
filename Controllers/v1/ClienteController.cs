using gtauto_api.InputModel;
using gtauto_api.Services;
using gtauto_api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace gtauto_api.Controllers
{
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        
        [HttpPost]
        [Route("api/v1/clientes/add")]
        public ActionResult<ClienteView> addCliente(ClienteInput clienteInput)
        {
            var cliente = _clienteService.AddCliente(clienteInput);
            return Ok(cliente);
        }
    }
}