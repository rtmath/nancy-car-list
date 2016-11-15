using System;
using System.Collections.Generic;

namespace Automobile.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<Car> _instances = new List<Car>{};

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string makeModel)
    {
      _makeModel = makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int price)
    {
      _price = price;
    }

    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles(int miles)
    {
      _miles = miles;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }
  }
}
