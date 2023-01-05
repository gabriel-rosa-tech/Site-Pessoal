using Microsoft.AspNetCore.Mvc;
using site_pessoal.Models;

namespace site_pessoal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CriaturaController : ControllerBase
    {

        List<CriaturaModel> listaCriaturas = new List<CriaturaModel>();

        [HttpGet("{id:int}")]
        public CriaturaModel[] Get(int id)
        {
            return listaCriaturas.Where(c => c.Id == id).ToArray();
        }

        [HttpPost]
        public bool PostCriatura(CriaturaModel criatura)
        {
            if (criatura != null)
            {
                listaCriaturas.Add(criatura);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
