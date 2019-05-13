using System;
using System.Collections.Generic;
using System.Text;
using ALaCart.Data;
using ALaCart.Models;

namespace ALaCart.Data.Interfaces
{
    public interface IRestaurantRepository
    {
        Restaurant GetById(int id);
        ICollection<Restaurant> GetAll();



    }
}
