using System;
using System.Collections.Generic;

namespace TodoList.Database;

public partial class List
{
    public int ListId { get; set; }

    public string? Title { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual ICollection<Todo> Todos { get; set; } = new List<Todo>();

    public virtual User? User { get; set; }
}
