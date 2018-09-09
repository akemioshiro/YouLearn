﻿using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.Enums;

namespace YouLearn.Domain.Entities
{
    public class Playlist : EntityBase
    {
        public Usuario Usuario { get; private set; }

        public EnumStatus Status { get; private set; }

        public string Nome { get; private set; }
    }
}
