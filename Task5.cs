
//Row 15, Column 15 to 12
for (int i = 0; i < 3; i++) //Move 3 cells
{
    move();
}


//Column 12, Row 15 to 8
turn;//From West to North
for (int i = 0; i < 7; i++) //Move 7 cells
{
    move();
}

//Row 8, Column 12 to 8
for (int i = 0; i < 3; i++) ///Turn 3 times from North to West
{
    turn();
}
for (int i = 0; i < 4; i++) //Move 4 cells
{
    move();
}


//Column 8, Row 8 to 3
turn;//From West to North
for (int i = 0; i < 5; i++) //Move 5 cells
{
    move();
}


//Row 3, Column 8 to 3
for (int i = 0; i < 3; i++) ///Turn 3 times from North to West
{
    turn();
}
for (int i = 0; i < 5; i++) //Move 5 cells
{
    move();
}

//Column 3, Row 3 to 16
for (int i = 0; i < 3; i++) ///Turn 3 times from West to South
{
    turn();
}
for (int i = 0; i < 13; i++) //Move 13 cells
{
    move();
}
AtGoal;