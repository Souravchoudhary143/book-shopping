﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_comm_Models.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, 1000)]
        public double ListPrice { get; set; }
        [Required]
        [Range(1, 1000)]
        public double Price { get; set; }
        [Required]
        [Range(1, 1000)]
        public double Price50 { get; set; }
        [Required]
        [Range(1, 1000)]
        public double Price100 { get; set; }
        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category category { get; set; }
        [Display(Name = "Cover Type")]
        //public int CTID { get; set; }
        //[ForeignKey("CTID")]
        public CoverType coverType { get; set; }
        public int QyntBookSoled { get; set; }

    }
}