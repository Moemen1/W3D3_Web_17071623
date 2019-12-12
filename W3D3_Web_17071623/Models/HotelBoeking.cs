using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W3D3_Web_17071623.Models
{
    public class HotelBoeking
    {
        public int HotelBoekingId { get; set; }
        public DateTime Aankomst { get; set; }
        public DateTime Vertrek { get; set; }        
    }
}
