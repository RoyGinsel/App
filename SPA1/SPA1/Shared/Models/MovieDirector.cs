using System;
using System.Collections.Generic;

namespace SPA1.Shared.Models
{
    public partial class MovieDirector
    {
        public int MovieId { get; set; }
        public int PersonId { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Person Person { get; set; }
    }
}
