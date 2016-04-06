using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFoodConnor.Models
{
    public class RestaurantReview
    {
        public int id { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }
        public string ReviewerName { get; set; }
        public int RestaurantId { get; set; }

    }
}