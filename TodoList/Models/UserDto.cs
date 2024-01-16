﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Shared
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifyOn { get; set; }

        public bool? IsDeleted { get; set; }
    }

    public class UserResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public UserDto User  { get; set; }
    }
}
