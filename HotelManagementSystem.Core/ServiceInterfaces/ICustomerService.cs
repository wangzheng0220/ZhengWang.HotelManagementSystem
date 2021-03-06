﻿using HotelManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Core.ServiceInterfaces
{
    public interface ICustomerService 
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> AddCustomer(Customer customer);
    }
}
