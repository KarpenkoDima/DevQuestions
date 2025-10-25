namespace DevQuestions.Domain.Comments;

public class Comment
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Comment? Parent { get; set; }
    public List<Comment> Children { get; set; } = [];
    public Guid EntityId { get; set; } // к чему оставили комментарий 
    public string EntityType { get; set; } // под какой сущностью оставли комментарий
}
