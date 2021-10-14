using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookieJars.Models
{
    //Datamodel for cookie jar object
    public class Jars
    {
        
        public int Id { get; set; }
        public string ProductImage { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Coating { get; set; }
        public string Rarity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
