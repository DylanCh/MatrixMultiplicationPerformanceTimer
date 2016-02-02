using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading;

namespace MatrixMultiplicationPerformanceTimer{
  public class program {
    public static void Main(){
      Matrix matrix = new Matrix();
      Matrix.populate(matrix.a);
      Matrix.populate(matrix.b);
      
      double[][] result;
      
      HiPerfTimer timer = new HiperfTimer();
      
      timer.Start();
      // do multiplication 
      result = matrix.multiplication();
      timer.Stop();  
    }
  }
}
