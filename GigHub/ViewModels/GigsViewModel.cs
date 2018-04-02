﻿using GigHub.Models;
using System.Linq;

namespace GigHub.ViewModels
{
    public class GigsViewModel
    {
        public IQueryable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
    }
}