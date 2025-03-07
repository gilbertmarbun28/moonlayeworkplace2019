﻿using Employees.Data.Abstractions;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.EmployeeRole
{
    internal class EmployeeRoleModelFactory
    {
        public EmployeeRoleModelFactory()
        {

        }

        internal EmployeeRoleIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var roleRepo = storage.GetRepository<IEmployeeRoleRepository>();

            return new EmployeeRoleIndexViewModel(roleRepo.All(page, size));
        }
    }
}
