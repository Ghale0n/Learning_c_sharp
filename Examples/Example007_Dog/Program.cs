int distance = 10000;
int FFS = 1; //FirstFriendSpeed
int SFS = 2; //SecondFriendSpeed
int DS = 5; //DogSpeed
int FR = 2; //Friend
int time = 0;
int count = 0; //Count dog runs
while(distance > 10)
{
    if(FR == 1)
    {
        time = distance / (FFS + DS);
        FR = 2;
    }
    else
    {
        time = distance / (SFS + DS);
        FR = 1;
    }
     
    distance = distance - (FFS + SFS) * time;

    count++;
}
Console.WriteLine("dog run ");
Console.Write(count);