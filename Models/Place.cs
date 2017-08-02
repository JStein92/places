using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _city;
    private static List<Place> _placeList = new List<Place>();
    private int _id;
    private int _daysStayed;
    private string _imagePath;

    public Place(string city, int days, string imagePath)
    {
      _city = city;
      _placeList.Add(this);
      _id = _placeList.Count;
      _daysStayed = days;
      _imagePath = imagePath;
    }

    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string city)
    {
      _city = city;
    }
    public static List<Place> GetAll()
    {
      return _placeList;
    }
    public static void ClearAll()
    {
      _placeList.Clear();
    }

    public int getId()
    {
      return _id;
    }

    public static Place Find(int searchId)
    {
      return _placeList[searchId - 1];
    }

    public int GetDays()
    {
      return _daysStayed;
    }

    public void SetDays(int days)
    {
      _daysStayed = days;
    }

    public string GetImagePath()
    {
      return _imagePath;
    }
    public void SetImagePath(string imagePath)
    {
      _imagePath = imagePath;
    }
  }
}
