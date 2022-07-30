using Blog.Common;
using Blog.Shared.Models.Posts.Dtos;

namespace Blog.Service.Posts;

public interface IPostService : IService
{
    Task<List<PostSelectDto>> GetPosts(int count, CancellationToken cancellationToken);
}

public class PostService : IPostService
{
    public async Task<List<PostSelectDto>> GetPosts(int count,CancellationToken cancellationToken)
    {
        var result = new List<PostSelectDto>();

        for (int i = 0; i < count; i++)
        {
            result.Add(new()
            {
                Title = "پست شماره " + i,
                Content = "اگر شما یک طراح هستین و یا با طراحی های گرافیکی سروکار دارید به متن های برخورده اید که با نام لورم ایپسوم شناخته می‌شوند. لورم ایپسوم یا طرح‌نما (به انگلیسی: Lorem ipsum) متنی ساختگی و بدون معنی است که برای امتحان فونت و یا پر کردن فضا در یک طراحی گرافیکی و یا صنعت چاپ استفاده میشود. طراحان وب و گرافیک از این متن برای پرکردن صفحه و ارائه شکل کلی طرح استفاده می‌کنند.",
            });
        }

        return result;
    }
}