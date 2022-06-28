using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sailor.Models;

namespace Sailor.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Card> Cards { get; set; }
        public List<Brand> Brands { get; set; }
    }
}
