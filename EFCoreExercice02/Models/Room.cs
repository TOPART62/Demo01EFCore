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
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("status")]
        public EnumRoomStatus Status { get; set; }
        [Required]
        [Column("beds_number")]
        public int BedsNumber{ get; set; }
        [Column("room_rate")]
        [Required]
        [Precision(8,2)] 
        public decimal RoomRate { get; set; }



    }
}
