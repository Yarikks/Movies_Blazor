﻿using Movies_Blazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_Blazor.Client.Repository
{
    public interface IRatingRepository
    {
        Task Vote(MovieRating movieRating);
    }
}
