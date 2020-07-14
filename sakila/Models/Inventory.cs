﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace sakila.Models
{
    public partial class Inventory
    {
        public Inventory()
        {
            Rental = new HashSet<Rental>();
        }

        public uint InventoryId { get; set; }
        public ushort FilmId { get; set; }
        public byte StoreId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Film Film { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Rental> Rental { get; set; }
    }
}