
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFilterApp.MVVM.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model {  get; set; }
        public string Cpu { get; set; }
        public string RAM { get; set; }
        public bool HasGPU { get; set; }
        public string GPU { get; set; }
        public string HDD { get; set; }
        public string OS { get; set; }
        public string Size { get; set; }
        public Int64 Price { get; set; }
        public string Image {  get; set; }
        public string Url { get; set; }
    }
    
}
