using QFIApp.Models;

namespace QFIApp.Logic
{
    public interface IRenderRectangleRepository
    {
        List<RectangleModel> GenerateRectanglesHorizontally(int numberOfRectangles);
        List<RectangleModel> GenerateRectanglesVertically(List<RectangleModel> rectangleModels);
    }
}
