using Blog.Common;
using Blog.Shared.Models.Posts.Dtos;

namespace Blog.Service.Posts;

public interface IPostService : IService
{
    Task<List<PostSelectDto>> GetPosts(CancellationToken cancellationToken);
}

public class PostService : IPostService
{
    public Task<List<PostSelectDto>> GetPosts(CancellationToken cancellationToken)
    {
        return Task.FromResult(new List<PostSelectDto>()
        {
            new()
            {
                Title = "پست شماره 1",
                Content = "محتوای پست",
            },
            new()
            {
                Title = "پست شماره 2",
                Content = "محتوای پست",
            },
            new()
            {
                Title = "پست شماره 3",
                Content = "محتوای پست",
            },
        });
    }
}