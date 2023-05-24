using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Activity2.Models
{
    public class MovieModel
    {
        [DisplayName ("Id Number")]
        public int Id { get; set; }
        [DisplayName("Movie Title")]
        public string Title { get; set; }
        [DisplayName("Critics Thoughts")]
        public string Review { get; set; }
        [DisplayName("Release Date")]
        [DataType (DataType.DateTime)]
        public  DateTime Release { get; set; }
    }
}
