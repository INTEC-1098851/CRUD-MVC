﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebCore.Models.Entities
{
    public partial class People
    {
        public People()
        {
            User = new HashSet<User>();
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? ClientTypeId { get; set; }
        public int? ContactTypeId { get; set; }
        public bool SupportStaff { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int? CompanyId { get; set; }
        public int? DepartmentId { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ClientType ClientType { get; set; }
        public virtual Company Company { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Deparment Department { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}