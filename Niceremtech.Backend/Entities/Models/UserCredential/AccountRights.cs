﻿namespace Entities.Models.Accounts
{
    public class AccountRights
    {
        public Guid Id { get; set; }
        public bool? ICanDeleteOrder { get; set; }
        public bool? ICanCreateOrder { get; set; }
        public bool? ICanModifyOrder { get; set; }
        public bool? ICanDeleteUser { get; set; }
        public bool? ICanCreateUser { get; set; }
        public bool? ICanModifyUser { get; set; }
        public bool? ICanDeleteAccount { get; set; }
        public bool? ICanCreateAccount { get; set; }
        public bool? ICanModifyAccount { get; set; }
    }
}
