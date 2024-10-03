using BasarsoftStaj.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasarsoftStaj.Services
{
    public class PointService : IPointService
    {
        private readonly  List<Point> _points;

        public void AddPoint(Point point)
        {
            _points.Add(point);
        }

        public void DeletePoint(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Point> GetAllPoints()
        {
            throw new NotImplementedException();
        }

        public Point GetPointById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePoint(Point point)
        {
            throw new NotImplementedException();
        }
    }
}



















