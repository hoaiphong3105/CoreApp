using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoreApp.Data.EF.Extensions;
using CoreApp.Data.Entities;

namespace CoreApp.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
