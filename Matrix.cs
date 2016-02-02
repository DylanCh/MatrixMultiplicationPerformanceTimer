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
      a = new double[x][y];
      b = new double[m][n];
    }
    
    // Customize matrix
    public Matrix(int x, iny, int m, int n){
      this.x = x;
      this.y = y;
      this.m = m;
      this.n = n;
    }
    
    public double[][] multiplication (){
    	double result[x][n];
	    for (int i = 0; i<x; i++){
		    for (int j = 0; j<n; j++){
			    result[i][j] = 0;
			    for (int k = 0; k<m; k++){
				    result[i][j] = result[i][j] + a[i][k] * b[k][j];
			    }
		    }
	    }
	    return result;
    }
    
    public static void populate(int x,int n, double matrix){
    	for (int row = 0; row < matrix.getLength(0); j++){
		for (int col = 0; col < matrix.getLength(1); k++){
			matrix[col][row]=2;
			}
	}
    }
  }
}
