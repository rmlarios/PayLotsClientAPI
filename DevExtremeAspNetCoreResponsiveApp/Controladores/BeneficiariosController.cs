using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Data;
using DevExtremeAspNetCoreResponsiveApp.Controladores;
using Microsoft.AspNetCore.Authorization;

namespace DevExtremeAspNetCoreResponsiveApp.Controladores
{
    
    [ApiController]
    [Route("api/[controller]")]

    //[Route("api/[controller]/[action]")]

    public class BeneficiariosController : Controller
    {

        private readonly PayLotsDBContext _context;
        private readonly string _connectionString;



        [TempData]
        public string Mensaje { get; set; }
        public GeneralController FG { get; private set; }

        public BeneficiariosController(PayLotsDBContext payLotsDBContext, IConfiguration configuration)
        {
            _context = payLotsDBContext;
            _connectionString = configuration.GetConnectionString("PayLotsConnection");
            FG = new GeneralController(_connectionString);

        }



        [HttpGet("listar")]

        public async Task<object> GetAll(DataSourceLoadOptions loadOptions)
        {
            object result = await Task.Run(()=>DataSourceLoader.Load(_context.Beneficiarios, loadOptions));
            return result;
            //var result = await _context.Beneficiarios.ToListAsync();
            //var resultJson = JsonConvert.SerializeObject(result);
            //return Content(resultJson, "application/json");
            //return Json(DataSourceLoader.Load(result, loadOptions));

            //return await _context.Beneficiarios.ToListAsync();
            //return await _context.Beneficiarios.FromSql("SELECT * FROM Beneficiarios WHERE ISNULL(Telefono,'')!=''").ToListAsync();
        }

        [HttpGet]
        public async Task<IActionResult> GetAsignaciones(int id, DataSourceLoadOptions loadOptions)
        {
            //var benef = await _context.Asignaciones.Where(s => s.IdBeneficiario == id).ToListAsync();
            /*var benef = _context.Asignaciones.Where(s => s.IdBeneficiario == id)
                         .Select(s => new
                         {
                             Lote = s.IdLoteNavigation.NumeroLote,
                             Proyecto = s.IdLoteNavigation.IdBloqueNavigation.IdUbicacionNavigation.NombreProyecto,

                         })
                         .ToListAsync();*/

            var resultJson = JsonConvert.SerializeObject(await FG.GetData("SELECT * FROM View_Asignaciones_Lotes WHERE IdBeneficiario=" + id));
            return Content(resultJson, "application/json");


        }


        [HttpPost]
        public ActionResult AgregarBeneficiario([FromForm]string values)
        {
            var beneficiario = new Beneficiarios();
            JsonConvert.PopulateObject(values, beneficiario);


            var parameters = new IDataParameter[]
            {
             new SqlParameter("@IdBeneficiario", beneficiario.IdBeneficiario),
             new SqlParameter("@NombreCompleto", beneficiario.NombreCompleto),
             new SqlParameter("@CedulaIdentidad", beneficiario.CedulaIdentidad),
             new SqlParameter("@Direccion", beneficiario.Direccion),
             new SqlParameter("@Telefono", beneficiario.Telefono),
             new SqlParameter("@IdentityUser", "ADOInsert"),
             new SqlParameter("@UUA", "CoreUser"),
            };


            if (FG.ExecuteData("SP_BeneficiarioCrearActualizar", parameters) != null)
            {

                return Ok(new { Result = "Guardado Correctamente." });
            }
            else
            {
                //return NotFound(new { Result = "something went wrong" });
                var ErrorSQL = _context.ErrorSql.FromSql($"SELECT * FROM ErrorSQL WHERE IdentityUser= 'ADOInsert'").ToList();
                if (ErrorSQL.Count() > 0)
                {
                    Mensaje = ErrorSQL[0].ErrorSql1.ToString();
                    return NotFound(new { Result = Mensaje });
                }
                else
                {
                    return NotFound(new { Result = "something went wrong" });
                }

            }
                       
        }

        [HttpPut]
        public ActionResult ActualizarBeneficiario([FromForm]int key, [FromForm]string values)
        {
            var beneficiario = _context.Beneficiarios.First(b => b.IdBeneficiario == key);
            JsonConvert.PopulateObject(values, beneficiario);

            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand("SP_BeneficiarioCrearActualizar", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@IdBeneficiario", SqlDbType.Int).Value = key;
            command.Parameters.Add("@NombreCompleto", SqlDbType.NVarChar).Value = beneficiario.NombreCompleto;
            command.Parameters.Add("@CedulaIdentidad", SqlDbType.NVarChar).Value = beneficiario.CedulaIdentidad;
            command.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = beneficiario.Direccion;
            command.Parameters.Add("@Telefono", SqlDbType.NVarChar).Value = beneficiario.Telefono;
            command.Parameters.Add("@IdentityUSer", SqlDbType.NVarChar).Value = "IdentityUpdate1";
            command.Parameters.Add("@UUA", SqlDbType.NVarChar).Value = "CoreUser";

            connection.Open();
            var result = command.ExecuteScalar();
            command.Parameters.Clear();
            command.Connection.Close();

            var ErrorSQL = _context.ErrorSql.FromSql($"SELECT * FROM ErrorSQL WHERE IdentityUser= 'IdentityUpdate1'").ToList();
            if (ErrorSQL.Count() > 0)
            {
                Mensaje = ErrorSQL[0].ErrorSql1.ToString();
                return BadRequest(Mensaje);
            }



            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete([FromForm]int key)
        {
            try
            {
                //var key = Convert.ToInt32(form.Get("key"));
                var beneficiario = _context.Beneficiarios.Find(key);
                if (beneficiario != null)
                {
                    //return NotFound();
                    // var result = await _context.BeneficiariosEliminar(key);
                    SqlParameter IdBeneficiario = new SqlParameter("@IdBeneficiario", key);
                    SqlParameter IdentityUser = new SqlParameter("@IdentityUser", "NetCoreError989");
                    SqlParameter UUA = new SqlParameter("@UUA",User.Identity.Name);

                    int result = _context.Database.ExecuteSqlCommand("SP_BeneficiarioEliminar @IdBeneficiario,@IdentityUser,@UUA", IdBeneficiario, IdentityUser,UUA);

                    var ErrorSQL = _context.ErrorSql.FromSql($"SELECT * FROM ErrorSQL WHERE IdentityUser= 'NetCoreError989'").ToList();
                    if (ErrorSQL.Count() > 0)
                    {
                        Mensaje = ErrorSQL[0].ErrorSql1.ToString();
                        return BadRequest(Mensaje);
                    }

                }
            }
            catch (Exception Ex)
            {
                BadRequest(Ex.Message);
            }


            return Ok("Registro eliminado correctamente");
        }

    }
}