using System;
using System.Collections.Generic;

namespace TodoList.Database;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifyOn { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<List> Lists { get; set; } = new List<List>();
}
