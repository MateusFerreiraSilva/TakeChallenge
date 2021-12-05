namespace Octokit.Services
{
    public interface IGithubAPIService
    {
        public List<Repository> GetRepos();
    }
}