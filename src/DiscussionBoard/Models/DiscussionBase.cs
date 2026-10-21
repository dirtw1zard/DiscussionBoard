namespace DiscussionBoard.Models
{
    public class DiscussionBase : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


    }
}
