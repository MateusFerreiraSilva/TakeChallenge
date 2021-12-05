using Microsoft.AspNetCore.Mvc;
using Octokit.Services;
using callApi.Models.DTO;

namespace callApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class TakeBlipRepositoriesController : ControllerBase
    {
        private readonly IGithubAPIService _service;

        public TakeBlipRepositoriesController(IGithubAPIService service) {
            _service = service;
        }

        /// <summary>
        ///  Get 5 oldest C# repositories from Takeblip 
        /// </summary>
        /// <returns>A dictionary with the repositories data</returns>
        /// <response code="200">Returns dictionary with the repositories data</response>
        [HttpGet]
        [ProducesResponseType(typeof(RepositoryDTO), (StatusCodes.Status200OK))]
        public RepositoriesDTO GetFiveOldestRepositories()
        {
            var repos = _service.GetRepos();
            var reposDTO = new RepositoriesDTO(repos);
            return reposDTO;
        }
    }
}
