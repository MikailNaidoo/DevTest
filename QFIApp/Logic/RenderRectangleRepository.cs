using QFIApp.Models;

namespace QFIApp.Logic
{
    public class RenderRectangleRepository : IRenderRectangleRepository
    {
        public RenderRectangleRepository()
        {

        }
        /// <summary>
        /// Generates random heights and maps positions of input rectangles horizontally
        /// </summary>
        /// <param name="numberOfRectangles"></param>
        /// <returns>List of Rectangle Model - axis and dimensions of rectangles</returns>
        public List<RectangleModel> GenerateRectanglesHorizontally(int numberOfRectangles)
        {
            List<RectangleModel> horizontalRectangles = new List<RectangleModel>();
            RectangleModel rectangleModel;
            PositionModel postionModel;
            Random random;
            int x = 0;

            for (int i = 0; i < numberOfRectangles; i++)
            {
                rectangleModel = new RectangleModel();
                postionModel = new PositionModel();
                random = new Random();
                rectangleModel.Id = Guid.NewGuid();
                postionModel.X = x;
                postionModel.Y = 0;
                rectangleModel.Height = random.Next(200);
                rectangleModel.Width = random.Next(200);
                rectangleModel.Position = postionModel;
                horizontalRectangles.Add(rectangleModel);
                x += rectangleModel.Width;

            }
            return horizontalRectangles;
        }

        /// <summary>
        /// Gets horizontally stacked rectangles and stacks them vertically
        /// </summary>
        /// <param name="rectangleModels"></param>
        /// <returns>List of Rectangle model</returns>
        public List<RectangleModel> GenerateRectanglesVertically(List<RectangleModel> rectangleModels)
        {

            int baseWidth = 0;
            int TallestRectangle = 0;
            int previousY = 0;
            List<RectangleModel> verticalRectangles = new List<RectangleModel>();
            foreach (RectangleModel rectangleModel in rectangleModels)
            {
                if (rectangleModel.Height > TallestRectangle)
                {
                    TallestRectangle = rectangleModel.Height;
                }
                baseWidth += rectangleModel.Width;
            }
            foreach (RectangleModel rectangleModel in rectangleModels)
            {

               
                rectangleModel.Position.X = previousY + rectangleModel.Position.X;
                rectangleModel.Position.Y = TallestRectangle - rectangleModel.Height;
                rectangleModel.Width = baseWidth;
                verticalRectangles.Add(rectangleModel);
                previousY += rectangleModel.Width;
            }
            return verticalRectangles;
          
        }

    }
}

