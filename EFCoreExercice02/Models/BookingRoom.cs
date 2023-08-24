using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExercice02.Models
{
    [Table("booking_room")]
    internal class BookingRoom
    {
        [Comment("-- id --")]
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Comment("-- id de la reservation --")]
        [Column("booking_id")]
        [ForeignKey(nameof(BookingId))] //=> le nom de la var contient ID donc pas nécessaire
        public int BookingId { get; set; }
        [Comment("-- id de la chambre reservee--")]
        [Column("room_id")]
        [ForeignKey(nameof(RoomId))] //=> le nom de la var contient ID donc pas nécessaire
        public int RoomId { get; set; }
        [Comment("-- date de mise à jour de la reservation --")]
        [Column("update_date")]
        public DateTime UpdateDate { get; set; }


    }
}
