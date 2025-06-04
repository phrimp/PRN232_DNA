using DNATesting.Repository.PhienNT;
using DNATesting.Services.PhienNT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNATest.APIServices.BE.PhienNT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DnaTestsPhienNTController : ControllerBase
    {
        private IDnaTestsPhienNtService _dnaTestsPhienNTService;

        public DnaTestsPhienNTController(IDnaTestsPhienNtService dnaTestsPhienNTService)
        {
            _dnaTestsPhienNTService = dnaTestsPhienNTService;
        }


        // GET: api/<DnaTestsPhienNTController>
        [HttpGet]
        public async Task<IEnumerable<DnaTestsPhienNt>> Get()
        {
            return await _dnaTestsPhienNTService.GetAllAsync();
        }

        // GET api/<DnaTestsPhienNTController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "2")]
        public async Task<DnaTestsPhienNt> Get(int id)
        {
            return await _dnaTestsPhienNTService.GetByIdAsync(id);
        }

        // POST api/<DnaTestsPhienNTController>
        [HttpPost]
        public async Task<int> Post(DnaTestsPhienNt dnaTestsPhienNT)
        {
            return await _dnaTestsPhienNTService.CreateAsync(dnaTestsPhienNT);
        }
      

        // PUT api/<DnaTestsPhienNTController>/5
        [HttpPut("{id}")]
        public async Task<int> Put(DnaTestsPhienNt dnaTestsPhienNt)
        {
            return await _dnaTestsPhienNTService.UpdateAsync(dnaTestsPhienNt);
        }

        // DELETE api/<DnaTestsPhienNTController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _dnaTestsPhienNTService?.DeleteAsync(id);
        }
    }
}
