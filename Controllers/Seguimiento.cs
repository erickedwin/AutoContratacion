using Microsoft.AspNetCore.Mvc;
using AutoContratacion.Models;
using AutoContratacion.Context;
using Microsoft.EntityFrameworkCore;
using AutoContratacion.Context;

namespace AutoContratacion.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Seguimiento : ControllerBase
    {
        private readonly crmwinContext _crm;
        private readonly LeadContext _lead;
        public Seguimiento(crmwinContext sco, LeadContext lea){
            _crm=sco;
            _lead = lea;
            }

       [HttpGet("GetPedido")]
        public ActionResult<QueryMensaje> GetPedido(string dni)
        {
            var cli = _crm.qery_mensaje.FromSqlRaw("select a.PEDC_COD_TIPO_ESTADO , b.PRGC_COD_TIPO_ESTADO  from CRM.CRM_PEDIDO a join CRM.CRM_PROGRAMACION b on a.PEDI_COD_CLIENTE = b.PRGI_COD_CLIENTE where a.PEDC_COD_TIPO_CANAL = 1 and b.PRGC_COD_TIPO_MOTIVO_ESTADO = 32 and a.PEDV_NUM_DOCUMENTO ={0}", dni).FirstOrDefaultAsync();
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "02" && cli.Result.PRGC_COD_TIPO_ESTADO == ""){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56A").Result.regla});
            }
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "05" && cli.Result.PRGC_COD_TIPO_ESTADO == ""){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56A").Result.regla});
            }
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "03" && cli.Result.PRGC_COD_TIPO_ESTADO == ""){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56B").Result.regla});
            }
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "11" && cli.Result.PRGC_COD_TIPO_ESTADO == ""){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56A").Result.regla});
            }
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "02" && cli.Result.PRGC_COD_TIPO_ESTADO == "01"){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56A").Result.regla});
            }
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "02" && cli.Result.PRGC_COD_TIPO_ESTADO == "02"){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56C").Result.regla});
            }
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "06" && cli.Result.PRGC_COD_TIPO_ESTADO == "02"){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56B").Result.regla});
            }
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "02" && cli.Result.PRGC_COD_TIPO_ESTADO == "06"){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56B").Result.regla});
            }
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "02" && cli.Result.PRGC_COD_TIPO_ESTADO == "04"){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56C").Result.regla});
            }
            if(cli.Result.PEDC_COD_TIPO_ESTADO == "02" && cli.Result.PRGC_COD_TIPO_ESTADO == "03"){
                // cuando tiene el async es result sino de frente el paremetro
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56D").Result.regla});
            }
            else{
                return Ok(new{mensaje=_lead.t_reglas.FirstOrDefaultAsync(x=>x.codigo == "RF56E").Result.regla});
            }
            //return Ok(cli);
        } 

        /*[HttpGet("GetMensaje")]
        public IQueryable<Object> GetMensaje(string documento) {
            return from a in _crm.CRM_PEDIDO
            join p in _crm.CRM_PROGRAMACION on a.PEDI_COD_CLIENTE equals p.PRGI_COD_CLIENTE 
            //into artistProjects
            //where a.PEDV_NUM_DOCUMENTO = documento
            select new
            {
                Mensaje_Orden = a.PEDC_COD_TIPO_ESTADO,
               Mensaje_Pedido = p.PRGC_COD_TIPO_ESTADO
            };
        }*/
        
    }
}