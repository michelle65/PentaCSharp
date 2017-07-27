using Repository_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository_Pattern.Mapper
{
    public static class AnimalMapper
    {

        public static Animal ToModelUi(this Repository_Pattern.Models.Animal animal)
        {
            return new Animal()
            {
                Id = animal.Id,
                Name = animal.Name

            };
        }

        public static Repository_Pattern.Models.Animal ToModelDb(this Animal animal)
        {
            return new Repository_Pattern.Models.Animal()
            {
                Id = animal.Id,
                Name = animal.Name
            };
        }

    }
}