using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Hotel_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System.Config
{
    /// <summary>
    /// Configuration on Common Proprieties/Attributes for <see cref="Employee"/> Entity 
    /// </summary>
    public class EmployeeConfig : 
        IEntityTypeConfiguration<Employee>
    {
        /// <summary>
        /// Configuration Statements
        /// </summary>
        /// <param name="builder"> <see cref="Employee"/> EntityBuilder </param>
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Apply Shared Constraints
            ExtendClass.ApplyConstraints(builder);

            // Constraint on Column
            builder.Property(e => e.Attend)
                .IsRequired();
        }
    }
}
