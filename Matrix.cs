using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace MatrixMultiplicationPerformanceTimer{
  public class Matrix{
    public int x;
    public int y;
    public int m;
    public int n;
    public double[][] a;
    public double[][] b;
    
    // Default: 8x8 matrix
    public Matrix(){
      x=y=m=n=8;
      //https://msdn.microsoft.com/en-us/library/aa287601(v=vs.71).aspx
      a = new double[x][];
      b = new double[m][];
    }
    
    // Customize matrix
    public Matrix(int x, int y, int m, int n){
      this.x = x;
      this.y = y;
      this.m = m;
      this.n = n;
      a = new double[x][];
      b = new double[m][];
    }
    
    public double[][] multiplication (){
    	double[][] result = new double[x][];
	    for (int i = 0; i < x; i++){
		    for (int j = 0; j < n; j++){
			    result[i][j] = 0;
			    for (int k = 0; k<m; k++){
				    result[i][j] = result[i][j] + a[i][k] * b[k][j];
			    }
		    }
	    }
	    return result;
    }
    
    public static void populate(double[][] matrix){
    	for (int row = 0; row < matrix.GetLength(0); row++){
		    for (int col = 0; col < matrix.GetLength(1); col++){
			    matrix[col][row]=2;
			}
	    }
    } // end method

    public void print() { 
        
    }
  }
}
