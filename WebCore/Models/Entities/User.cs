﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebCore.Models.Entities
{
    public partial class User
    {
        public User()
        {
            UserPermission = new HashSet<UserPermission>();
            UserRestriction = new HashSet<UserRestriction>();
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int LicenseTypeId { get; set; }
        public string PeopleId { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual People People { get; set; }
        public virtual ICollection<UserPermission> UserPermission { get; set; }
        public virtual ICollection<UserRestriction> UserRestriction { get; set; }
    }
}