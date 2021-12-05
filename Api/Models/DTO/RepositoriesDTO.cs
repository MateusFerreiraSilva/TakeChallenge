namespace callApi.Models.DTO
{
    public class RepositoriesDTO
    {
        public Dictionary<int, RepositoryDTO> repositories { get; set; }

        public RepositoriesDTO(List<Octokit.Repository> repos)
        {
            repositories = repos.Select((repo, idx) => new { idx, repo })
                    .ToDictionary(pair => pair.idx, pair => new RepositoryDTO(pair.repo));
        }

    }
}