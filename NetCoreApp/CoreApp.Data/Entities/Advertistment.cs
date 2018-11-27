using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreApp.Data.Interfaces;
using CoreApp.Data.Enums;
using CoreApp.Infrastructure.SharedKernel;

namespace CoreApp.Data.Entities
{
    [Table("Advertistment")]
    public class Advertistment : DomainEntity<int>, ISwitchable, ISortable, IDateTracking
    {
        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [MaxLength(250)]
        public string Url { get; set; }

        [StringLength(20)]
        public string PositionId { get; set; }

        public Status Status { get; set; }

        public int SortOrder { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        [ForeignKey("PositionId")]
        public virtual AdvertistmentPosition AdvertistmentPosition { get; set; }
    }
}

