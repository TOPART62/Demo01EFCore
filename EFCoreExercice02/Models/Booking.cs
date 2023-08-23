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
        [Comment("-- id de la reservation --")]
        [Key]
        [Column("id")] 
        public int Id { get; set; }
        [Comment("-- date debut de reservation --")]
        [Required]
        [Column("begin_date")]
        public DateTime BeginningDate { get; set; }
        [Comment("-- date fin de reservation --")]
        [Required]
        [Column("end_date")]
        public DateTime EndDate { get; set; }
        [Comment("-- status de la reservation --")]
        [Required]
        [Column("status")]
        public EnumBookingStatus Status { get; set; }
        //[ForeignKey(nameof(Client))]   
        [Comment("-- id du client de la reservation --")]
        [Required]
        [Column("client_id")]
        public int ClientId { get; set; }
        [Comment("-- client de la reservation --")]
        [Required]
        [Column("client")]
        public Client? Client { get; set; }
    }
}
