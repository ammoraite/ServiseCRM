﻿using Entities.Models.Accounts;
using Entities.Models.Users.Interfaces;

namespace Entities.Models.Users
{
    public class User: IUser
    {
        public Guid Id { get; set; }
        public Account? Account { get; set; }
        public PersonalData? PersonalData { get; set; }
    }
}
