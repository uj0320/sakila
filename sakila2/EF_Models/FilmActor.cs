﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace sakila2.EF_Models
{
    public partial class FilmActor
    {
        public ushort ActorId { get; set; }
        public ushort FilmId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Film Film { get; set; }
    }
}