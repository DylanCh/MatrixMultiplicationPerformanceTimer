using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading;

namespace MatrixMultiplicationPerformanceTimer{
  public class program {
    public static void Main(){
      Matrix matrix = new Matrix(8,8,8,8);
	  matrix.populate();
      
      double[][] result;
      
      HiPerfTimer timer = new HiPerfTimer();
			Console.WriteLine ("Duration: ");
      timer.Start();
      // do multiplication 
      result = matrix.multiplication();
      timer.Stop();  
			Console.WriteLine (timer.Duration.ToString());
  		}
	}
}
