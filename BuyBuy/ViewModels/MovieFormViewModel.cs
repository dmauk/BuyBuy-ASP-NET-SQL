using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuyBuy.Models;

namespace BuyBuy.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public String Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
                
        }
    }
}