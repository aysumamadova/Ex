using exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.ViewModels
{
    public class HomeVM
    {
        public List<Dinner> Dinners { get; set; }
        public List<Brunch> Brunches { get; set; }
        public List<Breakfast> Breakfasts { get; set; }
    }
}
