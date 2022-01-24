using RenderTheGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenderTheGoods.Logic
{
    public interface IRectangleRepository
    {
        List<RectangleModel> GenerateRectanglesHorizontally(InputDto inputDto);

        List<RectangleModel> GenerateRectanglesVertically(List<RectangleModel> rectangleModels);

    }
}
