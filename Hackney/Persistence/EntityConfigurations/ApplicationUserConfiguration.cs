﻿using Hackney.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Hackney.Persistence.EntityConfigurations
{
    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {

        }
    }
}