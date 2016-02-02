using System;

namespace MatrixMultiplicationPerformanceTimer{
  public class MatrixMultiplication{
    public int x;
    public int y;
    public int m;
    public int n;
    
    // Default: 8x8 matrix
    public MatrixMultiplication(){
      x=y=m=n=8;
    }
    
    // Customize matrix
    public MatrixMultiplication(int x, iny, int m, int n){
      this.x = x;
      this.y = y;
      this.m = m;
      this.n = n;
    }
    
    public void multiplication(int** c,int** b,int** a){
	    for (int i = 0; i<x; i++){
		    for (int j = 0; j<n; j++){
			    c[i][j] = 0;
			    for (int k = 0; k<m; k++){
				    c[i][j] = c[i][j] + a[i][k] * b[k][j];
			    }
		    }
	    }
    }
  }
}
