using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoContratacion.Models;

namespace AutoContratacion.Context
{
    public class crmwinContext : DbContext
    {
        public crmwinContext(DbContextOptions<crmwinContext> options)
            : base(options)
        {
        }

        public DbSet<ReplicaPedidos>? CRM_PEDIDO {get; set; }
        public DbSet<ReplicaOrdenes>? CRM_PROGRAMACION {get; set; }
        public DbSet<QueryMensaje>? qery_mensaje {get; set; }
        
    }
}