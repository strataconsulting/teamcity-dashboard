﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamCityDashboard.Interfaces
{
  public interface IBuildConfig
  {
    string Id { get; }
    string Name { get; }
    string Url { get; }
    bool CurrentBuildIsSuccesfull { get; }
    string PossibleBuildBreakerEmailAddress { get; }
  }
}
