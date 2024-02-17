using Footsal.Entites.Teams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Footsal.Persistence.Teams;

public class TeamsEntityMap : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.HasKey(_ => _.Id);
        builder.Property(_ => _.Id).ValueGeneratedOnAdd().IsRequired();
        builder.Property(_ => _.Name).HasMaxLength(50).IsRequired();
        builder.Property(_ => _.MainColor).IsRequired();
        builder.Property(_ => _.MinorColor).IsRequired();
    }
}