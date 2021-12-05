namespace Octokit.Services
{
    public class GithubAPIService : IGithubAPIService
    {

        private readonly GitHubClient _client = new GitHubClient(new ProductHeaderValue(Constants.CLIENT_NAME));
        private readonly ILogger<GithubAPIService> _logger;

        public GithubAPIService(ILogger<GithubAPIService> logger)
        {
            _logger = logger;
        }

        public List<Repository> GetRepos() {
            try
            {
                var repos = _client.Repository.GetAllForOrg(Constants.ORG).Result;
                _logger.LogInformation($"{repos.Count} repositories from {Constants.ORG} were successfully retrieved");

                var csRepos = repos.Where(repo =>
                    !string.IsNullOrEmpty(repo.Language) && repo.Language.Equals(Constants.LANG)
                ).ToList();

                csRepos = repos.OrderBy(repo => repo.CreatedAt)
                    .Take(Constants.REPOSITORIES_LIMIT).ToList();

                return csRepos;
            }
            catch (System.Exception err)
            {
                _logger.LogError("Failed to get {0} repositories", Constants.ORG);
                throw new Exception($"Failed accessing Github API -> {err}");
            }
        }

    }
}