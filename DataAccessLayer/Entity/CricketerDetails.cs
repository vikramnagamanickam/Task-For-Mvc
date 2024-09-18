using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class CricketerDetails
    {
        [Required]
        [Key]
        public long CricketersID { get; set; }

        public string CricketerName { get; set; }

        public long Totalinnings { get; set; }

        public long TotalScore { get; set; }

        public DateTime DateOfBirth { get; set; }

        public long NumberOfFifties { get; set; }

        public long NumberOfHundreds { get; set; }

        public long HighestScore { get; set; }

        
            

    }
}

    

