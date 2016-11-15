using Nancy;
using Automobile.Objects;
using System.Collections.Generic;

namespace Automobile
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["add_car.cshtml", allCars];
      };
      Post["/"] = _ => {
      Car newCar = new Car(Request.Form["car-model"], Request.Form["car-price"], Request.Form["car-mileage"]);
      newCar.Save();
      List<Car> allCars = Car.GetAll();
      return View["add_car.cshtml", allCars];
      };
    }
  }
}
