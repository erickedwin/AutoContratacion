using Microsoft.AspNetCore.Mvc;
using AutoContratacion.Models;
using AutoContratacion.Context;
using Microsoft.EntityFrameworkCore;
using AutoContratacion.Context;


namespace AutoContratacion.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class preventa : ControllerBase
    {
        private readonly LeadContext _lead;
        public preventa(LeadContext sco){
            _lead=sco;
            }

        [NonAction]
        public Task<IntermediaCliente> GetCliente(string documento)
        {
            var cli = _lead.tp_clientes.FromSqlRaw("SELECT * FROM tp_clientes WHERE cli_num_doc = {0}", documento);
            return cli.FirstOrDefaultAsync();
        }

        [NonAction]
        public void RegistrarLead(ModelLeadCompleto lead, IntermediaCliente cliente)
        {
            var busqueda = new IntermediaLead
            {
                ide_i_cli = Convert.ToInt32(cliente.ide_cli),
                ide_i_soc = lead.ide_i_soc,
                ide_i_pre_soc = lead.ide_i_pre_soc,
                i_ide_edi = lead.i_ide_edi,
                i_ide_tip_int = lead.i_ide_tip_int,
                i_bus_tip = lead.i_bus_tip,
                i_bus_dir_ref = lead.i_bus_dir_ref,
                i_bus_ubigeo = lead.geofinder.bus_ubigeo,
                i_bus_res = lead.geofinder.bus_res,
                i_bus_lat = lead.geofinder.bus_lat,
                i_bus_lng = lead.geofinder.bus_lng,
                i_bus_dir = lead.geofinder.bus_dir,
                i_bus_obs = lead.i_bus_obs,
                i_num_departament = lead.i_num_departament,
                i_bus_seg_est = lead.i_bus_seg_est,
                i_seg_prox_fecha = lead.i_seg_prox_fecha,
                i_seller_id = 15,
                i_seller_type = "Null",
                cli_ubi_dep = lead.cli_ubi_dep,
                cli_ubi_dis = lead.cli_ubi_dis,
                cli_ubi_prov = lead.cli_ubi_prov,
                cond_torre = lead.cond_torre,
                score_equifax = lead.score_equifax,
                bus_cod_postal = lead.bus_cod_postal,
                bus_cod_postal_text = lead.bus_cod_postal_text,
                num_piso = lead.num_piso,
                ide_venta_origen = 2,
                utm_source = lead.utm_source,
                utm_medium = lead.utm_medium,
                utm_campaign = lead.utm_campaign,
                paso_proceso = lead.paso_proceso,
                id_consulta_web = lead.id_consulta_web,
                estado = 1,
                updated_at = DateTime.Now,
                created_at = DateTime.Now
            };
            _lead.tp_i_busquedas.Add(busqueda);
            _lead.SaveChanges();
        }
        [NonAction]
        public void RegistrarCliente(IntermediaCliente cliente)
        {
            _lead.tp_clientes.Add(cliente);
            _lead.SaveChanges();
        }

        [HttpPost("Nuevo")]
        public ActionResult<IEnumerable<IntermediaCliente>> NuevoLead(ModelLeadCompleto model)
        {
            var cli = GetCliente(model.cliente.cli_num_doc);
            if (cli.Result == null)
            {
                IntermediaCliente cliente = new IntermediaCliente
                {
                    ide_tip_viv = model.cliente.ide_tip_viv,
                     ide_tip_doc = model.cliente.ide_tip_doc,
                    cli_nom = model.cliente.cli_nom,
                    cli_ape_pat = model.cliente.cli_ape_pat,
                    cli_ape_mat = model.cliente.cli_ape_mat,
                    cli_num_doc = model.cliente.cli_num_doc,
                    cli_tel1 = model.cliente.cli_tel1,
                    cli_email = model.cliente.cli_email
                };
                RegistrarCliente(cliente);
                var cli2 = GetCliente(cliente.cli_num_doc);
                RegistrarLead(model, cli2.Result);
                return Ok(new { message = "Cliente registrado y Lead registrado", Cliente = cli2.Result });
            }
            else
            {
                RegistrarLead(model, cli.Result);
                return Ok(new { message = "Lead registrado", Cliente = cli.Result });
            }

        }
            
        }
    }