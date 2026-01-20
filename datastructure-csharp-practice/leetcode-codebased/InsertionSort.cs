using System;
class InsertionSort{
  static void Main(){
    int []a={9,6,4,3,21,89,66,55};
    for(int i=1;i<a.Length;i++){
      int k=a[i];
      int j=i-1;
      while(j>=0 && a[j]>k){
         a[j+1]=a[j];
         j--;

      }
      a[j+1]=k;
 }
    Console.WriteLine(string.Join(" ", a));
  }  
}  