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
    public class PostController : GenericReadController<PostModel, PostViewModel>
    {
        public PostController(IPostService postService, IMapper mapper) : base(postService, mapper)
        {

        }
    }
}
