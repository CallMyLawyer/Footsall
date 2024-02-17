using Footsal.Entites.Playesr;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Footsal.Persistence.Players;

public class PlayerEntityMap : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.HasKey(_ => _.Id);
        builder.Property(_ => _.Id).ValueGeneratedOnAdd();
        builder.Property(_ => _.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(_ => _.LastName).HasMaxLength(50).IsRequired();
        builder.Property(_ => _.BirthDate).IsRequired();
    }
}