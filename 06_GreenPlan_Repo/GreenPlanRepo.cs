using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_GreenPlan_Repo
{
    public class GreenPlanRepo
    {
        public List<GreenPlan> _listOfCars = new List<GreenPlan>();
        //Create
        public void AddCarsToList(GreenPlan car)
        {
            _listOfCars.Add(car);
        }
        //Read
        public List<GreenPlan> GetCars()
        {
            return _listOfCars;
        }
        //Working efforts to get cars by Enum:Type
        //public GreenPlan GetCarsByType(string type)
        //{
        //    foreach (GreenPlan car in _listOfCars)
        //    {
        //        if (car.Type() == type())
        //        {
        //            return car;
        //        }
        //    }
        //    return null;
        //}
        ////public string PullGreenType(GreenType plan)
        ////{
        ////    string car1;
        ////    foreach (GreenPlan car in _listOfCars)
        ////    {
        ////        if (plan == car.Type)
        ////        {
        ////            return
        ////        }
        ////    }
        ////    return
        ////}
        public GreenPlan GetCarsByModel(string model)
        {
            foreach (GreenPlan car in _listOfCars)
            {
                if (car.Model == model)
                {
                    return car;
                }
            }
            return null;
        }
        public GreenPlan GetCarsByNum(int carNum)
        {
            foreach (GreenPlan car in _listOfCars)
            {
                if (car.CarNum == carNum)
                {
                    return car;
                }
            }
            return null;
        }
        //Update
        //public bool UpdateCarByModel(string origModel, GreenPlan car)
        //{
        //    //Find the item
        //    GreenPlan oldCar = GetCarsByModel(origModel);
        //    //Update car
        //    if (oldCar != null)
        //    {
        //        oldCar.Type = car.Type;
        //        oldCar.Make = car.Make;
        //        oldCar.Model = car.Model;
        //        oldCar.CityMpg = car.CityMpg;
        //        oldCar.HwyMpg = car.HwyMpg;
        //        oldCar.Msrp = car.Msrp;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //Update by num
        public bool UpdateCarByNum(int origNum, GreenPlan car)
        {
            //Find the item
            GreenPlan oldCar = GetCarsByNum(origNum);
            //Update car
            if (oldCar != null)
            {
                oldCar.Type = car.Type;
                oldCar.Make = car.Make;
                oldCar.Model = car.Model;
                oldCar.CityMpg = car.CityMpg;
                oldCar.HwyMpg = car.HwyMpg;
                oldCar.Msrp = car.Msrp;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete
        //public bool RemoveCarByModel(string model)
        //{
        //    GreenPlan car = GetCarsByModel(model);
        //    if (car == null)
        //    {
        //        return false;
        //    }
        //    int initialCount = _listOfCars.Count;
        //    _listOfCars.Remove(car);
        //    if (initialCount > _listOfCars.Count)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool RemoveCarByNum(int carNum)
        {
            GreenPlan car = GetCarsByNum(carNum);
            if (car == null)
            {
                return false;
            }
            int initialCount = _listOfCars.Count;
            _listOfCars.Remove(car);
            if (initialCount > _listOfCars.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
