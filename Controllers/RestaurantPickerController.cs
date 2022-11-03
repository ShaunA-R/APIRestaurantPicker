using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIRestaurantPicker.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        [HttpGet]
        [Route("Restaurant/{restaurantType}")]

    public string RestaurantPicker(string restaurantType)
    {
        Random random = new Random();

        string[] fastFood = {"McDonalds", "Wendys", "Burger King", "Taco bell", "Jack in the Box", "Taco Truck", "Chipotle", "In and Out", "Carls JR", "Chic Fil A"};

        string[] pizza = {"Pizza Hut", "Dominoes", "lil Ceasers", "Papa Johns", "Piology", "Micheals pizza", "Eddies Pizza", "Costco Pizza", "Frozen Pizza", "Chuck e Cheese"};

        string[] dineIn = {"Olive Garden", "Red Lobster", "Garlic Brothers", "Applebees", "Dennys", "IHOP", "The Habit", "Lumberjacks", "Black Bear Diner", "BJ's"};

        string[] all = {"Pizza Hut", "Dominoes", "lil Ceasers", "Papa Johns", "Piology", "Micheals pizza", "Eddies Pizza", "Costco Pizza", "Frozen Pizza", "Chuck e Cheese", 
                    "McDonalds", "Wendys", "Burger King", "Taco bell", "Jack in the Box", "Taco Truck", "Chipotle", "In and Out", "Carls JR", "Chic Fil A",
                    "Olive Garden", "Red Lobster", "Garlic Brothers", "Applebees", "Dennys", "IHOP", "The Habit", "Lumberjacks", "Black Bear Diner", "BJ's"};

        int fastFoodIndex = random.Next(fastFood.Length);
        int pizzaIndex = random.Next(pizza.Length);
        int dineInIndex = random.Next(dineIn.Length);
        int allIndex = random.Next(all.Length);

        if (restaurantType == "fastfood") return fastFood[fastFoodIndex];
        if (restaurantType == "pizza") return pizza[pizzaIndex];
        if (restaurantType == "dinein") return dineIn[dineInIndex];
        if (restaurantType == "all") return all[allIndex];
        if (restaurantType == "WhatAreMyOptions") return "Your options are: 'fastfood' 'delivery' 'dinein' 'all'";
        else return "Not a valid restaruant type";
    }
    }
