using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Models
{
    public class Genre
    {
        [Key]
        public int genreId { get; set; }
        public string genreTitle { get; set; }
    }
}
