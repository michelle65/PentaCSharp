using Repository_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository_Pattern.DAL
{
    interface IAnimalRepository:IDisposable
    {

        void Add(Animal animal);

        void Update(Animal animal);

        void Delete(Animal animal);

        Animal Get(String name);

        void Save();

        void GetAll();

    }
}