using System.Text.Json.Serialization;

namespace RenderTheGoods.Models
{ 
    public class RectangleModel
    {
        [JsonPropertyName("Position")]
        public PositionModel Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Guid Id { get; set; }
    }
}
