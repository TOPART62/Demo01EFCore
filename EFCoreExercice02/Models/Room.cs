using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExercice02.Models
{
    public enum EnumRoomStatus  
    {
        [Description("libre")]
        free,
        [Description("occupé")]
        busy,
        [Description("en cours de nettoyage")]
        cleaning
    }
    [Table("room")]
    internal class Room
    {
        [Comment("-- id de la chambre --")]
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Comment("-- status de la chambre --")]
        [Required]
        [Column("status")]
        public EnumRoomStatus Status { get; set; }
        [Comment("-- numero de la chambre --")]
        [Required]
        [Column("beds_number")]
        public int BedsNumber{ get; set; }
        [Comment("-- tarif de la chambre --")]
        [Column("room_rate")]
        [Required]
        [Precision(8,2)] 
        public decimal RoomRate { get; set; }



    }
}
