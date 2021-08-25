using FinalLayihesi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.ViewModels
{
    public class ViewModelServices
    {
        public List<ProcessManagment> Process { get; set; }

        public List<Services> Services { get; set; }
        public List<Business> Businesses { get; set; }
        public SendMessage SendMessage { get; set; }

    }
}
