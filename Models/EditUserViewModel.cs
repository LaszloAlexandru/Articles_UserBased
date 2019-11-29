﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Articles_UserBased.Models
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string RoleId { get; set; }

        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}