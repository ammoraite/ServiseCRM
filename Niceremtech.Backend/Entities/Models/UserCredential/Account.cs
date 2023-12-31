﻿namespace Entities.Models.Accounts
{
    public class Account
    {
        public Guid Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public AccountRights? AccountRights { get; set; }
        public DateTime? DateCreate { get; set; }
        public bool? IsBlock { get; set; }
        public decimal? Ballance { get; set; }
    }
}