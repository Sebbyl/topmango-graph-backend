using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using graph_backend.Models;
using graph_backend.Repositories;


namespace graph_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaChartController : ControllerBase
    {
        private readonly ChartRepository<AreaChartCustomer> _chartRepository;

        public AreaChartController(ChartRepository<AreaChartCustomer> chartRepository)
        {
            _chartRepository = chartRepository;
        }

        [HttpGet]
        public ActionResult getCharts()
        {
            var charts = _chartRepository.GetAllCharts();
            return Ok(new { charts });
        }

        [HttpPost]
        public ActionResult<Chart<AreaChartCustomer>> AddChart([FromBody] Chart<AreaChartCustomer> chart)
        {
            _chartRepository.AddChart(chart);
            return Ok(chart);
        }
    }
}

