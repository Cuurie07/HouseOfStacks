﻿// Decompiled with JetBrains decompiler
// Type: two.Models.SentimentResult
// Assembly: two, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9B0281BB-FC0F-4F23-B370-957761C517AE
// Assembly location: E:\wwwroot\bin\two.dll

namespace two.Models
{
  public class SentimentResult
  {
    public double positiveValue { get; set; }

    public double negativeValue
    {
      get
      {
        return 1.0 - this.positiveValue;
      }
    }
  }
}
