using System.Collections.Generic;
using System.Linq;
using System;


namespace PingPongs.Models
{
    public class PingPong
    {
      private List<int> _range = new List<int>{};

      public PingPong()
      {
        _range = new List<int>{};
      }

      public List<string> IsDiv(List<int> TargetRange)
        {List<string> output = new List<string>();
          string EachNumber = "";
         foreach (int x in TargetRange){
          if (x % 3 == 0 && x % 5 == 0)
            {EachNumber = "PingPong";
          }else if (x % 3 == 0)
            { EachNumber = "Ping";
          }else if (x % 5 == 0)
            {EachNumber = "Pong";
          }else {
            EachNumber = x.ToString();
          }
          output.Add(EachNumber);
        }
        return output;

      }

      public List<int> GetRange()
      {
        return _range;
      }

      public List<int> SetRange(int RangeTarget)
      {
        List<int> ourRange = new List<int>{};
        for (int x = 0; x <= RangeTarget; x++){
          ourRange.Add(x);
        }
        _range = ourRange;
        return _range;
      }

    }
}
