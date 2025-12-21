using DALCLASS;
using DALCLASS.InterfaceModal;
using DALCLASS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace TrackingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class _CountryController : ControllerBase
    {
        private readonly CountryServices _countryService;

        public _CountryController(CountryServices countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public IActionResult GetCountry()
        {
            return Ok(_countryService.GetCountries());
        }

        [HttpPost]
        public IActionResult AddCountry(CountryMaster _country) {

            _countryService._AddCountry(_country);
            return Ok("Country Added");
        }

        [HttpPut]
        public IActionResult UpdateCountry(CountryMaster _country)
        {
            _countryService._UpdateCountry(_country);
            return Ok("Country Updated");
        }
        [HttpDelete("Id")]
        public IActionResult DeleteCountry(int id) {
            _countryService._DeleteCountry(id);
            return Ok("Country Deleted");
        }
    }
}
