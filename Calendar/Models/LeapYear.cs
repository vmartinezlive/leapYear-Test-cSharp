namespace Calendar
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      // logic will go here
      if (year % 400 == 0)
      {
        return true;
      }
      if ( year % 100 == 0)
      {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }
    }

  }
}
