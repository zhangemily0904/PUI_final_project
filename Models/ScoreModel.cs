using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Models
{
    public class ScoreModel
    {
      public int scoreDigit;
      public ScoreModel(int score) {
        scoreDigit = score;
      }
      
    }
}
