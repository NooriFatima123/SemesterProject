namespace TodoList.Models
{
    public class TodoDto
    {
        public int ItemId { get; set; }

        public string? Title { get; set; }

        public string? Desc { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifyOn { get; set; }

        public int? ListId { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsCompleted { get; set; }
    }
}
