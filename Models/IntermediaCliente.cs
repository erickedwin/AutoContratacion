using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoContratacion.Models
{
    [Table("tp_clientes")]
    public class IntermediaCliente
    {
    [Key]
        public long ide_cli { get; set; }
        public long ide_tip_viv { get; set; }
        public long ide_tip_doc { get; set; }
        public string? cli_nom { get; set; }
        public string? cli_ape_pat { get; set; }
        public string? cli_ape_mat { get; set; }
        public string? cli_num_doc { get; set; }
        public string? cli_tel1 { get; set; }
        public string? cli_email { get; set; }
    }
    
    [NotMapped]
    public class Cliente {
        public int ide_tip_viv { get; set; }
        public int ide_tip_doc { get; set; }
        public string? cli_nom { get; set; }
        public string? cli_ape_pat { get; set; }
        public string? cli_ape_mat { get; set; }
        public string? cli_num_doc { get; set; }
        public string? cli_tel1 { get; set; }
        public string? cli_email { get; set; }
    }
    }
