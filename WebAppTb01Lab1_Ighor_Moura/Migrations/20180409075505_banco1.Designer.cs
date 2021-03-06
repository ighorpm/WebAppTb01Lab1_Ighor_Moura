﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebAppTb01Lab1_Ighor_Moura.Models;

namespace WebAppTb01Lab1_Ighor_Moura.Migrations
{
    [DbContext(typeof(WebAppTb01Lab1_Ighor_Moura_automovelContext))]
    [Migration("20180409075505_banco1")]
    partial class banco1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppTb01Lab1_Ighor_Moura.Models.Automovel", b =>
                {
                    b.Property<int>("AutomovelId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<bool>("Disponivel")
                        .HasMaxLength(100);

                    b.Property<string>("Marca")
                        .IsRequired();

                    b.Property<int>("Tipo");

                    b.HasKey("AutomovelId");

                    b.ToTable("Automovel");
                });
#pragma warning restore 612, 618
        }
    }
}
