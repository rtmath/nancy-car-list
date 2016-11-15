using Nancy;
using Automobile.Objects;
using System.Collections.Generic;

namespace Automobile
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_car.cshtml"];
      Get["/show_cars"] = _ =>{
        List<Car> allCars = Car.GetAll();
        return View["show_cars.cshtml", allCars];
      };
      Post["/car_added"] = _ => {
      Car newCar = new Car(Request.Form["car-model"], Request.Form["car-price"], Request.Form["car-mileage"]);
      newCar.Save();
      return View["car_added.cshtml", newCar];
      };
    }
  }
}
