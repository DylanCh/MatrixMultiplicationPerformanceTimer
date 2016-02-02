using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading;

namespace MatrixMultiplicationPerformanceTimer{
  public class program {
    public static void Main(){
      Matrix matrix = new Matrix();
      matrix.populate();
      HiPerfTimer timer = new HiperfTimer();
      timer.Start();
      // do multiplication matrix.multiplication();
      timer.Stop();  
    }
  }
}
