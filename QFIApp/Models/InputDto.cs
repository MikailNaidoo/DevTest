using System.ComponentModel.DataAnnotations;

namespace QFIApp.Models
{
    public class InputDto
    {
        [Range(3,20)]
        public int NumberOfRectangles { get; set; }
    }
}
