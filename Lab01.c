#include<stdio.h>
int main()
/*{
    int num1,num2,sum;
    printf("Enter two numbers");
    scanf("%d %d",&num1,&num2);
    sum = num1 + num2;
    printf("%d + %d = %d",num1,num2,sum);
    return 0;
}*/

{
    int num,sum,i;
    float avg;
    printf("Enter five numbers");
    for(i=0; i<5; i++)
        scanf("%d",&num);
    sum = sum + num;
    avg = sum/(float)5;
    printf("Average = %.2f",avg);
    return 0;
}
