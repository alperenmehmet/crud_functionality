using CRUDOperation_ASP.NET_Web_Application.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUDOperation_ASP.NET_Web_Application.Infrastructure.Entities.Abstract
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate 
        {
            get => _createDate;
            set => _createDate = value;
        }

        public DateTime? UpdateDate { get; set; }
        
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status
        {
            get => _status;
            set => _status = value;
        }

        
    }
}