using System.Collections.Generic;
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

        [HttpGet]
        [Route("api/v1/clientes")]
        public ActionResult<List<ClienteBasicView>> GetClientes([FromQuery] int page = 1, [FromQuery] int count = 5)
        {
            var clientes = _clienteService.GetClientes(page, count);
            return Ok(clientes);
        }
    }
}