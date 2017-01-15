﻿using FreshMvvmDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmDemo.Services
{
    public interface IContactsService
    {
        Task<IEnumerable<Contact>> GetContacts();
    }
}
