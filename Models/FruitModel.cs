using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp.Models
{
    public class FruitModel
    {
        public FruitModel()
        {

        }
        public FruitModel(string name, string img, string sentense)
        {
            this.Name = name;
            this.ImagePath = img;
            this.Sentense = sentense;
        }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Sentense { get; set; }
    }
}
