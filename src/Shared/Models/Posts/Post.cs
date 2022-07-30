using Blog.Common.Entities;
using Blog.Shared.Models.Users;

namespace Blog.Shared.Models.Posts;

public class Post : Entity
{
    /// <summary>
    /// عنوان
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// محتوا
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// آدرس تصویر کاور
    /// </summary>
    public string Cover { get; set; }

    /// <summary>
    /// شناسه کاربر نویسنده
    /// </summary>
    public long AuthorId { get; set; }

    /// <summary>
    /// تعداد مشاهده
    /// </summary>
    public int ViewsCount { get; set; }

    /// <summary>
    /// وضعیت پست
    /// </summary>
    public PostStatus Status { get; set; }

    /// <summary>
    /// زمان انتشار
    /// </summary>
    public DateTime PublishedAt { get; set; }

    /// <summary>
    /// زمان ایجاد
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// زمان ویرایش
    /// </summary>
    public DateTime ModifiedAt { get; set; }

    /// <summary>
    /// کاربر نویسنده
    /// </summary>
    public User Author { get; set; }
}