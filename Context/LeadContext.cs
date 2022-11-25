using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoContratacion.Models;

namespace AutoContratacion.Context
{
    public class LeadContext : DbContext
    {
        public LeadContext(DbContextOptions<LeadContext> options)
            : base(options)
        {
        }
        public DbSet<IntermediaLead>? tp_i_busquedas { get; set; }

        public DbSet<IntermediaCliente>? tp_clientes {get; set; }
        public DbSet<IntermediaMensaje>? t_reglas {get; set;}
    
        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }*/
    
         /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IntermediaLead>(entity =>
            {
                entity.HasKey(e => e.ide_i_bus)
                    .HasName("PK_ide_i_bus");

                entity.ToTable("Intermedia_Lead");

                entity.Property(e => e.ide_i_cli).HasColumnName("Ide_i_cli");

                entity.Property(e => e.ide_i_soc).HasColumnName("Ide_i_Soc");
                
                entity.Property(e => e.ide_i_pre_soc).HasColumnName("Ide_i_pre_Soc");

                entity.Property(e => e.i_ide_edi).HasColumnName("I_ide_Edi");

                entity.Property(e => e.i_ide_tip_int).HasColumnName("I_ide_Tip_Int");
                
                entity.Property(e => e.i_bus_tip).HasColumnName("I_bus_Tip");

                entity.Property(e => e.i_bus_dir_ref)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("I_bus_dir_Ref");

                entity.Property(e => e.i_bus_ubigeo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("i_bus_ubigeo");

                entity.Property(e => e.i_bus_res)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("I_bus_res");

                entity.Property(e => e.i_bus_lat)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("i_bus_lat");

                entity.Property(e => e.i_bus_lng)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("I_bus_Lng");

                entity.Property(e => e.i_bus_dir)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("I_bus_Dir");
                
                entity.Property(e => e.i_bus_obs)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("I_bus_Obs");

                entity.Property(e => e.i_num_departament)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("I_num_Departament");

                entity.Property(e => e.i_bus_seg_est).HasColumnName("I_bus_seg_Est");

                entity.Property(e => e.i_seg_prox_fecha).HasColumnName("I_seg_prox_Fecha");

                entity.Property(e => e.i_seller_id).HasColumnName("I_seller_Id");

                entity.Property(e => e.i_seller_type)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("I_seller_Type");

                entity.Property(e => e.cli_ubi_dep)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cli_ubi_Dep");

                entity.Property(e => e.cli_ubi_dis)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cli_ubi_Dis");

                entity.Property(e => e.cli_ubi_prov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cli_ubi_Prov");

                entity.Property(e => e.cond_torre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Cond_Torre");

                entity.Property(e => e.score_equifax)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Score_Equifax");

                entity.Property(e => e.bus_cod_postal)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Bus_cod_Postal");
                
                entity.Property(e => e.bus_cod_postal_text)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Bus_cod_postal_Text");

                entity.Property(e => e.num_piso)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Num_Piso");

                entity.Property(e => e.ide_pre_rel).HasColumnName("Ide_pre_Rel");

                entity.Property(e => e.ide_venta_origen).HasColumnName("Ide_venta_Origen");

                entity.Property(e => e.utm_source)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Utm_Source");

                entity.Property(e => e.utm_campaign)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Utm_Campaign");

                entity.Property(e => e.utm_medium)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Utm_Medium");

                entity.Property(e => e.paso_proceso).HasColumnName("Paso_Proceso");

                entity.Property(e => e.id_consulta_web).HasColumnName("Id_Consulta_Web");

                entity.Property(e => e.estado).HasColumnName("Estado");
            
                entity.Property(e => e.updated_at).HasColumnName("Update_At");

                entity.Property(e => e.created_by).HasColumnName("I_bus_Ubigeo");

                entity.Property(e => e.created_at).HasColumnName("Create_At");

                entity.Property(e => e.update_by).HasColumnName("Update_By");
            });
    }*/
    }
}