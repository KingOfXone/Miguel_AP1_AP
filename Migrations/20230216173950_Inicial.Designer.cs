
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Miguel_AP1_AP.DAL;

namespace Miguel_AP1_AP.Pages.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230216173950_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Aportes", b =>
                {
                    b.Property<int>("AportesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("Persona")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AportesId");

                    b.ToTable("aportes");
                });
#pragma warning restore 612, 618
        }
    }
}
