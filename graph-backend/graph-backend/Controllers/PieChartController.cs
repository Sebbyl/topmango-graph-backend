using Microsoft.AspNetCore.Mvc;
using graph_backend.Models;
using graph_backend.Repositories;

namespace graph_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PieChartController : ControllerBase
    {
        private readonly ChartRepository<PieChartCustomer> _chartRepository;

        public PieChartController(ChartRepository<PieChartCustomer> chartRepository)
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
        public ActionResult<Chart<PieChartCustomer>> AddChart([FromBody] Chart<PieChartCustomer> chart)
        {
            _chartRepository.AddChart(chart);
            return Ok(chart);
        }
    }
}
