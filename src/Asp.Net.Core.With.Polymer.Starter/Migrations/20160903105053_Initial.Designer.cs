using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Asp.Net.Core.With.Polymer.Starter.Data;

namespace Asp.Net.Core.With.Polymer.Starter.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20160903105053_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp.Net.Core.With.Polymer.Starter.Models.Todo", b =>
                {
                    b.Property<string>("Id");

                    b.Property<DateTime>("DateAdded");

                    b.Property<bool>("IsDone");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });
        }
    }
}
