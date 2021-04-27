﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        [Range(1,5)]
        public string Description { get; set; }

        [Required]
        public int Priority { get; set; }
    }
}
