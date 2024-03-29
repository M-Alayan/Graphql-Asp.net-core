﻿using GraphqlExample.Models;

namespace GraphqlExample.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
         context.Superheroes;
    }
}
