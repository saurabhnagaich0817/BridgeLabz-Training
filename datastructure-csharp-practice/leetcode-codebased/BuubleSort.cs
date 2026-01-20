class BubbleSort{
  static void Main(String[]args){
    int []a=new int[5];
    for(int i=0;i<a.Length;i++){
      a[i]=int.Parse(Console.ReadLine());
    }
    for(int i=0;i<a.Length-1;i++){
      for(int j=0;j<a.Length-i-1;j++){
        if(a[j]>a[j+1]){
          int t=a[j+1];
          a[j+1]=a[j];
          a[j]=t;
        }
      }
    }
    foreach(int n in a){
      Console.Write(n+" ");
    }
  }
}