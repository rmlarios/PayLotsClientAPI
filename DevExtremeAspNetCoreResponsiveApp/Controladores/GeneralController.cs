using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DevExtremeAspNetCoreResponsiveApp.Controladores
{
    public class GeneralController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly PayLotsDBContext _context;
        private readonly string _connectionString;

        public GeneralController(string connectiontring)
        {
            // _context = payLotsDBContext;
            _connectionString = connectiontring;//configuration.GetConnectionString("PayLotsConnection");
            
        }


        public async Task<DataTable> GetData(string str)
        {
            DataTable objresutl = new DataTable();
            try
            {
                SqlDataReader myReader;

                using (SqlConnection myCon = new SqlConnection(_connectionString))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(str, myCon))
                    {
                        myReader = await myCommand.ExecuteReaderAsync();
                        objresutl.Load(myReader);

                        myReader.Close();
                        myCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return objresutl;

        }

        public object ExecuteData(string str, params IDataParameter[] sqlParams)
        {
            Object result = null;
            try
            {

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(str, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        cmd.CommandText = str;
                        if (sqlParams != null)
                        {
                            foreach (IDataParameter para in sqlParams)
                            {
                                cmd.Parameters.Add(para);
                            }

                            result = cmd.ExecuteScalar();
                            cmd.Parameters.Clear();
                            cmd.Connection.Close();
                        }





                    }
                }
            }
            catch (Exception ex)
            {

            }

            return result;


        }



    }
}