using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace FiyiRequirements.Areas.FiyiRequirements.Entities.EntitiesConfiguration
{
    public class RequirementFileConfiguration : IEntityTypeConfiguration<RequirementFile>
    {
        public void Configure(EntityTypeBuilder<RequirementFile> entity)
        {
            try
            {
                //RequirementFileId
                entity.HasKey(e => e.RequirementFileId);
                entity.Property(e => e.RequirementFileId)
                    .ValueGeneratedOnAdd();

                //Active
                entity.Property(e => e.Active)
                    .HasColumnType("tinyint")
                    .IsRequired(true);

                //DateTimeCreation
                entity.Property(e => e.DateTimeCreation)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //DateTimeLastModification
                entity.Property(e => e.DateTimeLastModification)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //UserCreationId
                entity.Property(e => e.UserCreationId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //UserLastModificationId
                entity.Property(e => e.UserLastModificationId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //RequirementId
                entity.Property(e => e.RequirementId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //FilePath
                entity.Property(e => e.FilePath)
                    .HasColumnType("varchar(MAX)")
                    .IsRequired(true);

                
            }
            catch (Exception) { throw; }
        }
    }
}
