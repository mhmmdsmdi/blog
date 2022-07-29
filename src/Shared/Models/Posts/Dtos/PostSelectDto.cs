using Blog.Common.Dto;

namespace Blog.Shared.Models.Posts.Dtos;

public class PostSelectDto : BaseDto<PostSelectDto, Post>
{
    /// <summary>
    /// عنوان
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// محتوا
    /// </summary>
    public string Content { get; set; }
}