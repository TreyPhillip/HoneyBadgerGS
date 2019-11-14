﻿using System;
using System.Collections.Generic;

namespace HoneyBadgers._0.Models
{
    public partial class Wishlist
    {
        public Wishlist()
        {
            Game = new HashSet<Game>();
        }
        public int wishlistID { get; set; }
        public string AccountId { get; set; }

        public string itemInfo { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Game> Game { get; set; }
    }
}
