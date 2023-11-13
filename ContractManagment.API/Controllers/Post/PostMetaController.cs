using AutoMapper;
using ContractManagment.API.Controllers.Generic;
using ContractManagment.API.ViewModel.PostViewModels;
using ContractManagment.BLL.Interfaces.Post;
using ContractManagment.BLL.Models.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContractManagment.API.Controllers.Post
{
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class PostMetaController : GenericReadController<PostMetaModel, PostMetaViewModel>
    {
        public PostMetaController(IPostMetaService postMetaService, IMapper mapper) : base(postMetaService, mapper)
        {

        }
    }
}
