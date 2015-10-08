﻿using System;

using FubarDev.Lexware.Database.Shared;

namespace FubarDev.Lexware.Database.Faktura
{
    public class Preisgruppe : IAuditEntity
    {
        /// <summary>
        /// PreisgrpNr
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Preisgrp
        /// </summary>
        public virtual string Name { get; set; }

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
    }
}