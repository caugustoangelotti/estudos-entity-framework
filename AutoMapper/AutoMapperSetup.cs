using System.Collections.Generic;
using AutoMapper;
using gtauto_api.Entities;
using gtauto_api.InputModel;
using gtauto_api.ViewModel;

namespace gtauto_api.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region EntitieToView
                CreateMap<Cliente, ClienteBasicView>();
                CreateMap<Cliente, ClienteView>();
                CreateMap<Endereco, EnderecoView>();
                CreateMap<Telefone, TelefoneView>();
                CreateMap<Veiculo, VeiculoView>();
                CreateMap<Cliente, ClienteBasicView>();
            #endregion

            #region InputToEntitie
                CreateMap<ClienteInput, Cliente>();
                CreateMap<ClienteInput, Endereco>();
                CreateMap<ClienteInput, Telefone>();
            #endregion
            
        }
    }
}