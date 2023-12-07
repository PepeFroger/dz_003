using System;
Random rnd = new Random();
int N = 5;
int M = 6;
int[,] mas = new int[N,M];
for (int i=0; i<N;i++){
    for(int j=0;j<M;j++){
        mas[i,j] = rnd.Next(-100,100);
        Console.Write($"{mas[i,j]}\t");
    }
    Console.WriteLine();
}
int min=1000, summ, min_i=0;
Console.WriteLine();
for (int i=0; i<N;i++){
    summ=0;
    for(int j=0; j<M;j++){
        summ = summ + mas[i,j];
        if (min>summ){
            min = summ;
            min_i=i;
        }
    }
}
Console.WriteLine($"Миниммальная сумма {min}, номер строки с минимальной суммой {min_i+1}");
