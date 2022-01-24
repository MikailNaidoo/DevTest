// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Net.Http.Json;


const string Apiurl = "https://localhost:7096/api/Rectangles";
//static void ShowProduct(Product product)
//{
//    Console.WriteLine($"Name: {product.Name}\tPrice: " +
//        $"{product.Price}\tCategory: {product.Category}");
//}

async Task<string> GetInputRectangles()
{
    using (var client = new HttpClient())
    {
        HttpResponseMessage response = await client.PostAsJsonAsync(
           Apiurl+ "/GenerateRectangles", new { NumberOfRectangles=3});
        if(response.IsSuccessStatusCode)
        {
            var res= response.Content.ReadAsStringAsync();
        }

        // return URI of the created resource.
        return await response.Content.ReadAsStringAsync();
    }
}

string value=await GetInputRectangles();

