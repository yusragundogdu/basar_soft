using BasarsoftStaj.Entities;

namespace BasarsoftStaj.Services
{
    public interface IPointService
    {
        IEnumerable<Point> GetAllPoints(); 
        Point GetPointById(int id); 
        void AddPoint(Point point); 
        void UpdatePoint(Point point); 
        void DeletePoint(int id); 
    }

}
