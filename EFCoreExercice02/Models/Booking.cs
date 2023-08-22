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
    public enum EnumBookingStatus
    {
        [Description("prévu")]
        planned,
        [Description("en cours")]
        inProgress,
        [Description("fini")]
        finished,
        [Description("annulé")]
        canceled
    }

    [Table("booking")]
    internal class Booking
    {
        [Key]
        [Column("id")] 
        public int Id { get; set; }
        [Required]
        [Column("status")]
        public EnumBookingStatus Status { get; set; }
        [Required]
        [Column("client_id")]
        public int ClientId { get; set; }
        [Required]
        [Column("client")]
        public Client? Client { get; set; }
    }
}
