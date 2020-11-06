using System;
using System.Collections.Generic;
using OdeToFoodCore;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> list_Restaurants;

        public InMemoryRestaurantData()
        {
            list_Restaurants = new List<Restaurant>()
            {
                new Restaurant { RestaurantId = 1, RestaurantName = "La Patrona", RestaurantLocation = "Cerrada de San Francisco", RestaurantCuisine = OdeToFoodCore.CuisineType.CuisineType_Mexican},
                new Restaurant { RestaurantId = 2, RestaurantName = "Picudos", RestaurantLocation = "San Lorenzo", RestaurantCuisine = OdeToFoodCore.CuisineType.CuisineType_Mexican},
                new Restaurant { RestaurantId = 3, RestaurantName = "La Patrona", RestaurantLocation = "Miguel Laurent", RestaurantCuisine = OdeToFoodCore.CuisineType.CuisineType_Mexican}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return list_Restaurants;
        }
    }
}
