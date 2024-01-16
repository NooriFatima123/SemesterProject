using System;
using System.Collections.Generic;

namespace TodoList.Database;

public partial class Todo
{
    public int ItemId { get; set; }

    public string? Title { get; set; }

    public string? Desc { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifyOn { get; set; }

    public int? ListId { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsCompleted { get; set; }

    public virtual List? List { get; set; }
}
