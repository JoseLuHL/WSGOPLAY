using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using WSGOPLAY.Models;

namespace WSGOPLAY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> ActionResultAsync()
        {
            var sql = "SELECT * FROM reserva";
            MySqlConnection mySql = new MySqlConnection("server=gplaywsdb.cojkxe5aue65.us-east-1.rds.amazonaws.com;database=goplayco_red;uid=jose;password=3123042887Luis");
            MySqlDataAdapter mySqlData = new MySqlDataAdapter(sql, mySql);
            DataTable table = new DataTable();
            List<Reserva> reservas = new List<Reserva>();
            mySqlData.Fill(table);
            foreach (DataRow item in table.Rows)
            {
                reservas.Add(new Reserva { HoraInicio = item[2].ToString() });
            }
            return Ok(reservas);
        }
    }
}