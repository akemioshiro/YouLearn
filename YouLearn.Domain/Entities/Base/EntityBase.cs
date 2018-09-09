﻿using System;

namespace YouLearn.Domain.Entities.Base
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Id = new Guid();
        }
        
        public virtual Guid Id { get; set; }
    }
}