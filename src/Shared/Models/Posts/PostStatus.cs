namespace Blog.Shared.Models.Posts;

/// <summary>
/// وضعیت پست
/// </summary>
public enum PostStatus
{
    /// <summary>
    /// پیش‌نویس
    /// </summary>
    Draft = 0,

    /// <summary>
    /// منتشر شده
    /// </summary>
    Published = 1,

    /// <summary>
    /// منتشر نشده
    /// </summary>
    UnPublished = 2,
}