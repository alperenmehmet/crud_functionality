using CRUDOperation_ASP.NET_Web_Application.Infrastructure.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUDOperation_ASP.NET_Web_Application.Infrastructure.Entities.Concrete
{
    public class Person : BaseEntity
    {
        [Required, MaxLength(50), Column("Name", TypeName = "nvarchar")]
        public string Name { get; set; }

        [Required, MaxLength(50), Column("LastName", TypeName = "nvarchar")]
        public string LastName { get; set; }

        [Required, Column("BirthDate", TypeName = "int")]
        public int BirthDate { get; set; }

    }
}