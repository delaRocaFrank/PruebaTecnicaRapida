using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NOM.WS.DATOSEMPLEADO.BE.DataBaseUtils;
using System.Data;

namespace NOM.WS.DATOSEMPLEADO.BE.Controllers
{

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ColaboradorController : ControllerBase
    {
        
        private readonly ILogger<ColaboradorController> _logger;

        public ColaboradorController(ILogger<ColaboradorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Colaborador> Get()
        {
            DataBaseConnection con = new DataBaseConnection();
            DataSet myData = con.getColaborador();
            List<Colaborador> colabs = new List<Colaborador>();
            foreach(DataRow c in myData.Tables["Colaborador"].Rows)
            {
                Colaborador Colab = new Colaborador();
                Colab.ID =c["IDCOLABORADOR"].ToString();
                Colab.Nombre = c["NOMBRE"].ToString();
                Colab.Apellido = c["APELLIDO"].ToString();
                Colab.Direccion = c["DIRECCION"].ToString();
                Colab.Edad = c["EDAD"].ToString();
                Colab.Profesion = c["PROFESION"].ToString();
                Colab.EstadoCivil = c["ESTADO_CIVIL"].ToString();
                colabs.Add(Colab);
            }
                
            
            
            return colabs.ToArray();
        }
    }
}
