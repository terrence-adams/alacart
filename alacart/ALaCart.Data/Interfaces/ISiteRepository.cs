using System;
using System.Collections.Generic;
using System.Text;
using ALaCart.Models;

namespace ALaCart.Data.Interfaces
{
    public interface ISiteRepository
    {
        //CRUD
        Restaurant Create(Restaurant newRestaurant);

        bool Delete(int iD);

        Restaurant Update(Restaurant oldRestaurant);

        Restaurant GetById(int id);


    }
}
