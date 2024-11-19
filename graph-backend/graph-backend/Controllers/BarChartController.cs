using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using graph_backend.Models;
using graph_backend.Repositories;

namespace graph_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarChartController : ControllerBase
    {
        private readonly ChartRepository<BarChartCustomer> _chartRepository;

        public BarChartController(ChartRepository<BarChartCustomer> chartRepository)
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
        public ActionResult<Chart<BarChartCustomer>> AddChart([FromBody] Chart<BarChartCustomer> chart)
        {
            _chartRepository.AddChart(chart);
            return Ok(chart);
        }
    }
}
