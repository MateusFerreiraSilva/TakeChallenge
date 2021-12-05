namespace callApi.Models.DTO
{
    public class RepositoryDTO
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string AvatarUrl { get; protected set; }

        public RepositoryDTO(Octokit.Repository repo)
        {
            this.Name = repo.Name;
            this.Description = repo.Description;
            this.AvatarUrl = repo.Owner.AvatarUrl;
        }
    }
}