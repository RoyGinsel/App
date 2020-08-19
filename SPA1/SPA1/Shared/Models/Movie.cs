﻿using System;
using System.Collections.Generic;

namespace SPA1.Shared.Models
{
    public partial class Movie
    {
        public Movie()
        {
            InversePreviousPartNavigation = new HashSet<Movie>();
            MovieCast = new HashSet<MovieCast>();
            MovieDirector = new HashSet<MovieDirector>();
            MovieGenre = new HashSet<MovieGenre>();
            Watchhistory = new HashSet<Watchhistory>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; }
        public int? Duration { get; set; }
        public string Description { get; set; }
        public int? PublicationYear { get; set; }
        public string CoverImage { get; set; }
        public int? PreviousPart { get; set; }
        public decimal Price { get; set; }
        public string Url { get; set; }
        public int? Watched { get; set; }

        public virtual Movie PreviousPartNavigation { get; set; }
        public virtual ICollection<Movie> InversePreviousPartNavigation { get; set; }
        public virtual ICollection<MovieCast> MovieCast { get; set; }
        public virtual ICollection<MovieDirector> MovieDirector { get; set; }
        public virtual ICollection<MovieGenre> MovieGenre { get; set; }
        public virtual ICollection<Watchhistory> Watchhistory { get; set; }
    }
}
