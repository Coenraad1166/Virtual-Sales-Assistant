using DemoFilterApp.MVVM.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace DemoFilterApp.MVVM.ViewModel
{
    public class FilterPageViewModel
    {

        public async Task<List<ProductModel>> FilterByDevice()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("data.json");
            using var reader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(reader);
            var content = await reader.ReadToEndAsync();
            var items = JsonConvert.DeserializeObject<List<ProductModel>>(content);
            return items;
            
        }

        public async Task<List<ProductModel>> FilterByPrimaryUse(Button button, List<ProductModel> list)
        {
            if(button.Text == "Office" || button.Text == "School")
            {
                return list.Where(x => Regex.IsMatch(x.Cpu, @"\b(i3|i5)\b")).ToList();
            }
            else if (button.Text == "Design" ||  button.Text == "Gaming")
            {
                return list.Where(x => x.HasGPU == true).ToList();
            }
            else
            {
                return list.Where(x => Regex.IsMatch(x.Cpu, @"\b(i7)\b")).ToList();
            }
            

        }

        public async Task<List<ProductModel>> FilterByBrand(List<string> list, List<ProductModel> secondList)
        {
            var newList = new List<ProductModel>();
            foreach (var item in list)
            {
                var filterList = secondList.Where(x => item == x.Brand).ToList();
                newList.AddRange(filterList);
            }
            return newList;
        }

        public async Task<List<ProductModel>> FilterByPrice(Button button, List<ProductModel> list)
        {
            var parsing = Int64.Parse(button.Text);
            var test = list.Where(x => x.Price <= parsing).ToList();
            return test;
        }
    }
}

