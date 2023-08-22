using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice02.Models
{
    internal class BookingRoom
    {
        [Key]
        [Column("booking_id")]
        public int BookingId { get; set; }
        [Key]
        [Column("room_id")]
        public int RoomId { get; set; }
        [Key]
        [Required]
        [Column("begin_date")]
        public DateTime BeginningDate { get; set; }
        [Key]
        [Required]
        [Column("end_date")]
        public DateTime EndDate { get; set; }
        public DateTime UpdateDate { get; set; }


    }
}
