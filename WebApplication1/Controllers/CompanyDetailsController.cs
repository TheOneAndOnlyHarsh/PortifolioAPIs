using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyDetailsController : ControllerBase
    {
        private readonly PortifolioRepository _repository;

        public CompanyDetailsController(PortifolioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetCompanyDetails()
        {
            var companies = _repository.GetAllCompanyDetails();
            return Ok(companies);
        }
    }
}
