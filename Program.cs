﻿
namespace Instruments
{
  class Program
  {
    static void Main(string[] args)
    {
      Ibanez myGuitar = new Ibanez();
      myGuitar.brand();
      myGuitar.sound();

      Fender myBass = new Fender();
      myBass.brand();
      myBass.strings();
    }
  }
}