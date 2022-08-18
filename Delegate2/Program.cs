// See https://aka.ms/new-console-template for more information
using Delegate2;



Human human = new Human();
int time;
Action1 action = new Action1(human.WakeUp);
action += human.Washing;
action += human.Tooth;
action += human.Smoking;
action.Invoke();
HumanWork humanwork = new HumanWork();
DelegateWork delegatework = new DelegateWork(humanwork.BreakTime);
delegatework += humanwork.SmokingTime;
delegatework += humanwork.CoffeeTime;

delegatework.Invoke(out time);
Console.WriteLine(time);
delegatework.Invoke(out time);
