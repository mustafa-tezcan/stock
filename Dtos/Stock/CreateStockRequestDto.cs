using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {

        [Required]
        [MaxLength(10, ErrorMessage = "symbol can not be over 10 characters")]
    
        public String Symbol { get; set; } = String.Empty;

        [Required]
        [MaxLength(10, ErrorMessage = "company name can not be over 10 characters")]

        public String CompanyName { get; set; } = String.Empty;


        [Required]
        [Range(1,100000000)]      
        public decimal Purchase { get; set; }

  
        [Required]
        [Range(0.001,100)]   
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "industiry can not be over 10 characters")]

        public String Industry { get; set; } = String.Empty;

        [Required]
        [Range(1,5000000000)]   
        public long MarketCap { get; set; }

    }
}