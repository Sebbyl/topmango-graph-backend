using System.Collections.Generic;
using graph_backend.Models;

namespace graph_backend.Repositories
{
    public class ChartRepository<T>
    {
        private readonly List<Chart<T>> _charts = new List<Chart<T>>();

        public void AddChart(Chart<T> chart)
        {
            _charts.Add(chart);
        }

        public IEnumerable<Chart<T>> GetAllCharts() { return _charts; }

    }
}
