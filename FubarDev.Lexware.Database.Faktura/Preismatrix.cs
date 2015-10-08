﻿using System;
using System.Diagnostics.CodeAnalysis;

using FubarDev.Lexware.Database.Shared;

namespace FubarDev.Lexware.Database.Faktura
{
    public class Preismatrix : IAuditEntity, IEquatable<Preismatrix>
    {
        /// <summary>
        /// MengeNr
        /// </summary>
        public virtual Menge Menge { get; set; }

        /// <summary>
        /// PreisgrpNr
        /// </summary>
        public virtual Preisgruppe Preisgruppe { get; set; }

        /// <summary>
        /// Vk_preis
        /// </summary>
        public virtual decimal Verkaufspreis { get; set; }

        /// <summary>
        /// Vk_preis_eur
        /// </summary>
        public virtual decimal VerkaufspreisEuro { get; set; }

        /// <summary>
        /// System_created
        /// </summary>
        public virtual DateTime? Created { get; set; }

        /// <summary>
        /// System_created_user
        /// </summary>
        public virtual string CreatedBy { get; set; }

        /// <summary>
        /// System_updated
        /// </summary>
        public virtual DateTime? Updated { get; set; }

        /// <summary>
        /// System_updated_user
        /// </summary>
        public virtual string UpdatedBy { get; set; }

        public virtual bool Equals(Preismatrix other)
        {
            if (ReferenceEquals(other, null))
                return false;
            return Menge.Equals(other.Menge)
                   && Preisgruppe.Id == other.Preisgruppe.Id;
        }

        public override bool Equals(object obj)
        {
            return Equals((Preismatrix)obj);
        }

        [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
        public override int GetHashCode()
        {
            return Menge.GetHashCode()
                   ^ Preisgruppe.Id.GetHashCode();
        }
    }
}
