using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{

    //
    // Model which allow to create database with attributes such as attributes
    public class Movie
    {
        // Required by the database for the primary key
        public int Id { get; set; }
        public string Title { get; set; }

        // Allow enter only date info, time is not necessary
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}