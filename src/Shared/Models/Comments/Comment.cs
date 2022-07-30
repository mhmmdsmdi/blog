using Blog.Common.Entities;
using Blog.Shared.Models.Posts;
using Blog.Shared.Models.Users;

namespace Blog.Shared.Models.Comments;

public class Comment : Entity
{
    /// <summary>
    /// شناسه پست
    /// </summary>
    public long PostId { get; set; }

    /// <summary>
    /// شناسه کاربر نویسنده
    /// </summary>
    public long? AuthorId { get; set; }

    /// <summary>
    /// نام نویسنده
    /// </summary>
    public string AuthorName { get; set; }

    /// <summary>
    /// محتوا
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// وضعیت پذیرفته شدن
    /// </summary>
    public bool IsAccepted { get; set; }

    /// <summary>
    /// زمان ایجاد
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// پست
    /// </summary>
    public Post Post { get; set; }

    /// <summary>
    /// کاربر نویسنده
    /// </summary>
    public User Author { get; set; }
}