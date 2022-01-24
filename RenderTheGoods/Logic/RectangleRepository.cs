
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RenderTheGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace RenderTheGoods.Logic
{
    public class RectangleRepository : IRectangleRepository
    {
        private readonly IConfiguration _configuration; 
        public RectangleRepository(IConfiguration configuration)
        {
            _configuration = configuration;  
        }
        const string endpoint = "https://localhost:7096/api/Rectangles";
        public List<RectangleModel> GenerateRectanglesHorizontally(InputDto inputDto)
        {
            List<RectangleModel> rectangles = new List<RectangleModel>();
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync(
                  endpoint + "/GenerateRectanglesHorizontally", inputDto).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    if (result.Result != null)
                    {
                        rectangles = JsonConvert.DeserializeObject<List<RectangleModel>>(result.Result);
                    }

                }
                return rectangles; 
            }
        }

        public List<RectangleModel> GenerateRectanglesVertically(List<RectangleModel> rectangleModels)
        {
            List<RectangleModel> resultRectangles = new List<RectangleModel>();
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync(
                  endpoint + "/GenerateRectanglesVertically", rectangleModels).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    if (result.Result != null)
                    {
                        resultRectangles = JsonConvert.DeserializeObject<List<RectangleModel>>(result.Result);
                    }

                }
                return resultRectangles;
            }
        }
    }
}
