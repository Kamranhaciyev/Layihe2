using FinalLayihesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.ViewModels
{
    public class ViewModelAbout
    {
        public List<Company> Companies { get; set; }
        public Results Results { get; set; }
        public List<ResultCards> ResultCards { get; set; }
        public About About { get; set; }
        public List<AboutCard> AboutCards { get; set; }
        public List<Testimonials> Testimonials { get; set; }
    }
}
