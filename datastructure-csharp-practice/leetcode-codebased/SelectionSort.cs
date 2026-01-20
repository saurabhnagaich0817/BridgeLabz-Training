class SelectionSort{
  static void Main(){
    int []a=new int[5];
    for(int i=0;i<a.Length;i++){
      a[i]=int.Parse(Console.ReadLine());
    }
    for(int i=0;i<a.Length-1;i++){
      int minIndx=i;

      for(int j=i+1;j<a.Length;j++){
        if(a[j]<a[minIndx]){
          minIndx=j;
        }

      }
      int t=a[minIndx];
      a[minIndx]=a[i];
      a[i]=t;

    }
    Console.WriteLine(string.Join(" ",a));
  }
}