﻿using System;
using System.Collections.Generic;

namespace HoneyBadgers_3._0.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int? AccountId { get; set; }
        public int? GameId { get; set; }
        public string ReviewInfo { get; set; }

        public virtual Account Account { get; set; }
        public virtual Game Game { get; set; }
    }
}
