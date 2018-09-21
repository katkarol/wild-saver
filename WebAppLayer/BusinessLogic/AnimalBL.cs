using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.BusinessLogic
{
    public class AnimalBL
    {
        private AnimalDAL animalDAL; 
        public AnimalBL()
        {
            animalDAL = new AnimalDAL();
        }

        public void AdicionarAnimal(Animal animal)
        {
            animalDAL.Adicionar(animal);
        }
    }
}