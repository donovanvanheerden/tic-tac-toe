using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicTacToe.Core.Domain.Entities;

namespace TicTacToe.Infrastructure.Config
{
    public class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("games");

            builder.HasKey(n => n.Id);

            builder.Property(n => n.Id).HasColumnName("id");
            
            builder.Property(n => n.Player1Name).HasColumnName("player_1_name");
            builder.Property(n => n.Player2Name).HasColumnName("player_2_name");
            
            builder.Property(n => n.Cell1).HasColumnName("cell_1");
            builder.Property(n => n.Cell2).HasColumnName("cell_2");
            builder.Property(n => n.Cell3).HasColumnName("cell_3");
            builder.Property(n => n.Cell4).HasColumnName("cell_4");
            builder.Property(n => n.Cell5).HasColumnName("cell_5");
            builder.Property(n => n.Cell6).HasColumnName("cell_6");
            builder.Property(n => n.Cell7).HasColumnName("cell_7");
            builder.Property(n => n.Cell8).HasColumnName("cell_8");
            builder.Property(n => n.Cell9).HasColumnName("cell_9");
        }
    }
}
